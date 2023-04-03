using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{

    
    class InputMaker
    {
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
                    result[i, j] = int.Parse(nums[j]);
                }
            }
            return result;
        }
    }
}
