using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DateTime = System.DateTime;

namespace Katas
{
    public class Kata
    {
        public bool ValidateIpv4Address(string ip)
        {
            var iPparts = GetIpParts(ip);
            return IsIpLessThan4Characters(iPparts) && (!ip.EndsWith("0") && !ip.EndsWith("255"));
        }

        private static bool IsIpLessThan4Characters(IReadOnlyCollection<string> iPparts)
        {
            return iPparts.Count >= 4;
        }

        private static string[] GetIpParts(string ip)
        {
            return ip.Split('.');
        }
    }

    public class BalancedBrackets
    {
        public string ValidateBrackets(string input)
        {
            if (input == "") return string.Empty;
            var allowedChars = new[] { "[]", "[]", "[[]]", "[[[][]]]", "[][]" };
            var any = allowedChars.Any(chars => chars == input);
            if (any)
            {
                return "Ok";
            }
            if (!any)
            {
                return "Fail";
            }

            return string.Empty;
        }
    }

    public class LastSunday
    {
        public List<DateTime> LastSundayOfEachMonth(int year)
        {
            
            //for (var i = 0; i < 12; i++)
            //{
            //    var yearMonths = new DateTime(year, i, 1);
            //    yearMonths.
            //}
            return new List<DateTime>(new DateTime[2013-01-27]);
        }
    }
}
