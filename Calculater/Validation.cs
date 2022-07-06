using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculater
{
    public class Validation
    {
        public bool isNumber(string str)
        {
            if (str == null)
                return false;
            else if (int.TryParse(str, out int resuft))
                return true;
            return false;
        }
        
        public bool isDigit(char x)
        {
            if(x>=48 && x<=57)
                return true;
            return false;
        }
        public string[] slpit(string str)
        {
            string[] strArr = new string[str.Length];
            return strArr;

        }

      
        
    }
}
