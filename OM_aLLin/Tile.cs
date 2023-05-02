using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    internal class Tile
    {
        public int n;
        public int m;
        public Tile()
        {

        }
        public Tile(int n, int m)
        {
            this.n = n;
            this.m = m;
        }

        override public string ToString()
        {
            return String.Format($"({n};{m})");
        }

        /// <summary>
        /// checks is the tile get out of border
        /// return true, if it out of the field
        /// </summary>
        /// <param name="n_border">the stroke length of field</param>
        /// <param name="m_border">the column length of field</param>
        /// <returns></returns>
        public bool isOutBorder(int n_border, int m_border)
        {
            bool isOutBorder = false;

            if(n < 0 || n >= n_border)
                isOutBorder = true;
            if (m < 0 || m >= m_border)
                isOutBorder = true;

            return isOutBorder;
        }
    }
}
