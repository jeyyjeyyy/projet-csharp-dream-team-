using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace iptruc
{
    class Mathis
    {
        public static int[,] CalculMasque(int CIDR)
        {
            int[,] masque = new int[4,8];

            for (int octet = 0; octet < 4; octet++)
                    

                for (int bit = 7; bit >= 0; bit--)
                    {
                         if (CIDR>0)
                    {
                        masque[octet, bit] = 1;
                        CIDR=CIDR-1;
                    }
                    else
                    {
                        masque[octet, bit] = 0;
                    }
                    }

            }

            
        }
        
    }
}
