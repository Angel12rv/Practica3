using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ComponentesPersonalizados1
{
    public class RFCValidator
    {
        public static bool EsRFCValido(string rfc)
        {
            string pattern = @"^[A-Z]{4}\d{6}[A-Z0-9]{2,3}$";
            return Regex.IsMatch(rfc, pattern);
        }

        public static string CorregirRFC(string rfc)
        {
            rfc = rfc.ToUpper().Trim();
            return rfc;
        }
    }
}