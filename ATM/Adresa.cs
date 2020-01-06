using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Adresa
    {
        public Adresa(int id, string tara, string judet, string localitate, string numar, string codPostal, string strada)
        {
            this.id = id;
            this.tara = tara;
            this.judet = judet;
            this.localitate = localitate;
            this.numar = numar;
            this.codPostal = codPostal;
            this.strada = strada;
        }

        public int id { get; set; }
        public string tara { get; set; }
        public string judet { get; set; }
        public string localitate { get; set; }
        public string numar { get; set; }
        public string codPostal { get; set; }
        public string strada { get; set; }


    }
}
