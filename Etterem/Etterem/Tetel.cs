using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Tetel
    {
        public string Nev { get; set; }
        public int Ar { get; set; }

        public Tetel (string nev, int ar)
        {
            this.Nev = nev;
            this.Ar = ar;
        }
    }
}
