using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Katas
{
    public class IPKata
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
}
