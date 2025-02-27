using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComponentesPersonalizados1
{
    public class InputValidator
    {
        public static bool EsSoloNumeros(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }

        public static bool EsSoloLetras(string texto)
        {
            foreach (char c in texto)
            {
                if (!char.IsLetter(c))
                {
                    return false;
                }
            }
            return true;
        }
    }
}
