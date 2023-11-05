using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HodakovaNA.Sprint4.Task2.V13.Lib
{
    public class DataService : ISprint4Task2V13
    {
        public int Calculate(int[] numsArray)
        {
            int x = 1;
            for (int i = 0; i < numsArray.Length; i++)
            {
                if (numsArray[i] % 2 == 0)
                    x *= numsArray[i];
            }
            return x;
        }
    }
}
