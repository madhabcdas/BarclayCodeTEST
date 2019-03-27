using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Utility
{
    public class Utility
    {
        public static bool IsValidPath(string path)
        {
            Regex r = new Regex(@"^(?:[\w]\:|\\)(\\[a-z_\-\s0-9\.]+)+\.(txt|gif|pdf|doc|docx|xls|xlsx)$");
            return r.IsMatch(path);
        }
    }
}
