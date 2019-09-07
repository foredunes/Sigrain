using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sigran.Classes
{
    static class Functions
    {
        public static string DecimalToString(Decimal d, int precision = 3)
        {
            string s = "0";
            if(precision > 0)
            {
                s = s + ".";
            }
            for(int i=1; i<=precision; i++)
            {
                s = s + "0";
            }

            return d.ToString(s, CultureInfo.CreateSpecificCulture("PT-BR"));
        }
    }
}
