using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressage_IP
{
    class Geoffroy
    {
        public static void AfficheIPbin(string message, int[,] ipBin)
        {
            Console.Write(message);

            for (int octet=0;octet <= 3; octet++)
            {
                for (int bit = 0; bit <= 3; bit++)
                {
                    Console.Write(ipBin[octet,bit]);
                }
                Console.Write(".");
            }
        }
    }
}
