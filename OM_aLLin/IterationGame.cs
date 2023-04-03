using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    class IterationGame
    {
        Matrix mtrx;
        int iterations;
        int[] chanceA;
        int[] chanceB;
        const int outWidth = 6;

        public struct iteration
        {
            public int i; // the number of iteration at current line of table
            public int A_CurrentStrategy; // indeces of A1, A2 ... An
            public int B_CurrentStrategy; // the same as A , but for B
            public int[] A_win; // the winn price for all A strategys
            public int[] B_win;
            public double a_price;
            public double b_price;
            public double nu; // (a + b) /2 

            public int[] chanceA;
            public int[] chanceB;

            public string getLabel()
            {
                StringBuilder sb = new StringBuilder("");
                sb.Append(String.Format("{0,10} |", "StrgyA"));
                for (int num = 0; num < A_win.Length; num++)
                    sb.Append(String.Format("{0,10} |", $"A{num + 1}"));
                sb.Append(String.Format("{0,10} |", "StrgyB"));
                for (int num = 0; num < B_win.Length; num++)
                    sb.Append(String.Format("{0,10} |", $"B{num + 1}"));
                sb.Append(String.Format("{0,10} |", "a"));
                sb.Append(String.Format("{0,10} |", "b"));
                sb.Append(String.Format("{0,10}\n", "nu"));
                return (sb.ToString());
            }
            public string getInfo()
            {
                StringBuilder sb = new StringBuilder("");
                sb.Append(String.Format("{0,10} |", A_CurrentStrategy + 1));
                foreach (int num in A_win)
                    sb.Append(String.Format("{0,10} |", num));
                sb.Append(String.Format("{0,10} |", B_CurrentStrategy + 1));
                foreach (int num in B_win)
                    sb.Append(String.Format("{0,10} |", num));
                sb.Append(String.Format("{0,10:f2} |", a_price));
                sb.Append(String.Format("{0,10:f2} |", b_price));
                sb.Append(String.Format("{0,10:f4}\n", a_price));
                return (sb.ToString());
            }

            public string getChances()
            {
                StringBuilder sb = new StringBuilder("");
                sb.Append(String.Format("A chances:\n"));
                foreach (int num in chanceA)
                    sb.Append(String.Format("{0,10:f4} |", (double)num/(double) i));
                sb.Append(String.Format("\nB chances:\n"));
                foreach (int num in chanceB)
                    sb.Append(String.Format("{0,10:f4} |", (double)num / (double)i));
                return sb.ToString();
            }
        }

        public void NextStep(ref iteration iter)
        {
            int currMin, currMax;
            iter.A_CurrentStrategy = indexOfMax(iter.B_win, out currMax);
            sumArray(ref iter.A_win, mtrx.getStroke(iter.A_CurrentStrategy));
            iter.B_CurrentStrategy = indexOfMin(iter.A_win, out currMin);
            sumArray(ref iter.B_win, mtrx.getColumn(iter.B_CurrentStrategy));

            iter.i++;
            iter.a_price = currMin / (double)iter.i;
            iter.b_price = currMax / (double)iter.i;
            iter.nu = (iter.a_price + iter.b_price) / 2.0;

            chanceA[iter.A_CurrentStrategy]++;
            chanceB[iter.B_CurrentStrategy]++;
        }
        

        private iteration loadIteration()
        {
            int currMin, currMax;
            iteration iter = new iteration();
            iter.i = 1;
            iter.A_CurrentStrategy = 0;
            //iter.B_CurrentStrategy = 0;
            iter.A_win = mtrx.getColumn(0);
            iter.B_CurrentStrategy = indexOfMin(iter.A_win, out currMin);
            iter.B_win = mtrx.getStroke(iter.B_CurrentStrategy);
            indexOfMax(iter.B_win, out currMax);
            iter.a_price = (double)currMin;
            iter.b_price = (double)currMax;
            iter.nu = (iter.a_price + iter.b_price) / 2.0;

            chanceA[iter.A_CurrentStrategy]++;
            chanceB[iter.B_CurrentStrategy]++;
            iter.chanceA = chanceA;
            iter.chanceB = chanceB;

            return iter;
        }

        private void sumArray(ref int[] left, int[] right)
        {
            for (int i = 0; i < left.Length; i++)
                left[i] += right[i];
        }
        private int indexOfMin(int[] input, out int minimum)
        {
            int result = 0;
            int min = input[0];
            for(int i = 0; i < input.Length; i++)
                if(input[i] < min)
                {
                    min = input[i];
                    result = i;
                }
            minimum = min;
            return result;
        }

        private int indexOfMax(int[] input, out int maximum)
        {
            int result = 0;
            int max = input[0];
            for (int i = 0; i < input.Length; i++)
                if (input[i] > max)
                {
                    max = input[i];
                    result = i;
                }
            maximum = max;
            return result;
        }

        public IterationGame(Matrix mtrx, int iterations)
        {
            this.mtrx = mtrx;
            this.iterations = iterations;
            chanceA = new int[mtrx.strokes];
            chanceB = new int[mtrx.columns];
            chanceA = SetZero(chanceA);
            chanceB = SetZero(chanceB);
        }

        private int[] SetZero(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
                input[i] = 0;
            return input;
        }

        

        public List<string> Calculate(out string chances)
        {
            string resChances = "";
            List<string> resTablePages = new List<string>();
            StringBuilder sb = new StringBuilder();
            iteration iter = loadIteration();
            sb.Append(iter.getLabel());
            
            for(int i = 0; i < iterations; i++)
            {
                sb.Append(iter.getInfo());
                NextStep(ref iter);
                if(i != 0 && i % 10 == 0)
                {
                    resTablePages.Add(sb.ToString());
                    sb = new StringBuilder("");
                }
            }


            chances = iter.getChances();
            return resTablePages;
        }

    }
}
