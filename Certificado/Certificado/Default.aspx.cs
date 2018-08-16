using Certificado.Modelos;
using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Certificado
{
    public partial class _Default : Page
    {
        Usuarios usuario;
        Llaves llavePublica1;
        Llaves llavePublica2;
        Llaves certificador1;
        Llaves certificador2;

        Operaciones operaciones;

        //Llaves
        BigInteger nb;
        BigInteger kb1;
        BigInteger kb1_inv;
        BigInteger kb2;
        BigInteger kb2_inv;
        BigInteger kb3;
        BigInteger kb3_inv;
        BigInteger n;

        //Llaves de la entidad
        BigInteger llavePublica1Entidad;
        BigInteger llavePublica2Entidad;
        BigInteger llavePrivada1Entidad;
        BigInteger llavePrivada2Entidad;

        protected void Page_Load(object sender, EventArgs e)
        {
            usuario = new Usuarios();
            llavePublica1 = new Llaves();
            llavePublica2 = new Llaves();
            certificador1 = new Llaves();
            certificador2 = new Llaves();

            operaciones = new Operaciones();
            
        }

        protected void btnInsertar_Click(object sender, EventArgs e)
        {
            if(txtbNombre.Text == "" || txtbApellidos.Text == "" || txtbTelefono.Text == "") {
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Warning\", \"Llene los campos obligatorios (*).\", \"warning\");", true);
                return;
            }
            
            generarLlavesPrivadas();

            usuario.Nombre = txtbNombre.Text;
            usuario.Apellidos = txtbApellidos.Text;
            usuario.Telefono = txtbTelefono.Text;

            llavePublica1.Llave = ((nb * kb1 * kb2) % n).ToString();
            llavePublica2.Llave = ((nb * kb1 * kb3) % n).ToString();

            certificador1.Llave = ((nb * kb1 * kb2_inv) % n).ToString();
            certificador2.Llave = ((nb * kb1 * kb3_inv) % n).ToString();
            
            if (certificar())
            {
                if (operaciones.insertarUsuario(usuario, llavePublica1, llavePublica2, certificador1, certificador2))
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Successful\", \"Operacion realizada con exito.\", \"success\");", true);
                else
                    ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);
            }
            else
                ScriptManager.RegisterStartupScript(this, GetType(), "Popup", "swal(\"Error\", \"Error del servidor.\", \"error\");", true);


            txtbNombre.Text = string.Empty;
            txtbApellidos.Text = string.Empty;
            txtbTelefono.Text = string.Empty;

            Session["Nb"] = nb;
            Session["Kb1"] = kb1;
            Session["Kb2"] = kb2;
            Session["Kb3"] = kb3;

            btnImprimirLlaves.Visible = true;
        }

        private void generarLlavesPrivadas()
        {
            bool bandera;

            //Se obtiene el modulo
            n = ToBigInteger(operaciones.obtenerModulo(1));

            // Se genera na que es un no invertible
            do
            {
                nb = RandomBigInteger(2, n);
            } while (Euclides.moduloInverso(n, nb));


            // Se genera ka1 que es un invertible
            do
            {
                kb1 = RandomBigInteger(2, n);

                bandera = Euclides.moduloInverso(n, kb1);

                kb1_inv = Euclides.inv;

            } while (!bandera);


            // Se genera ka2 que es un invertible
            do
            {
                kb2 = RandomBigInteger(2, n);

                bandera = Euclides.moduloInverso(n, kb2);

                kb2_inv = Euclides.inv;

                if (bandera)
                    if (kb2 == kb1)
                        bandera = false;

            } while (!bandera);

            // Se genera ka3 que es un invertible
            do
            {
                kb3 = RandomBigInteger(2, n);

                bandera = Euclides.moduloInverso(n, kb3);

                kb3_inv = Euclides.inv;

                if (bandera)
                    if (kb2 == kb3 || kb3 == kb1)
                        bandera = false;

            } while (!bandera);

        }

        protected void btnImprimir_Click(object sender, EventArgs e)
        {
            StringBuilder objSB = new StringBuilder();
            objSB.AppendLine(Convert.ToString(Session["Nb"]));
            objSB.AppendLine(Convert.ToString(Session["Kb1"]));
            objSB.AppendLine(Convert.ToString(Session["Kb2"]));
            objSB.AppendLine(Convert.ToString(Session["Kb3"]));
            
            Response.AddHeader("content-disposition", "attachment;filename=llaves.txt");
            Response.ContentType = "text/text";
            Response.Output.Write(objSB);
            Response.End();
        }

        private Boolean certificar()
        {
            Boolean certificacion = false;

            DataTable dt = operaciones.obtenerLlavesEntidad(1);

            llavePublica1Entidad = ToBigInteger(dt.Rows[0].ItemArray[0].ToString());
            llavePublica2Entidad = ToBigInteger(dt.Rows[1].ItemArray[0].ToString());
            llavePrivada1Entidad = ToBigInteger(dt.Rows[2].ItemArray[0].ToString());
            llavePrivada2Entidad = ToBigInteger(dt.Rows[3].ItemArray[0].ToString());

            BigInteger certificado1 = (llavePrivada1Entidad * ToBigInteger(llavePublica1.Llave) % n);
            BigInteger certificado2 = (llavePrivada2Entidad * ToBigInteger(llavePublica2.Llave) % n);

            if (verificar(certificado1, certificado2))
                certificacion = true;
            
            return certificacion;
        }
        
        public BigInteger ToBigInteger(string value)
        {
            BigInteger result = 0;
            for (int i = 0; i < value.Length; i++)
            {
                result = result * 10 + (value[i] - '0');
            }
            return result;
        }

        public BigInteger RandomBigInteger(BigInteger min, BigInteger max)
        {
            Random rnd = new Random();
            string numeratorString, denominatorString;
            double fraction = rnd.NextDouble();
            BigInteger inRange;

            //Maintain all 17 digits of precision, 
            //but remove the leading zero and the decimal point;
            numeratorString = fraction.ToString("G17").Remove(0, 2);

            //Use the length instead of 17 in case the random
            //fraction ends with one or more zeros
            denominatorString = string.Format("1E{0}", numeratorString.Length);

            inRange = (max - min) * BigInteger.Parse(numeratorString) /
               BigInteger.Parse(denominatorString,
               System.Globalization.NumberStyles.AllowExponent)
               + min;
            return inRange;
        }

        private Boolean verificar(BigInteger certificado1, BigInteger certificado2)
        {
            Boolean verificacion = false;

            BigInteger verificacion1 = ((certificado1 * ToBigInteger(certificador1.Llave) * llavePublica1Entidad) % n);
            BigInteger verificacion2 = ((certificado2 * ToBigInteger(certificador2.Llave) * llavePublica2Entidad) % n);

            if (verificacion1 == verificacion2)
                verificacion = true;

            return verificacion;
        }

    }
}