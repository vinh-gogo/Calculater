using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    public class CalcFunc
    {
        public int Sum(int value1, int value2)
        {
            return value1 + value2;
        }
        public int Subtrac(int value1, int value2)
        {
            return value1 - value2;
        }
        public int Multi(int value1, int value2)
        {
            return value1 * value2;
        }
        public int divis(int value1, int value2)
        {
            return value1 / value2;
        }
        public void Resuft(int aa)
        {
            Console.WriteLine(aa);
        }
        public int Sum(List<int> Values)
        {
            var resuft = 0;
            foreach (int i in Values)
            {
                resuft += i;
            }
            return resuft;
        }

        public int Sum(String str)
        {
        //  Xu ly dieu kien
            return -1;
        }
    }
}
