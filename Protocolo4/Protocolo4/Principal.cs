﻿using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Numerics;
using System.IO;
using Newtonsoft.Json;
using System.Drawing;

namespace Protocolo1
{
    public partial class Principal : Form
    {

        Protocolo4.WSOperacion.WSOperacionesSoapClient operaciones;

        String valorRecibido;
        BigInteger resultadoOperacion;

        string ipAddress = "";

        //Llaves
        BigInteger modulo;

        BigInteger k1;
        BigInteger k2;
        BigInteger k3;
        BigInteger k1_inv;
        BigInteger k2_inv;
        BigInteger k3_inv;
        BigInteger n;

        BigInteger m1;
        BigInteger m2;

        BigInteger llavePublica1Contrario;
        BigInteger llavePublica2Contrario;

        BigInteger R0;
        BigInteger R1;
        BigInteger R2;
        BigInteger R3;
        BigInteger R4;
        BigInteger R5;
        BigInteger R6;
        //N es un numero no primo 
        //ka y kb pueden ser negativos 

        TimeSpan stop;
        TimeSpan start;

        Boolean datos = false;
        Boolean canales = false;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            operaciones = new Protocolo4.WSOperacion.WSOperacionesSoapClient();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = Convert.ToString(ipHostInfo.AddressList.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetwork));
            label1.Text = "Protocolo llave publica (" + ipAddress + ")";

