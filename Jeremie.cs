using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppIP
{
    class Jeremie
    {
        public static int[,] CalculReseau(int[,] IPbin, int[,] masqueBin)
        {
            int[,] reseauBin = new int[4, 8];

            for (int octet = 0; octet <= 3; octet++)
            {
                
                for (int bit = 7; bit <= 0; bit--)
                {
                    if (masqueBin[octet, bit] == 1)
                    {
                        reseauBin[octet, bit] = IPbin[octet, bit];
                    }
                    else
                    {
                        reseauBin[octet, bit] = 0;
                    }
                }
            }
            return reseauBin;
        }

        

    }
}
