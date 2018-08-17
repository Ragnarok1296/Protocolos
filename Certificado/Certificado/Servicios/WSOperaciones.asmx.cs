using Certificado.Modelos;
using Newtonsoft.Json;
using System;
using System.Data;
using System.Numerics;
using System.Web.Services;

namespace Certificado.Servicios
{
    /// <summary>
    /// Descripción breve de WSOperaciones
    /// </summary>
    [WebService(Namespace = "http://microsoft.com/webservices/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class WSOperaciones : System.Web.Services.WebService
    {
        private MySQLConnection conexion;
        private Operaciones operaciones;

        // Instanciamos la conexion y al modelo
        public WSOperaciones()
        {
            conexion = new MySQLConnection();
            operaciones = new Operaciones();
        }

        [WebMethod]
        public String obtenerModulo(int id)
        {
            String modulo = "";

            if (conexion.connection())
            {
                string query = "Call obtenerModulo('" + id + "');";

                modulo = conexion.consulta_busqueda(query).Rows[0].ItemArray[0].ToString();

            }

            return modulo;
        }

        [WebMethod]
        public String obtenerLlavesPublica(string telefono)
        {
            string json = "";

            if (conexion.connection())
            {
                string query = "Call obtenerLlavePublica('" + telefono + "');";
                
                json = JsonConvert.SerializeObject(conexion.consulta_busqueda(query));

            }

            return json;
        }

        [WebMethod]
        public Boolean VerificarCertificado(string telefono)
        {
            Boolean verificacion = false;

            if (conexion.connection())
            {
                string query = "Call obtenerLlavePublica('" + telefono + "');";

                DataTable dtPersona = (conexion.consulta_busqueda(query));

                BigInteger llavePublica1Persona = ToBigInteger(dtPersona.Rows[0].ItemArray[0].ToString());
                BigInteger llavePublica2Persona = ToBigInteger(dtPersona.Rows[1].ItemArray[0].ToString());
                BigInteger certificador1Persona = ToBigInteger(dtPersona.Rows[2].ItemArray[0].ToString());
                BigInteger certificador2Persona = ToBigInteger(dtPersona.Rows[3].ItemArray[0].ToString());

                DataTable dtEntidad = operaciones.obtenerLlavesEntidad(1);

                BigInteger llavePublica1Entidad = ToBigInteger(dtEntidad.Rows[0].ItemArray[0].ToString());
                BigInteger llavePublica2Entidad = ToBigInteger(dtEntidad.Rows[1].ItemArray[0].ToString());
                BigInteger llavePrivada1Entidad = ToBigInteger(dtEntidad.Rows[2].ItemArray[0].ToString());
                BigInteger llavePrivada2Entidad = ToBigInteger(dtEntidad.Rows[3].ItemArray[0].ToString());

                BigInteger modulo = ToBigInteger(operaciones.obtenerModulo(1));

                BigInteger certificado1 = (llavePrivada1Entidad * llavePublica1Persona % modulo);
                BigInteger certificado2 = (llavePrivada2Entidad * llavePublica2Persona % modulo);

                BigInteger verificacion1 = ((certificado1 * certificador1Persona * llavePublica1Entidad) % modulo);
                BigInteger verificacion2 = ((certificado2 * certificador2Persona * llavePublica2Entidad) % modulo);

                if (verificacion1 == verificacion2)
                    verificacion = true;

            }

            return verificacion;
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

    }
}
