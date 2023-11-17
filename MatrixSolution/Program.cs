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
            //getting matrix from a file
            string path = "C:\\Projects\\MatrixSolution2\\Files\\matrix1.txt"; 
            Matrix matrix1 = new Matrix(path); //getting matrix1 from a file
            Console.WriteLine("First matrix:");
            foreach (var meow in matrix1.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Trasposing matrix1
            matrix1.Transpose();
            Console.WriteLine("Trasposing matrix 1:");
            foreach (var meow in matrix1.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }

            //getting matrix2 from a file
            string path2 = "C:\\Projects\\MatrixSolution2\\Files\\matrix2.txt";
            Matrix matrix2 = new Matrix(path2);
            Console.WriteLine();
            Console.WriteLine("Second matrix:");
            foreach (var meow in matrix2.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //Adding two matrices
            Matrix summ = matrix1 + matrix2;
            Console.WriteLine("Adding matrix 1 (after traspose) and matrix 2:");
            foreach (var meow in summ.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //getting matrix 1 to multiply from file
            Matrix matr_multpl1 = new Matrix("C:\\Projects\\MatrixSolution2\\Files\\matrix_test1.txt");
            Console.WriteLine("Getting matrix1 to multiply: ");
            foreach (var meow in matr_multpl1.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //getting matrix 2 to multiply from file
            Matrix matr_multpl2 = new Matrix("C:\\Projects\\MatrixSolution2\\Files\\matrix_test2.txt");
            Console.WriteLine("Getting matrix2 to multiply: ");
            foreach (var meow in matr_multpl2.Values)
            {
                foreach (var v in meow)
                {
                    Console.Write(v + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            //multiplying
            Console.WriteLine("Multiplying matrix1 * matrix2:");
            Matrix last = matr_multpl1 * matr_multpl2;
            foreach (var meow in last.Values)
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
