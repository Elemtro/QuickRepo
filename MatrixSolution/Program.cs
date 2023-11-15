using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSolution
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = "C:\\Projects\\MatrixSolution\\Files\\matrix.txt";
            Matrix matrix = new Matrix(path);
            foreach (var meow in matrix.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine(matrix.Rows);
            Console.WriteLine(matrix.Columns);
            matrix.Transpose();
            foreach (var meow in matrix.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }

        }
    }
}
