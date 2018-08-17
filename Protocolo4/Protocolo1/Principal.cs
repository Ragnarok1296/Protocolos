using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.Numerics;
using System.Diagnostics;
using Certificado.Modelos;
using System.IO;

namespace Protocolo1
{
    public partial class Principal : Form
    {
        Operaciones operaciones;

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

        BigInteger resultadoFinal;
        //N es un numero no primo 
        //ka y kb pueden ser negativos 

        TimeSpan stop;
        TimeSpan start;

        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            operaciones = new Operaciones();
            IPHostEntry ipHostInfo = Dns.GetHostEntry(Dns.GetHostName());
            ipAddress = Convert.ToString(ipHostInfo.AddressList.FirstOrDefault(address => address.AddressFamily == AddressFamily.InterNetwork));
            this.Text = "Protocolo llave publica (" + ipAddress + ")";
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
                modulo = ToBigInteger(operaciones.obtenerModulo(1));

                DataTable dt = operaciones.obtenerLlavesPublica(txtbTelefono.Text);

                n = ToBigInteger(dt.Rows[0].ItemArray[0].ToString());
                llavePublica1Contrario = ToBigInteger(dt.Rows[0].ItemArray[0].ToString());
                llavePublica2Contrario = ToBigInteger(dt.Rows[0].ItemArray[0].ToString());


                Euclides.euclidesExtendido(modulo, k1);
                k1_inv = Euclides.inv;
                Euclides.euclidesExtendido(modulo, k2);
                k2_inv = Euclides.inv;
                Euclides.euclidesExtendido(modulo, k3);
                k3_inv = Euclides.inv;


                if (cbCoS.SelectedIndex == 0)
                {
                    Emisor();

                    txtbResultado.Text = resultadoFinal.ToString();
                }
                else if (cbCoS.SelectedIndex == 1)
                {
                    Receptor();

                    txtbResultado.Text = resultadoFinal.ToString();
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

            //Segundo canal (Recibir)
            recibir();

            //Tercer canal (Enviar)
            enviar(3);

            //cuarto canal (Enviar)
            enviar(4);

            //quinto canal (Recibir)
            BigInteger valorRecibido1 = recibir();

            //sexto canal (Recibir)
            BigInteger valorRecibido2 = recibir();

            if(valorRecibido1 == valorRecibido2)
                resultadoFinal = ((valorRecibido1 * m2 * n) % modulo);


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
            recibir();

            //segundo canal (Enviar)
            enviar(2);

            //quinto canal (Recibir)
            BigInteger valorRecibido1 = recibir();

            //sexto canal (Recibir)
            BigInteger valorRecibido2 = recibir();

            //quinto canal (Enviar)
            enviar(5);

            //sexto canal (Enviar)
            enviar(6);

            if (valorRecibido1 == valorRecibido2)
                resultadoFinal = ((valorRecibido1 * m2 * n) % modulo);

            //Se imprime el tiempo
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador2.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            lblRContador3.Text = (Convert.ToDouble(lblRContador1.Text) + Convert.ToDouble(lblRContador2.Text)).ToString();
        }

        private void numAleatorio()
        {
            //if (cbCoS.SelectedIndex == 0) {
                
                
                
                // Se genera na que es un no invertible
                do {
                    m1 = RandomBigInteger(2, modulo);
                } while (Euclides.moduloInverso(modulo, m1));


                // Se genera na que es un no invertible
                do {
                    m2 = RandomBigInteger(2, modulo);
                } while (Euclides.moduloInverso(modulo, m2));
                
                
            /*}
            else if (cbCoS.SelectedIndex == 1) {
                //Genrar nb (No inversible)
                do
                {
                    nb = RandomBigInteger(2, n);
                } while (Euclides.moduloInverso(n, nb));

                bool bandera;
                
                // Se genera kb que es un invertible
                do
                {
                    kb = RandomBigInteger(2, n);

                    bandera = Euclides.moduloInverso(n, kb);
                    
                        kb_inv = Euclides.inv;

                } while (!bandera);
                
                
            }*/

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
                resultadoOperacion = (m1 * k2_inv * k3_inv) % modulo; //Cambiar por el valor de 256 bits
            else if (canal == 2)
                resultadoOperacion = (m1 * k2_inv * k3_inv) % modulo; //Cambiar por el valor de 256 bits
            else if (canal == 3)
                resultadoOperacion = (ToBigInteger(valorRecibido) * m2 * k1_inv * k3 ) % modulo; //Cambiar por el valor de 256 bits
            else if (canal == 4)
                resultadoOperacion = (ToBigInteger(valorRecibido) * m2 * k1_inv * k2) % modulo; //Cambiar por el valor de 256 bits
            else if (canal == 5)
                resultadoOperacion = (ToBigInteger(valorRecibido) * m2 * k1_inv * k3) % modulo;
            else if (canal == 6)
                resultadoOperacion = (ToBigInteger(valorRecibido) * m2 * k1_inv * k2) % modulo;

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

            return ToBigInteger(valorRecibido) ;
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

                    for (int i=0; i<6; i++)
                    {
                        if (i == 0)
                            n = ToBigInteger(lineas[i]);
                        if (i == 2)
                            k1 = ToBigInteger(lineas[i]);
                        if (i == 4)
                            k2 = ToBigInteger(lineas[i]);
                        if (i == 5)
                            k3 = ToBigInteger(lineas[i]);
                    }

                }

            }
                
        }
    }
}
