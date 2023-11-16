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
            string path = "C:\\Users\\alykhvar\\Source\\Repos\\QuickRepo\\Files\\matrix.txt";
            Matrix matrix = new Matrix(path);
            foreach (var meow in matrix.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            matrix.Transpose();
            foreach (var meow in matrix.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }

            string path2 = "C:\\Users\\alykhvar\\Source\\Repos\\QuickRepo\\Files\\matrix2.txt";
            Matrix matrix2 = new Matrix(path2);
            Matrix summ = matrix + matrix2;
            Console.WriteLine();
            foreach (var meow in summ.Values)
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
