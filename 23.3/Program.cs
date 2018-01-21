using System;
using System.Collections.Generic;

namespace _23._3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<List<byte>> mass = new List<List<byte>>();
            List<byte> row = new List<byte>();
            List<int> sum = new List<int>();
            int n = 4;
            int min = 99 ^ 9;
            int max = -99 ^ 9;
            int ii = 0;
            int ii2 = 0;
            byte c = 0;

            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                row = new List<byte>();
                for (int j = 0; j < n; j++) row.Add((byte)rand.Next(10));
                mass.Add(row);
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mass[i][j].ToString() + " ");
                Console.WriteLine();
            }

            Console.WriteLine();
            int s1 = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    s1 = s1 + mass[i][j];
                    Console.Write(mass[i][j].ToString() + " ");
                }
                sum.Add(s1);
                Console.WriteLine("---> " + s1);
                s1 = 0;
            }

            Console.WriteLine();
            for (int i = 0; i < n; i++)
            {
                if (min > sum[i])
                {
                    ii = i;
                    min = sum[i];
                }
            }

            for (int i = 0; i < n; i++)
            {
                if (max < sum[i])
                {
                    ii2 = i;
                    max = sum[i];
                }
            }

            for (int j = 0; j < n; j++)
            {
                c = mass[ii][j];
                mass[ii][j] = mass[ii2][j];
                mass[ii2][j] = c;
            }

            Console.WriteLine("[" + (ii + 1) + "]" + " Min --> " + min);
            Console.WriteLine("[" + (ii2 + 1) + "]" + " Max --> " + max);
            Console.WriteLine();


            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(mass[i][j].ToString() + " ");
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}