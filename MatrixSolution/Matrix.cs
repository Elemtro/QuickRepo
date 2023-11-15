using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
    }
}
