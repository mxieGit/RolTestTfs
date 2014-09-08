using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public static class Utils
    {
        public static string FormatDateTime(DateTime dt)
        {
            return dt.ToString("F");
        }
    }
}
