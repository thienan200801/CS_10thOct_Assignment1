using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    class MyMatrix
    {
        private int len;
        private int[,] A;
        public MyMatrix(int l = 0)
        {
            this.len = l;
            A = new int[len, len];
            Random rand = new Random();
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    A[i, j] = rand.Next(10);
                }
            }
            for (int i = 0; i < len; i++)
            {
                for (int j = 0; j < len; j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

    }
}
