using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using tyuiu.cources.programming.interfaces.Sprint4;

namespace Tyuiu.HodakovaNA.Sprint4.Task6.V10.Lib
{
    public class DataService : ISprint4Task6V10
    {
        public string[] Calculate(string[] array)
        {
            string[] num = Array.FindAll(array, x => x.Length < 7);
            return num;
        }
    }
}
