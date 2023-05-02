using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    internal class TileRectangle
    {

        Tile mainTile;
        Tile support;
        // follow vector
        /// <summary>
        /// left -1 <---> 1 right
        /// </summary>
        int hor = 1;

        /// <summary>
        ///  // up -1 <---> 1 down
        /// </summary>
        int vert = 1;

        /// <summary>
        /// mt - main tile
        /// 
        /// on the corner are support tiles
        /// 
        ///   2           1 
        ///     NW, N, NE
        ///     W, mt, E
        ///     WS, S, SE = null;
        ///   3           0  
        /// </summary>
        int stage = 0; 

        int n; // strokes
        int m; // columns
        public TileRectangle()
        {

        }

        public TileRectangle(Tile mainTile)
        {
            mainTile = mainTile;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="mainTile">The tile that must be in rectangle</param>
        /// <param name="n"></param>
        /// <param name="m"></param>
        public TileRectangle(Tile mainTile, int n, int m)
        {
            this.mainTile = mainTile;
            this.n = n;
            this.m = m;
        }

        /// <summary>
        /// initialize the position of support tiles
        /// depends on stage
        /// </summary>
        private void initSupport()
        {
            if (stage == 0)
                support = new Tile(mainTile.n + 1, mainTile.m + 1);
            if (stage == 1)
                support = new Tile(mainTile.n - 1, mainTile.m + 1);
            if (stage == 2)
                support = new Tile(mainTile.n - 1, mainTile.m - 1);
            if (stage == 3)
                support = new Tile(mainTile.n + 1, mainTile.m - 1);
        }

        private void buildRectangle()
        {

        }

        /// <summary>
        /// going to next stage
        /// and moving the vector where to move
        /// </summary>
        private void nextStage()
        {
            stage++;
            if (stage == 1)
                vert = -1;
            if (stage == 2)
                hor = -1;
            if (stage == 3)
                vert = 1;

        }

        private void CalcTest()
        {
            while (stage <= 3)
            {
                initSupport();
                if (support.isOutBorder(n, m))
                {
                    nextStage();
                }
                else
                {

                }


            }
        }

    }
}
