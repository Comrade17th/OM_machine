using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{

    
    class InputMaker
    {
        static int INF = (int)1e7;
        public static int[,] StringToArr(string input)
        {
            string[] lines = input.Split('\n');
            string[] numsAtLine = lines[0].Split(' ');
            int[,] result = new int[lines.Count(), numsAtLine.Count()];
            for(int i = 0; i < lines.Count(); i++)
            {
                string[] nums = lines[i].Split(' ');
                for(int j = 0; j < numsAtLine.Count(); j++)
                {
                    if (nums[j] == "i")
                        result[i, j] = INF;
                    else
                        result[i, j] = int.Parse(nums[j]);
                }
            }
            return result;
        }

        public static string arrToString(int[,] matrix)
        {

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (j != 0)
                        sb.Append(" ");
                    if (matrix[i, j] > 9999)
                        sb.Append("i");
                    else
                        sb.Append(matrix[i, j]);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }

        public static string arrToString(int[,] matrix, int v)
        {

            StringBuilder sb = new StringBuilder("");
            for (int i = 0; i < v; i++)
            {
                for (int j = 0; j < v; j++)
                {
                    if (j != 0)
                        sb.Append(" ");
                    if (matrix[i, j] > 9999)
                        sb.Append("i");
                    else
                        sb.Append(matrix[i, j]);
                }
                sb.Append("\n");
            }
            return sb.ToString();
        }
    }
}
