using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    public class Client
    {
        public Client(int id, string nume, string prenume, string username, string juridica, DateTime dataInregistrare, Adresa adresa)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.username = username;
            this.juridica = juridica;
            this.dataInregistrare = dataInregistrare;
            this.adresa = adresa;
        }

        public Client(int id, string nume, string prenume, string username, string juridica, DateTime dataInregistrare)
        {
            this.id = id;
            this.nume = nume;
            this.prenume = prenume;
            this.username = username;
            this.juridica = juridica;
            this.dataInregistrare = dataInregistrare;
        }

        public int id { get; set; }
        public string nume { get; set; }
        public string prenume { get; set; }
        public string username { get; set; }
        public string juridica { get; set; }
        public DateTime dataInregistrare { get; set; }
        public Adresa adresa { get; set; }
    }
}
