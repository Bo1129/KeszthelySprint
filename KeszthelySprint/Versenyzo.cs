using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KeszthelySprint
{
    internal class Versenyzo
    {
        public string nev { get; set; }
        public int szuletesi_ev { get; set; }
        public int rajtszam { get; set; }
        public string nem { get; set; }
        public string kategoria { get; set; }
        public string[] idok { get; set; }

        public Versenyzo(string sor)
        {
            string[] s = sor.Split(';');

            nev = s[0];
            szuletesi_ev = int.Parse(s[1]);
            rajtszam = int.Parse(s[2]);
            nem = s[3];
            kategoria = s[4];
            idok = new string[5];
            idok[0] = s[5];
            idok[1] = s[6];
            idok[2] = s[7];
            idok[3] = s[8];
            idok[4] = s[9];

        }
    }
}

