﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adressage_IP
{
    class Program
    {
            static void Main(string[] args)

            {
            /*
                int[] ip = new int[4];

                int[,] ipBin = new int[4, 8];

                int[,] ipReseauBin = new int[4, 8];

                int[] ipReseau = new int[4];

                int[,] masqueBin = new int[4, 8];

                int[] masque = new int[4];

                int cidr;

                ip = SaisieIP();

                ipBin = DecimalBinaire(ip);

                Console.WriteLine("Adresse IP : " + ip[0] + "." + ip[1] + "." + ip[2] + "." + ip[3]);

                Console.Write("CIDR ? ");

                cidr = int.Parse(Console.ReadLine());

                masqueBin = CalculMasque(cidr);

                ipReseauBin = CalculReseau(ipBin, masqueBin);

                ipReseau = BinDeci(ipReseauBin);

                masque = BinDeci(masqueBin);

                Console.WriteLine("Adresse réseau : " + ipReseau[0] + "." + ipReseau[1] + "." + ipReseau[2] + "." + ipReseau[3]);

                Console.WriteLine("Masque : " + masque[0] + "." + masque[1] + "." + masque[2] + "." + masque[3]);

                AfficheIPbin("Adresse IP en Binaire : \t", ipBin);

                AfficheIPbin("Masque en binaire : \t\t", masqueBin);

                AfficheIPbin("Adresse réseau en binaire :\t", ipReseauBin);
                */
            int[,] tab = new int[,] { } 
            Geoffroy.AfficheIPbin("Adresse réseau en binaire :\t",[]);

                Console.ReadKey();
            }
    }
}
