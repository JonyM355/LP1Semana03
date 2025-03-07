using System;

namespace ArrayMul
{
    public class Program
    {
        private static void Main(string[] args)
        {
            // Matrix 1
            float[,] matrix1 = new float[2, 2]
            {
                // Convert string args to floats
                { float.Parse(args[0]), float.Parse(args[1])},
                { float.Parse(args[2]), float.Parse(args[3])}
            };

            //Matrix 2
            float[,] matrix2 = new float[2, 1]
            {
                { float.Parse(args[4])},
                { float.Parse(args[5])}
            };

            //Mul Matrix
            float[,] n_matrix = new float[2, 1];

            //Multiplication
            for (int i = 0; i < 2; i++)
            {
                n_matrix[i, 0] = matrix1[i, 0] * matrix2[0, 0] +
                                matrix1[i, 1] * matrix2[1, 0];
            }

            //Show the Mul Matrix
            for (int i = 0; 1 < 2; i++)
            {
                Console.WriteLine($"| {n_matrix[i, 0],7:f2} |");
            }
        }
    }
}
