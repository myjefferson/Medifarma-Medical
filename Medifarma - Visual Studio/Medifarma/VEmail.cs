using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Medifarma
{
    class VEmail
    {
        public static bool validarEmail(string email)
        {
            bool Validar = false;
            int Analisar = email.IndexOf("@");

            if (Analisar > 0)
            {
                if (email.IndexOf("@", Analisar + 1) > 0)
                {
                    return Validar;
                }
                int i = email.IndexOf(".com", Analisar);
                if (i - 1 > Analisar)
                {
                    if (i + 1 > Analisar)
                    {
                        if (i + 1 < email.Length)
                        {
                            string r = email.Substring(i + 1, 1);
                            if (r != ".com")
                            {
                                Validar = true;
                            }
                        }
                    }
                }
            }
            return Validar;
        }
    }
}







