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

namespace Protocolo1
{
    public partial class Principal : Form
    {
        String valorRecibido;
        BigInteger resultadoOperacion;

        //Llaves
        BigInteger na;
        BigInteger ka;
        BigInteger ka_inv;
        BigInteger kb;
        BigInteger kb_inv;
        BigInteger n;
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

        private void cbCoS_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            btnEmpezar.Visible = true;
            lblIP.Visible = true;
            txtbIP.Visible = true;

            if (cbCoS.SelectedIndex == 0)
            {
                lblIP.Text = "IP de Bob:";
                lblKaKb.Text = "Ka";
                lblKaKbInv.Text = "Ka Inversa";
            }
            else if (cbCoS.SelectedIndex == 1)
            {
                lblIP.Text = "IP de Alice:";
                lblKaKb.Text = "Kb";
                lblKaKbInv.Text = "Kb Inversa";
            }
                
        }


        #region Protocolo

        private void protocolo()
        {
            try
            {
                if (cbCoS.SelectedIndex == 0)
                {
                    Alice();

                    txtbN.Text = n.ToString();
                    txtbNa.Text = na.ToString();
                    txtbKaKb.Text = ka.ToString();
                    txtbKaKbInv.Text = ka_inv.ToString();
                }
                else if (cbCoS.SelectedIndex == 1)
                {
                    Bob();

                    txtbN.Text = n.ToString();
                    txtbNa.Text = na.ToString();
                    txtbKaKb.Text = kb.ToString();
                    txtbKaKbInv.Text = kb_inv.ToString();
                }
                
            }
            catch (Exception e)
            {
                MessageBox.Show("Error al conectar, revise que la IP sea correcta y desactive el firewall");
                gbTiempos.Enabled = false;
            }

        }

        public void Alice()
        {
            //Generar numeros aleatorios y rectificar con euclides, asi mismo se verifica el tiempo
            start = new TimeSpan(DateTime.Now.Ticks);
            numAleatorio();
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador1.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            //Se inicia el contador para el envio de datos
            start = new TimeSpan(DateTime.Now.Ticks);

            //Canal 0 envio de modulo(enviar)
            enviar(0);

            //Primer canal (Enviar)
            enviar(1);

            //Segundo canal (Recibir)
            txtbCanal2.Text = recibir().ToString();

            //Tercer canal (Enviar)
            enviar(3);

            //Se imprime el tiempo
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador2.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            lblRContador3.Text = (Convert.ToDouble(lblRContador1.Text) + Convert.ToDouble(lblRContador2.Text)).ToString();
        }

        public void Bob()
        {

            //Canal 0 Recibir modulo(Recibir)
            n = recibir();

            //Generar numeros aleatorios y rectificar con euclides, asi mismo se verifica el tiempo
            start = new TimeSpan(DateTime.Now.Ticks);
            numAleatorio();
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador1.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            //Se inicia el contador para el envio de datos
            start = new TimeSpan(DateTime.Now.Ticks);

            //Primer canal (recibir)
            txtbCanal1.Text = recibir().ToString();

            //Segundo canal (Enviar)
            enviar(2);

            //Tercer canal (recibir)
            BigInteger aux = recibir();

            //Se obtiene Na
            na = (aux * kb_inv) % n;
            txtbCanal3.Text = aux.ToString();

            //Se imprime el tiempo
            stop = new TimeSpan(DateTime.Now.Ticks);
            lblRContador2.Text = (stop.Subtract(start).TotalMilliseconds).ToString();

            lblRContador3.Text = (Convert.ToDouble(lblRContador1.Text) + Convert.ToDouble(lblRContador2.Text)).ToString();
        }

        private void numAleatorio()
        {
            if (cbCoS.SelectedIndex == 0) {
                
                //Se obtiene el modulo
                do {
                    n = binarioADecimal(binario(Convert.ToInt16(cbBits.SelectedItem.ToString())));
                } while(esPrimo(n));
                
                // Se genera na que es un no invertible
                do {
                    na = RandomBigInteger(2, n);
                } while (Euclides.moduloInverso(n, na));

                bool bandera;
                // Se genera ka que es un invertible
                do {
                    ka = RandomBigInteger(2, n);

                    bandera = Euclides.moduloInverso(n, ka);
                    
                        ka_inv = Euclides.inv;

                } while (!bandera);
                
            }
            else if (cbCoS.SelectedIndex == 1) {

                bool bandera;
                // Se genera ka que es un invertible
                do
                {
                    kb = RandomBigInteger(2, n);

                    bandera = Euclides.moduloInverso(n, kb);
                    
                        kb_inv = Euclides.inv;

                } while (!bandera);
                
                
            }

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

            if (canal == 0)
                resultadoOperacion = n;
            else if (canal == 1)
                resultadoOperacion = (ka * na) % n; //Cambiar por el valor de 256 bits
            else if (canal == 2)
                resultadoOperacion = (ToBigInteger(valorRecibido) * kb) % n; //Cambiar por el valor de 256 bits
            else if (canal == 3)
                resultadoOperacion = (ToBigInteger(valorRecibido) * ka_inv) % n; //Cambiar por el valor de 256 bits

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
            IPEndPoint direccion = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 8000);

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
    }
}
