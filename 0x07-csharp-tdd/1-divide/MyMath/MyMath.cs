using System;

namespace MyMath
{
    /// <summary>Represents a numeric matrix.</summary>
    public class Matrix
    {
        /// <summary>Divides all numbers inside of a matrix.</summary>
        /// <param name="matrix">A matrix of integers.</param>
        /// <param name="num">The number to divide the matrix by.</param>
        /// <returns>A new matrix containing the divided elements.</returns>
        public static int[,] Divide(int[,] matrix, int num)
        {
            int[,] result = new int[
                matrix.GetLength(0), 
                matrix.GetLength(1)];
            
            if (matrix == null)
            {
                return null;
            }

            try
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    for (int j = 0; j < matrix.GetLength(1); j++)
                    {
                        result[i, j] = matrix[i, j] / num;
                    }
                }
            }

            catch (DivideByZeroException)
            {
                Console.WriteLine("Num cannot be 0");
                return null;
            }

            return (result);
        }
    }
}
