using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    class Floyd
    {
        public Matrix mtrx = new Matrix();
        public int NoEdge = (int.MaxValue / 2) -1;


        private string arrToString(int[,] matrix)
        {

            StringBuilder sb = new StringBuilder("");
            for(int i = 0; i < matrix.GetLength(0); i++)
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

        public List<string> FloydWarshall(int[,] graph)
        {
            List<string> result = new List<string>();
            int verticesCount = graph.GetLength(0);
            int[,] distance = new int[verticesCount, verticesCount];

            for (int i = 0; i < verticesCount; ++i)
                for (int j = 0; j < verticesCount; ++j)
                    distance[i, j] = graph[i, j];

            for (int k = 0; k < verticesCount; ++k)
            {
                for (int i = 0; i < verticesCount; ++i)
                {
                    for (int j = 0; j < verticesCount; ++j)
                    {
                        if (distance[i, k] + distance[k, j] < distance[i, j])
                            distance[i, j] = distance[i, k] + distance[k, j];
                        if(result.Count == 0)
                            result.Add(arrToString(distance));
                        else if(result[result.Count - 1] != arrToString(distance))
                            result.Add(arrToString(distance));
                    }
                }
            }

            return result;
        }


    }
}
