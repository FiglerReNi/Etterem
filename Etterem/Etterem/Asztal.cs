using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Etterem
{
    class Asztal
    {
        public string AsztalNev { get; set; }

        public List<Tetel> Tetelek;

        public Asztal (string asztalnev)
        {
            this.AsztalNev = asztalnev;
            Tetelek = new List<Tetel>();
        }
    }
}
