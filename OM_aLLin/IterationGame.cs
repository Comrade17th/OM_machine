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

        public void Calculate(out string chances, out List<string> TablePages)
        {
            string resChances;
            List<string> res = new List<string>();


        }

    }
}
