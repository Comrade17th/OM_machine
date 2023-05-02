using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
	// C# program to find the shortest
	// path between any two nodes using
	// Floyd Warshall Algorithm.
	class GFG
	{

		static readonly int MAXN = 100;

		// Infinite value for array
		static int INF = (int)1e7;

		static int[,] dis = new int[MAXN, MAXN];
		static int[,] Next = new int[MAXN, MAXN];

		// Initializing the distance and
		// Next array
		static void initialise(int V,
							int[,] graph)
		{
			for (int i = 0; i < V; i++)
			{
				for (int j = 0; j < V; j++)
				{
					dis[i, j] = graph[i, j];

					// No edge between node
					// i and j
					if (graph[i, j] == INF)
						Next[i, j] = -1;
					else
						Next[i, j] = j;
				}
			}
		}

		// Function construct the shortest
		// path between u and v
		static List<int> constructPath(int u, int v)
		{

			// If there's no path between
			// node u and v, simply return
			// an empty array
			if (Next[u, v] == -1)
				return null;

			// Storing the path in a vector
			List<int> path = new List<int>();
			path.Add(u);

			while (u != v)
			{
				u = Next[u, v];
				path.Add(u);
			}
			return path;
		}

		// Standard Floyd Warshall Algorithm
		// with little modification Now if we find
		// that dis[i,j] > dis[i,k] + dis[k,j]
		// then we modify next[i,j] = next[i,k]
		static void floydWarshall(int V)
		{
			for (int k = 0; k < V; k++)
			{
				for (int i = 0; i < V; i++)
				{
					for (int j = 0; j < V; j++)
					{

						// We cannot travel through
						// edge that doesn't exist
						if (dis[i, k] == INF ||
							dis[k, j] == INF)
							continue;

						if (dis[i, j] > dis[i, k] +
										dis[k, j])
						{
							dis[i, j] = dis[i, k] +
										dis[k, j];
							Next[i, j] = Next[i, k];
						}
					}
				}
			}
		}

		// Print the shortest path
		static void printPath(List<int> path)
		{
			int n = path.Count;

			for (int i = 0; i < n - 1; i++)
				Console.Write(path[i] + " -> ");

			Console.Write(path[n - 1] + "\n");
		}

		// Driver code
		public static void Main(String[] args)
		{
			int V = 4;
			int[,] graph = { { 0, 3, INF, 7 },
					{ 8, 0, 2, INF },
					{ 5, INF, 0, 1 },
					{ 2, INF, INF, 0 } };

			// Function to initialise the
			// distance and Next array
			initialise(V, graph);

			// Calling Floyd Warshall Algorithm,
			// this will update the shortest
			// distance as well as Next array
			floydWarshall(V);
			List<int> path;

			// Path from node 1 to 3
			Console.Write("Shortest path from 1 to 3: ");
			path = constructPath(1, 3);
			printPath(path);

			// Path from node 0 to 2
			Console.Write("Shortest path from 0 to 2: ");
			path = constructPath(0, 2);
			printPath(path);

			// Path from node 3 to 2
			Console.Write("Shortest path from 3 to 2: ");
			path = constructPath(3, 2);
			printPath(path);
		}
	}

	// This code is contributed by Amit Katiyar

}

