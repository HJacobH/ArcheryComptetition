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
        public string luk {  get; set; }
        public ArrowTypes sip {  get; set; }

        public Archer(string jmeno, string prijmeni, int vek, string narodnost, int umisteni, string luk, ArrowTypes sip) { 
            this.jmeno = jmeno;
            this.prijmeni = prijmeni;
            this.vek = vek;
            this.narodnost = narodnost;
            this.umisteni = umisteni;
            this.luk = luk;
            this.sip = sip;
        }

        public override string ToString()
        {
            return $"{jmeno} {prijmeni}, vek: {vek}, narodnost: {narodnost}, misto: {umisteni}, luk: {luk}, sip: {sip}";
        }
    }
}
