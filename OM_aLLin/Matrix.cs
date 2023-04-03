using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    class Matrix
    {
        public int[,] matrix;
        public int strokes; // i, n
        public int columns; // j, m
        public Matrix()
        {
            matrix = null;
            strokes = 0;
            columns = 0;
        }

        public Matrix(string input = "")
        {
            matrix = richToList(input, out strokes, out columns);
            strokes = matrix.GetLength(1);
            columns = matrix.GetLength(2);
        }

        public Matrix(int [,] input)
        {
            matrix = input;
            strokes = input.GetLength(0);
            columns = input.GetLength(1);
        }

        private int[,] richToList(string input, out int strokes, out int columns)
        {
            if (input[input.Length - 1] != '\n')
                input += '\n';
            string[] temp = input.Split('\n');
            strokes = temp.Length;
            columns = 0;
            List<List<int>> tmp = new List<List<int>>();
            for(int i = 0; i < temp.Length; i++)
            {
                string[] stroke_nums = temp[i].Split();
                columns = Math.Max(stroke_nums.Length, columns);
                tmp.Add(new List<int>());
                foreach(string num in stroke_nums)
                {
                    try
                    {
                        tmp[i].Add(Convert.ToInt32(num));
                    }
                    catch {}
                }
            }


            int n = temp.Length;
            int m = temp[0].Length;
            int[,] result = new int[temp.Length, temp[0].Length];
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < m; j++)
                {
                    result[i, j] = temp[i][j];
                }
            }
            return result;
        }
    }
}
