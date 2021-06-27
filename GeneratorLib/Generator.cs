using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeneratorLib
{
    public static class Generator
    {
        public static string GenerirajKorisnickoIme(string ime, string prezime)
        {
            string korIme = "";
            int maxDuljina = 8;
            int minDuljina = 6;

            korIme += ime.Substring(0, 1);
            korIme += prezime;

            if (korIme.Length > maxDuljina)
            {
                korIme = korIme.Substring(0, maxDuljina);
            }
            else if (korIme.Length < minDuljina)
            {
                int brojZnakovaKojiFale = minDuljina - korIme.Length;
                Random r = new Random();
                for (int i = 0; i < brojZnakovaKojiFale; i++)
                {
                    korIme += r.Next(0, 9);
                }
            }

            return korIme.ToLower();
        }

        public static string GenerirajLozinku()
        {
            string lozinka = "";
            string slova = "abcdefghijklmnoprstuwyxzABCDEFGHIJKLMNOPRSTUWYXZ";
            int duljinaSlova = slova.Length;

            Random r = new Random();
            for (int i = 0; i < 8; i++)
            {
                if (i % 3 == 0)
                {
                    lozinka += r.Next(0, 9);

                }
                else
                {
                    lozinka += slova[r.Next(0, duljinaSlova - 1)];
                }
            }
            return lozinka;
        }
    }
}
