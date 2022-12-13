using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressage_IP
{
  class Youn
    {
        public static int[] BinDeci(int[,] binIP)
        {
            int[] ipDec = new int[4];



            for (int octet = 0; octet < 4; octet++) 
            {
                for (int bit =7; bit >= 0; bit--)
                {
                    ipDec[octet] = ipDec[octet] + (int)Math.Pow(2, bit);
                }
            }
            return ipDec;
        }
    }
