using System;

namespace module1
{
    class Program
    {
        static void Main(string[] args)
        {
            Matrix matrix = new Matrix();
            matrix.FillMatrixRandom(3,5,0,8);
        }
    }

    class Matrix
    {
        int[][] matrix;

        public void FillMatrixRandom(int rows, int columns, int min, int max)
        {
            var random = new Random();
            matrix = new int[rows][columns];

            for (int i = 0; i < rows; ++i)
            {
                for (int j = 0; j < columns; ++j)
                {
                    matrix[i][j] = random.Next(min, max);
                }
            }
        }
        
        public int this[int r, int c]
        {
            get { return matrix[r, c]; }
        }
    }
}
