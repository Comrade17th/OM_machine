using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OM_aLLin
{
    internal class TrafficOptimization
    {
        int[,] priceMap;
        int[,] trafficMap;
        int[] storage; // n, srtokes
        int[] needs; // m, columns

        // для n строки
        //Console.WriteLine(arr.GetLength(0));
        // для m столбцы
        //Console.WriteLine(arr.GetLength(1));

        public TrafficOptimization()
        {

        }


        // initialize rightly the whole quest
        public TrafficOptimization(int[,] priceMap, int[] storage, int[] needs)
        {
            // check is the question is closed
            // are needs and storage equel
            int check = CheckClose(storage, needs);
            int[,] tmpPriceMap;
            int[] tmpStorage;
            int[] tmpNeeds;
            if (check == 0)
            {
                tmpStorage = storage;
                tmpNeeds = needs;
                //tmpPriceMap = priceMap;
            }
            else if(check < 0) // needs > storage, have to add storage
            {
                CopyPlusOne(storage, check,out tmpStorage);
                tmpNeeds = needs;
            }
            else // storage > needs, have to add needs
            {
                CopyPlusOne(needs, check, out tmpNeeds);
                tmpStorage = storage;
            }

            CreateMaps(priceMap, tmpStorage, tmpNeeds, out this.priceMap, out this.trafficMap);
            this.storage = tmpStorage;
            this.needs = tmpNeeds;
        }

        private void CreateMaps(int[,] priceMap, int[] storage, int[] needs, out int[,]tmpMap, out int[,] tmpTrafficMap)
        {
            // resizing to new sizes main arrays
            tmpMap = new int[storage.Length,needs.Length];
            tmpTrafficMap = new int[storage.Length, needs.Length];
            // setting to zero all values
            for(int i = 0; i < tmpMap.GetLength(0); i++)
            {
                for(int j = 0; j < tmpMap.GetLength(1); j++)
                {
                    tmpMap[i, j] = 0;
                    tmpTrafficMap[i, j] = 0;
                }
            }

            // copying from main price map, to out new
            for(int i =0; i < priceMap.GetLength(0); i++)
            {
                for(int j = 0; j < priceMap.GetLength(1); j++)
                {
                    tmpMap[i, j] = priceMap[i, j];
                }
            }
        }

        private void CopyPlusOne(int[] from, int check,out int[] to)
        {
            to = new int[from.Length + 1];
            for(int i = 0; i < from.Length; i++)
            {
                to[i] = from[i];
            }
            to[to.Length - 1] = Math.Abs(check);
        }

        private int CheckClose(int[] storage, int[] needs)
        {
            return storage.Sum() - needs.Sum();
        }

        public string GetInfo()
        {
            string result = "";
            result += GetPriceMap();
            result += GetTrafficMap();
            result += $"Sum = {GetFunctionSumm()}\n";
            return result;
        }

        private string GetPriceMap()
        {
            string result = "";
            result += "Price info\n";
            for (int i = 0; i < priceMap.GetLength(0); i++)
            {
                for (int j = 0; j < priceMap.GetLength(1); j++)
                {
                    result += $"{priceMap[i, j]}\t";
                }
                result += $"{this.storage[i]}\n";
            }
            for (int i = 0; i < needs.Length; i++)
                result += $"{needs[i]}\t";
            result += "\n";
            return result;
        }

        private string GetTrafficMap()
        {
            string result = "";
            result += "Traffic info\n";
            for (int i = 0; i < trafficMap.GetLength(0); i++)
            {
                for (int j = 0; j < trafficMap.GetLength(1); j++)
                {
                    result += $"{trafficMap[i, j]}\t";
                }
                result += $"{this.storage[i]}\n";
            }
            for (int i = 0; i < needs.Length; i++)
                result += $"{needs[i]}\t";
            result += "\n";
            return result;
        }

        public void NordWestMethod(out List<string> listStats)
        {
            listStats = new List<string>();
            int n = trafficMap.GetLength(0), m = trafficMap.GetLength(1);
            int[] a = new int[storage.Length];
            int[] b = new int[needs.Length];
            CopyArray(storage, out a);
            CopyArray(needs, out b);
            int i = 0; // n
            int j = 0; // m
            while(i < n && j < m)
            {
                listStats.Add(GetInfo());
                try
                {
                    if (a[i] == 0) { i++; }
                    if (b[j] == 0) { j++; }
                    if (a[i] == 0 && b[j] == 0) { i++; j++; }
                    trafficMap[i, j] = FindMinElement(a[i], b[j]);
                    a[i] -= trafficMap[i, j];
                    b[j] -= trafficMap[i, j];
                }
                catch { }
            }
        }

        private void CopyArray(int[] from, out int[] to)
        {
            to = new int[from.Length];
            for (int i = 0; i < from.Length; i++)
                to[i] = from[i];
        }

        public static int FindMinElement(int a, int b)
        {
            if (a > b) return b;
            if (a == b) { return a; }
            else return a;
        }

        private bool StrokeOK(int i)
        {
            if (StrokeSumm(i) == storage[i])
                return true;
            else
                return false;
        }

        private bool ColumnOK(int j)
        {
            if (ColumnSumm(j) == needs[j])
                return true;
            else
                return false;
        }
        private int ColumnSumm(int j)
        {
            int sum = 0;
            for (int i = 0; i < trafficMap.GetLength(0); i++)
            {
                sum += trafficMap[i, j];
            }
            return sum;
        }

        private int StrokeSumm(int i)
        {
            int sum = 0;
            for (int j = 0; j < trafficMap.GetLength(1); j++)
            {
                sum += trafficMap[i, j];
            }
            return sum;
        }

        private int GetFunctionSumm()
        {
            int sum = 0;
            for (int i = 0; i < trafficMap.GetLength(0) && i < priceMap.GetLength(0); i++)
                for (int j = 0; i < trafficMap.GetLength(1) && j < priceMap.GetLength(1); j++)
                    sum += trafficMap[i, j] * priceMap[i, j];
            return sum;
        }

    }
}
