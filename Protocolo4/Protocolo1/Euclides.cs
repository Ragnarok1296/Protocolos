using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace Protocolo1
{
    class Euclides
    {

        public static BigInteger inv = 0;

        public static bool moduloInverso(BigInteger n, BigInteger a)
        {
            BigInteger[] resp = new BigInteger[3];
            resp = euclidesExtendido(a, n);

            if (resp[0] > 1)
                return false;

            else
            {
                if (resp[1] < 0)
                    inv = resp[1] + n;
                else
                    inv = resp[1];

                return true;
            }
        }

        public static BigInteger[] euclidesExtendido(BigInteger a, BigInteger b)
        {
            BigInteger[] resp = new BigInteger[3];
            BigInteger x = 0, y = 0;

            if (b == 0)
            {
                resp[0] = a; resp[1] = 1; resp[2] = 0;
            }
            else
            {
                BigInteger x2 = 1, x1 = 0, y2 = 0, y1 = 1;
                BigInteger q = 0, r = 0;

                while (b > 0)
                {
                    q = (a / b);
                    r = a - q * b;
                    x = x2 - q * x1;
                    y = y2 - q * y1;
                    a = b;
                    b = r;
                    x2 = x1;
                    x1 = x;
                    y2 = y1;
                    y1 = y;
                }

                resp[0] = a;
                resp[1] = x2;
                resp[2] = y2;
            }

            return resp;
        }
    }
}
