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
        
        public bool isCanSum(string str)
        {
            if(isNumber(str))
                return true;
            return false;
        }
        
    }
}
