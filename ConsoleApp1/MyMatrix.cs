using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MyMatrix
    {
        private int len;
        private int[,] Arr;
        public MyMatrix(int l = 0)
        {
            this.len = l;
            Arr = new int[len, len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Arr[i, j] = rand.Next(10);
                }
            }
        }
        public void Print()
        {
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(Arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public string MyToString()
        {
            // result.Print();
            string s = "";
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    s += this.Arr[i, j] + " ";
                }
                s += "\n";
            }
            return s;
        }

        public MyMatrix Add(MyMatrix B)
        {
            MyMatrix Sum = new MyMatrix(this.len);
            for (int i = 0; i < this.len; i++)
            {
                for (int j = 0; j < this.len; j++)
                {
                    Sum.Arr[i, j] += Arr[i, j] + B.Arr[i, j];
                }
            }
            Console.WriteLine("S = ");
            Sum.Print();
            return Sum;
        }

        public MyMatrix Multiply(MyMatrix B)
        {
            MyMatrix result = new MyMatrix(this.len);
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    result.Arr[i, j] = 0;
                    for (int k = 0; k < len; k++)
                    {
                        result.Arr[i, j] += Arr[i, k] * B.Arr[k, j];
                    }
                }
            }

            return result;
        }
    }
}
