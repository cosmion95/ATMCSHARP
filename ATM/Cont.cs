using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Cont
    {
        public Cont(int id, Moneda tip, float disponibil, DateTime dataDeschidere, Client client)
        {
            this.id = id;
            this.tip = tip;
            this.disponibil = disponibil;
            this.dataDeschidere = dataDeschidere;
            this.client = client;
        }

        public int id { get; }
        public Moneda tip { get; }
        public float disponibil { get; set; }
        public DateTime dataDeschidere { get;  }
        public Client client { get; }
    }
}