            this.Size = new Size(397, 518);
            pbxCerrar.Location = new Point(346, 5);
            cbCoS.SelectedIndex = 0;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            if (txtbIP.Text != "")
            {
                btnEmpezar.Enabled = false;
                gbTiempos.Visible = true;
                protocolo();
                btnEmpezar.Enabled = true;
            }

        }


        #region Protocolo

        private void protocolo()
        {
            try
            {
                if (!operaciones.VerificarCertificado(txtbTelefono.Text))
                {
                    MessageBox.Show("Esta persona no tiene una verificacion adecuada");
                    return;
                } else
                    MessageBox.Show("Esta persona paso la verificacion");

                DataTable dt = (DataTable)JsonConvert.DeserializeObject(operaciones.obtenerLlavesPublica(txtbTelefono.Text), typeof(DataTable));

                if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("Esta persona no esta certificada");
                    return;
                }

                llavePublica1Contrario = ToBigInteger(dt.Rows[0].ItemArray[0].ToString());
                llavePublica2Contrario = ToBigInteger(dt.Rows[1].ItemArray[0].ToString());

                if (cbCoS.SelectedIndex == 0)
                {
                    Emisor();


                }
                else if (cbCoS.SelectedIndex == 1)
                {
                    Receptor();

                }

            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar, revise que la IP sea correcta y desactive el firewall");
            }

        }

        public void Emisor()
        {
            //Generar numeros aleatorios y rectificar con euclides, asi mismo se verifica el tiempo
            start = new TimeSpan(DateTime.Now.Ticks);
            numAleatorio();
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador1.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            //Se inicia el contador para el envio de datos
            start = new TimeSpan(DateTime.Now.Ticks);

            //Primer canal (Enviar)
            enviar(1);
            txtbCanal1.Text = resultadoOperacion.ToString();

            //Segundo canal (Recibir)
            R0 = recibir();

            R1 = (R0 * llavePublica1Contrario) % modulo;
            R2 = (R0 * llavePublica2Contrario) % modulo;

            txtbCanal2.Text = R0.ToString();

            //Tercer canal (Enviar)
            enviar(3);
            txtbCanal3.Text = resultadoOperacion.ToString();

            //cuarto canal (Enviar)
            enviar(4);
            txtbCanal4.Text = resultadoOperacion.ToString();

            //quinto canal (Recibir)
            R3 = recibir();

            R5 = (R3 * R1 * k2 * k3) % modulo;

            txtbCanal5.Text = R3.ToString();

            //sexto canal (Recibir)
            R4 = recibir();

            R6 = (R4 * R2 * k2 * k3) % modulo;

            txtbCanal6.Text = R4.ToString();

            if (R5 == R6)
                R5 = ((R6 * m2 * n) % modulo);

            txtbResultado.Text = R5.ToString();

            //Se imprime el tiempo
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador2.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            lblRContador3.Text = (Convert.ToDouble(lblRContador1.Text) + Convert.ToDouble(lblRContador2.Text)).ToString();
        }

        public void Receptor()
        {
            //Generar numeros aleatorios y rectificar con euclides, asi mismo se verifica el tiempo
            start = new TimeSpan(DateTime.Now.Ticks);
            numAleatorio();
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador1.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            //Se inicia el contador para el envio de datos
            start = new TimeSpan(DateTime.Now.Ticks);

            //Canal 1 (recibir)
            R0 = recibir();

            R1 = (R0 * llavePublica1Contrario) % modulo;
            R2 = (R0 * llavePublica2Contrario) % modulo;

            txtbCanal1.Text = R0.ToString();

            //segundo canal (Enviar)
            enviar(2);
            txtbCanal2.Text = resultadoOperacion.ToString();

            //quinto canal (Recibir)
            R3 = recibir();

            txtbCanal3.Text = R3.ToString();

            //sexto canal (Recibir)
            R4 = recibir();

            txtbCanal4.Text = R4.ToString();

            //quinto canal (Enviar)
            enviar(5);
            txtbCanal5.Text = resultadoOperacion.ToString();

            //sexto canal (Enviar)
            enviar(6);
            txtbCanal6.Text = resultadoOperacion.ToString();

            R5 = (R3 * R1 * k2 * k3) % modulo;
            R6 = (R4 * R2 * k2 * k3) % modulo;

            if (R5 == R6)
                R5 = ((R6 * m2 * n) % modulo);

            txtbResultado.Text = R5.ToString();

            //Se imprime el tiempo
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador2.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            lblRContador3.Text = (Convert.ToDouble(lblRContador1.Text) + Convert.ToDouble(lblRContador2.Text)).ToString();
        }

        private void numAleatorio()
        {
            // Se genera na que es un no invertible
            do
            {
                m1 = RandomBigInteger(2, modulo);
            } while (Euclides.moduloInverso(modulo, m1));


            txtbM1.Text = m1.ToString();

            // Se genera na que es un no invertible
            do
            {
                m2 = RandomBigInteger(2, modulo);
            } while (Euclides.moduloInverso(modulo, m2));


            txtbM2.Text = m2.ToString();
            
        }

        private String binario(int bits)
        {
            Random rnd = new Random();
            String cadena = "";

            for (int i = 0; i < bits; i++)
                cadena += rnd.Next(0, 2);

            return cadena;
        }

        private BigInteger binarioADecimal(string input)
        {
            char[] array = input.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            BigInteger sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (BigInteger)Math.Pow(2, i);
                }
            }
            return sum;
        }

        private bool esPrimo(BigInteger number)
        {
            if (number == 0 || number == 1)
                return false;

            if ((number & 1) == 0)
                return (number == 2);

            BigInteger limit = (BigInteger)Math.Exp(BigInteger.Log(number) / 2);

            for (int i = 3; i <= limit; i += 2)
                if ((number % i) == 0)
                    return false;

            return true;
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

        #endregion


        #region Sockets

        private void enviar(int canal)
        {
            byte[] info = new byte[255];

            Thread.Sleep(10);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(txtbIP.Text), 8000);


            if (canal == 1)
                resultadoOperacion = (m1 * k2_inv * k3_inv) % modulo; //Emisor
            else if (canal == 2)
                resultadoOperacion = (m1 * k2_inv * k3_inv) % modulo; //Receptor
            else if (canal == 3)
                resultadoOperacion = (R0 * m2 * k1_inv * k3) % modulo; //Emisor
            else if (canal == 4)
                resultadoOperacion = (R0 * m2 * k1_inv * k2) % modulo; //Emisor
            else if (canal == 5)
                resultadoOperacion = (R0 * m2 * k1_inv * k3) % modulo; //Receptor
            else if (canal == 6)
                resultadoOperacion = (R0 * m2 * k1_inv * k2) % modulo; //Receptor

            socket.Connect(direccion);
            info = Encoding.Default.GetBytes(resultadoOperacion.ToString());
            socket.Send(info, 0, info.Length, 0);

            socket.Close();
        }

        private BigInteger recibir()
        {
            valorRecibido = "";
            byte[] info = new byte[255];
            Socket escuchar;
            int size;

            Thread.Sleep(5);
            Socket socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse(ipAddress), 8000);

            socket.Bind(direccion);
            socket.Listen(1);

            escuchar = socket.Accept();
            size = escuchar.Receive(info, 0, info.Length, 0);
            Array.Resize(ref info, size);
            valorRecibido = Encoding.Default.GetString(info);

            socket.Close();

            return ToBigInteger(valorRecibido);
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

        #endregion

        private void btnCargarLlaves_Click(object sender, EventArgs e)
        {
            if (ofdAbrir.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {

                string fichero = ofdAbrir.FileName;
                string contenido = String.Empty;

                if (File.Exists(fichero))
                {
                    contenido = File.ReadAllText(fichero);
                    string[] lineas = contenido.Split(Environment.NewLine.ToCharArray());

                    for (int i = 0; i < 7; i++)
                    {
                        if (i == 0)
                            n = ToBigInteger(lineas[i]);
                        if (i == 2)
                            k1 = ToBigInteger(lineas[i]);
                        if (i == 4)
                            k2 = ToBigInteger(lineas[i]);
                        if (i == 6)
                            k3 = ToBigInteger(lineas[i]);
                    }

                    modulo = ToBigInteger(operaciones.obtenerModulo(1));
                    txtbN.Text = modulo.ToString();

                    txtbNaNb.Text = n.ToString();

                    Euclides.moduloInverso(modulo, k1);
                    k1_inv = Euclides.inv;
                    Euclides.moduloInverso(modulo, k2);
                    k2_inv = Euclides.inv;
                    Euclides.moduloInverso(modulo, k3);
                    k3_inv = Euclides.inv;

                    txtbK1.Text = k1.ToString();
                    txtbK1Inv.Text = k1_inv.ToString();

                    txtbK2.Text = k2.ToString();
                    txtbK2Inv.Text = k2_inv.ToString();

                    txtbK3.Text = k3.ToString();
                    txtbK3Inv.Text = k3_inv.ToString();
                }

            }

        }

        private void pbxCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            if (datos) {
                this.Size = new Size(397, 518);
                pbxCerrar.Location = new Point(346, 5);
                datos = false;
                canales = false;
                btnDatos.BackgroundImage = Protocolo4.Properties.Resources.proximo;
                btnCanales.BackgroundImage = Protocolo4.Properties.Resources.proximo;
            } else {
                this.Size = new Size(795, 668);
                pbxCerrar.Location = new Point(735, 4);
                datos = true;
                btnDatos.BackgroundImage = Protocolo4.Properties.Resources.espalda;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (canales) {
                this.Size = new Size(795, 668);
                pbxCerrar.Location = new Point(735, 4);
                canales = false;
                btnCanales.BackgroundImage = Protocolo4.Properties.Resources.proximo;
            } else {
                this.Size = new Size(1194, 668);
                pbxCerrar.Location = new Point(1150, 5);
                canales = true;
                btnCanales.BackgroundImage = Protocolo4.Properties.Resources.espalda;
            }
        }

        private void cbCoS_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
