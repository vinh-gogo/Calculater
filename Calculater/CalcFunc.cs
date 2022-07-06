using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    public class CalcFunc
    {
        private Validation val { get; set; }
        public CalcFunc()
        {
            val = new Validation();
        }
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
        public bool isCanSum(string str)
        {

            if (val.isNumber(str))
                return true;
            return false;
        }
        //public int Sum(String str)
        //{
        //    if (isCanSum(str))
        //    {
        //        return 1;
        //    }
        //    return -1;
        //}

        public int calcAll(string str)
        {
            for (int i = 0; i < str.Length; i++)
            {
                int j = i + 1;
               

                        
            }

            return -1;
        }

    }
}
