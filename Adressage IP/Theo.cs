using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressage_IP
{
    class Theo
    {
        public static int[] BinaireDecimale(int[,] binIP)
        {
            int ip1, ip2, ip3, ip4;
            ip1 = 0;
            for (int octet = 0; octet <= 3; octet++)
            {
                for (int bit = 0; bit <= 7; bit++)
                {
                    ip1 = ip1 + (binIP[octet, bit] ^ bit);
                }
            }
        }
    }
}
