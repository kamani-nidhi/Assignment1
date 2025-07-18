using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    public class generic_2d<T>
    {
        public void Add(T[,] a, T[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            // Initialize ans as a 2D array of type T
            T[,] ans = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dynamic x = a[i, j];
                    dynamic y = b[i, j];
                    ans[i, j] = (T)(x + y);

                }

            }


            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine();

            }
        }


        public void sub(T[,] a, T[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            // Initialize ans as a 2D array of type T
            T[,] ans = new T[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    dynamic x = a[i, j];
                    dynamic y = b[i, j];
                    ans[i, j] = (T)(x - y);

                }

            }


            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine();

            }
        }


        public void mul(T[,] a, T[,] b)
        {
            int rows = a.GetLength(0);
            int cols = a.GetLength(1);

            // Initialize ans as a 2D array of type T
            T[,] ans = new T[rows, cols];

            //for (int i = 0; i < rows; i++)
            //{
            //    for (int j = 0; j < cols; j++)
            //    {
            //        dynamic x = a[i, j];
            //        dynamic y = b[i, j];
            //        ans[i, j] = ;

            //    }

            //}

            //ans[1, 1] = (T)(a[1, 1] * b[1, 1]);


            for (int i = 0; i < cols; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.Write(ans[i, j] + " ");
                }
                Console.WriteLine();

            }
        }
    }
}
