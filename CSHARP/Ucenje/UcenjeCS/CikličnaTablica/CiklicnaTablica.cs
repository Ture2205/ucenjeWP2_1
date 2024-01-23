using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UcenjeCS.CiklicnaTablica
{
    internal class CiklicnaTablica
    {
        public static void Izvedi()
        {

            Console.WriteLine("Unesite broj redova : ");
            int red = int.Parse(Console.ReadLine());
            Console.WriteLine("Unesite broj stupaca : ");
            int stupac = int.Parse(Console.ReadLine());


            int[,] matrica = new int[red, stupac];


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            //matrica[(red - 1), (stupac - 1)] = 1;
            //matrica[(red - 1), (stupac - 2)] = 2;
            //matrica[(red - 1), (stupac - 3)] = 3;
            //matrica[(red - 1), (stupac - 4)] = 4;
            //matrica[(red - 1), (stupac - 5)] = 5;
            int b = 1;

            for (int i = 1; i <= stupac; i++)
            {
                matrica[(red - 1), (stupac - i)] = b++;
            }



            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 2; i < red; i++)
            {
                matrica[(red - i), 0] = b++;
            }

            //matrica[(red - 2), 0] = b++;
            //matrica[(red - 3), 0] = b++;
            //matrica[(red - 4), 0] = b++;
            //matrica[(red - 5), 0] = b++;

            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 0; i < stupac; i++)
            {
                matrica[0, i] = b++;
            }



            //matrica[0, 1] = b++;
            //matrica[0, 2] = b++;
            //matrica[0, 3] = b++;
            //matrica[0, 4] = b++;




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            for (int i = +1; i < red - 1; i++)
            {
                matrica[i, (stupac - 1)] = b++;
            }


            //matrica[1, (stupac - 1)] = b++;
            //matrica[2, (stupac - 1)] = b++;
            //matrica[3, (stupac - 1)] = b++;


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            //matrica[(red - 2), (stupac - 2)] = b++;
            //matrica[(red - 2), (stupac - 3)] = b++;
            //matrica[(red - 2), (stupac - 4)] = b++;

            for (int i = 1; i < stupac-1; i++)
            {
                matrica[(red - 2), (stupac - (i+1))] = b++;
            }



            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            //matrica[(red - 3), 1] = b++;
            //matrica[(red - 4), 1] = b++;



            for (int i = 3; i < red; i++)
            {
                matrica[(red - i), 1] = b++;
            }



            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 2; i < stupac-1; i++)
            {
                matrica[1, i] = b++;
            }




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            for (int i = 2; i < red - 2; i++)
            {
                matrica[i, (stupac - 2)] = b++;
            }




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            //matrica[3, 3] = b++;
            //matrica[3, 2] = b++;


            for (int i = 3; i < stupac - 1; i++)
            {
                matrica[(red - 3), (stupac - i)] = b++;
            }


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 4; i < red - 1; i++)
            {
                matrica[(red - i), 2] = b++;
            }


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");












            for (int i = 3; i < stupac - 3; i++)
            {
                matrica[2, i] = b++;
            }




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            for (int i = 2; i < red - 3; i++)
            {
                matrica[i, (stupac - 3)] = b++;
            }




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");


            for (int i = 4; i < stupac - 2; i++)
            {
                matrica[(red - 4), (stupac - i)] = b++;
            }




            //for (int i = 2; i < stupac - 4; i++)
            //{
            //    matrica[(red - 4), (stupac - (i + 2))] = b++;   // ?
            //}


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 5; i < red - 2; i++)
            {
                matrica[(red - i), 3] = b++;
            }


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            //matrica[3, 4] = b++;
            //matrica[3, 5] = b++;
            //matrica[3, 6] = b++;



            for (int i = 4; i < stupac - 3; i++)
            {
                matrica[3, i] = b++;
            }


            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

            for (int i = 4; i < red - 4; i++)
            {
                matrica[i, (stupac - 4)] = b++;
            }




            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");
            for (int i = 3; i < stupac - 5; i++)
            {
                matrica[(red - 5), (stupac - (i + 2))] = b++;
            }





            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");


            for (int i = 6; i < red - 3; i++)
            {
                matrica[(red - i), 4] = b++;
            }



            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");




            for (int i = 5; i < stupac - 4; i++)
            {
                matrica[4, i] = b++;
            }



            for (int i = 0; i < red; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < stupac; j++)
                {

                    Console.Write("{0,6}", (matrica[i, j]));
                }
                Console.WriteLine();
            }
            Console.WriteLine("***********************************************************");

        }
    }
}
