using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    public class LengthHelper
    {
        public static int findLength(string str)
        {
            try
            {
                if (String.IsNullOrEmpty(str))
                    return 0;

                return str.Length;
            }
            catch { return 0; }
        }
    }
}
