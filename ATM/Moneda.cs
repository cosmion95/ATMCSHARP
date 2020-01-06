using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Moneda
    {
        public Moneda(string cod, string denumire)
        {
            this.cod = cod;
            this.denumire = denumire;
        }

        public Moneda(string cod)
        {
            this.cod = cod;
        }

        public string cod { get; }
        public string denumire { get; }

    }
}
