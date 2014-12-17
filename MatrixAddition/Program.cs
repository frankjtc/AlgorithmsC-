using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixAddition
{
    class Matrix:IMatrixDef
    {
        public int[,] EnterMatrix(int rows, int cols, string msg)
        {
            int[,] matrix = new int[rows, cols];

            Console.WriteLine("Enter {0} =>", msg);
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < rows; j++)
                {
                    Console.WriteLine("Enter element at {0}, {1}:", i, j);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            return matrix;
        }

        public void AddMatrix(int rows, int cols, int[,] aMatrix, int[,] bMatrix)
        {
         int [,] cMatrix=new int[rows,cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    cMatrix[i, j] = aMatrix[i, j] + bMatrix[i, j];
                    Console.Write(cMatrix[i, j] + "\t");
                }

                Console.WriteLine("\n");
            }

        }

        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            Console.WriteLine("NUmber of rows:");
            int rows = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Number of Cols:");
            int cols = Convert.ToInt32(Console.ReadLine());
            int[,] aMatrix = matrix.EnterMatrix(rows, cols, "aMatrix");
            int[,] bMatrix = matrix.EnterMatrix(rows, cols, "bMatrix");
             matrix.AddMatrix(rows, cols, aMatrix, bMatrix);
            Console.ReadLine();

        }
    }
}
