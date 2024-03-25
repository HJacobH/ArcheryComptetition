using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArcheryComptetition
{
    internal class Archer
    {
        public string jmeno { get; set; }
        public string prijmeni { get; set; }
        public int vek {  get; set; }
        public string narodnost {  get; set; }
        public int umisteni { get; set; }

        public Archer(string jmeno, string prijmeni, int vek, string narodnost, int umisteni) { 
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.narodnost = narodnost;
            this.umisteni = umisteni;
        }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}, vek: {vek}, narodnost: {narodnost}, misto: {umisteni}";
        }
    }
}
