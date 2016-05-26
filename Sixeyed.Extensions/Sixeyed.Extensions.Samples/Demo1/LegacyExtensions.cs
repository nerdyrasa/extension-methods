using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sixeyed.Extensions.Samples.Demo1
{
    public static class LegacyExtensions
    {
        // Extension methods allow you to use domain-specific logic within the context of  
        // ordinary system objects DateTime and string.

        public static string ToLegacyFormat(this DateTime datetime)
        {
            return datetime.Year > 1930 ? datetime.ToString("1yyMMdd") : datetime.ToString("0yyMMdd");
            
        }

        public static string ToLegacyFormat(this string name)
        {
            var parts = name.ToUpper().Split(' ');
            return parts[1] + ", " + parts[0];
        }
    }
}
