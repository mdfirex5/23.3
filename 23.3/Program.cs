using System;
using System.Collections.Generic;

namespace _23._3
{
    internal class Matrix
    {
        protected List<List<byte>> mass;
        protected int size = 4;
        public Matrix(int size = 4)
        {
            this.mass = new List<List<byte>>();
            List<byte> row = new List<byte>();
            List<int> sum = new List<int>();
            this.size = size;

            Random rand = new Random();

            for (int i = 0; i < this.size; i++)
            {
                row = new List<byte>();
                for (int j = 0; j < this.size; j++) row.Add((byte)rand.Next(10));
                mass.Add(row);
            }
        }

        public List<List<byte>> getMatrix()
        {
            return this.mass;
        }

        public void printMatrix()
        {
            Console.Write("\t");
            for (int i = 0; i < this.size; i++)
            {
                Console.Write("[" + (i + 1) + "]\t");
            }
            Console.WriteLine();
            for (int i = 0; i < this.size; i++)
            {
                Console.Write("[" + (i + 1) + "]\t");

                for (int j = 0; j < this.size; j++)
                {
                    Console.Write(mass[i][j].ToString() + "\t");
                }
                Console.WriteLine();
            }
        }
    }

    internal class Replace : Matrix
    {
        public Replace()
            : base()
        {
        }

        public int[,] SearchValue()
        {
            Console.WriteLine();
            List<int> sum = new List<int>();
            int min = 99 ^ 9;
            int max = -99 ^ 9;
            int ii = 0;
            int ii2 = 0;
            int s1 = 0;
            Console.Write("\t");
            for (int i = 0; i < this.size; i++)
            {
                Console.Write("[" + (i + 1) + "]\t");
            }
            Console.WriteLine();

            for (int i = 0; i < this.size; i++)
            {
                Console.Write("[" + (i + 1) + "]\t");
                for (int j = 0; j < this.size; j++)
                {
                    s1 = s1 + this.mass[i][j];
                    Console.Write(this.mass[i][j].ToString() + "\t");
                }
                sum.Add(s1);
                Console.WriteLine("---> " + s1);
                s1 = 0;
            }
            for (int i = 0; i < this.size; i++)
            {
                if (min > sum[i])
                {
                    ii = i;
                    min = sum[i];
                }
            }
            for (int i = 0; i < this.size; i++)
            {
                if (max < sum[i])
                {
                    ii2 = i;
                    max = sum[i];
                }
            }
            Console.WriteLine("\n[" + (ii + 1) + "]" + " Min --> " + min);
            Console.WriteLine("[" + (ii2 + 1) + "]" + " Max --> " + max);
            return new int[,] { { ii, min }, { ii2, max } };
        }

        public void replaceLine(int a, int b)
        {
            Console.WriteLine();
            byte c = 0;
            for (int j = 0; j < this.size; j++)
            {
                c = this.mass[a][j];
                this.mass[a][j] = this.mass[b][j];
                this.mass[b][j] = c;
            }
        }
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            Replace a = new Replace();
            a.printMatrix();
            int[,] m = a.SearchValue();
            a.replaceLine(m[0, 0], m[1, 0]);
            a.printMatrix();

            /* List<List<byte>> mass = new List<List<byte>>();
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

             Console.ReadLine();*/
        }
    }
}