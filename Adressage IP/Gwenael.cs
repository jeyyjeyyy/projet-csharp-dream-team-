using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AppAdresseIP
{
    public class Gwenael
    {
        public static int[,] DecimalBinaire(int[] ipDecimal)
        {
            int[,] resultat = new int[4, 8];
            foreach(int indice in ipDecimal)
            {
                int tmp = indice;
                for(int bit = 7; bit >= 0; bit--)
                {
                    if(tmp >= Math.Pow(2, bit))
                    {
                        resultat[Array.IndexOf(ipDecimal, indice), bit] = 1;
                        tmp = (int)(tmp - Math.Pow(2, bit));
                    }
                    else
                    {
                        resultat[Array.IndexOf(ipDecimal, indice), bit] = 0;
                    }
                }
            }
            return resultat;
        }
    }
}