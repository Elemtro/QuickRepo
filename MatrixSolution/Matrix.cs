using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Versioning;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace MatrixSolution
{
    internal class Matrix
    {
        public List<List<double>> Values { get; set; } = new List<List<double>>();
        public int Rows { get; set; }
        public int Columns { get; set; }
        public Matrix(string path)
        {
            try
            {
                StreamReader reader = new StreamReader(path);
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    List<double> row = new List<double>();
                    line = line.Trim();
                    for (int i = 0; i < line.Length; i++)
                    {
                        if (line[i] == ';')
                        {
                            row.Add(double.Parse(line.Remove(i)));
                            line = line.Substring(i + 1);
                            i = 0;
                        }
                    }
                    Values.Add(row);
                    Columns = row.Count;
                }
                reader.Close();
                Rows = Values.Count;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Oops, you've got an error reading data from file: " + ex.Message);
            }
        }
        public Matrix() { }
        public void Transpose()
        {
            Matrix newOne = new Matrix();
            for (int i = 0; i < Columns; i++) 
            {
                List<double> hehe = new List<double>();
                for (int j = 0; j < Rows; j++)
                {
                    hehe.Add(Values[j][i]);
                }
                newOne.Values.Add(hehe);
            }
            Values = newOne.Values;
        }
        public static Matrix operator +(Matrix a, Matrix b)
        {
            Matrix result = new Matrix();
            if (a.Rows != b.Rows || a.Columns != b.Columns)
            {
                Console.WriteLine("ERROR! Matrixes should have same size (Rows and Columns)");
                return new Matrix();
            }
            else
            {
                for (int i = 0; i < a.Rows; i++)
                {
                    List<double> val = new List<double>();
                    for (int j = 0; j < a.Columns; j++)
                    {
                        double meow = a.Values[i][j] + b.Values[i][j];
                        val.Add(meow);
                    }
                    result.Values.Add(val);
                }
            }
            return result;
        }
        public static Matrix operator *(Matrix a, Matrix b)
        {
            if (a.Columns != b.Rows)
            {
                Console.WriteLine("ERROR! Matrixes can't be multiplicated!");
                return new Matrix();
            }
            else
            {
                Matrix result = new Matrix();
                for (int l = 0; l < a.Rows; l++)
                {
                    List<double> values = new List<double>();
                    for (int i = 0; i <  b.Columns; i++)
                    {
                        double number = 0;
                        for (int j = 0; j < a.Columns; j++)
                        {
                            number += a.Values[l][j] * b.Values[j][i];
                        }
                        values.Add(number);
                    }
                    result.Values.Add(values);
                }
                return result;
            }
        }
    }
}
