using System;

namespace Atv_array
{
    class Program
    {
        static void Main(string[] args)
        {
            // int n1 , n2 , n3 , n4 , n5
            // int[] n = new int[5];
            // int[] num = new int[3] { 55, 77, 99 };
            // string[] veiculos = new string[3];

            // veiculos[0] = "carro";
            // veiculos[1] = "moto";
            //  veiculos[2] = "aviao";

            // n[0] = 50;
            // n[1] = 66;
            // n[2] = 33;
            // n[3] = 88;
            // n[4] = 44;

            // Console.WriteLine(n[4]);

            int[,] n = new int[3, 5];
            int[,] num = new int[2, 2] { { 10, 20 }, { 30, 40 } };

                                      
            
            
            
            
            
                                                   // MATRIZES     
            /*
            10 20 30 40 50
            88 44 90 66 30
            55 74 2  33 98
        
             */

            n[0, 0] = 10;
            n[0, 1] = 20;
            n[0, 2] = 30;
            n[0, 3] = 40;
            n[0, 4] = 50;

            n[1, 0] = 88;
            n[1, 1] = 44;
            n[1, 2] = 90;
            n[1, 3] = 66;
            n[1, 4] = 30;

            n[2, 0] = 55;
            n[2, 1] = 74;
            n[2, 2] = 2;
            n[2, 3] = 33;
            n[2, 4] = 98;

            Console.WriteLine(n[2,4 ]);











        }
    }
}
