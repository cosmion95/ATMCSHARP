using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ATM
{
    public partial class AccountForm : Form
    {
        public Cont cont;
        public AccountForm(Cont cont)
        {
            InitializeComponent();
            this.cont = cont;

            String titlu = "Cont " + cont.id.ToString() + ", moneda: " + cont.tip.cod;
            this.titleLabel.Text = titlu;
            this.disponibilLabel.Text = "Disponibil: " + cont.disponibil.ToString();

        }

        private void extrageButon_Click(object sender, EventArgs e)
        {
            //deschidem fereastra de extragere
            ExtragereDepunere ex = new ExtragereDepunere(cont, 0);
            this.Hide();
            ex.Show();
        }

        private void depunereButon_Click(object sender, EventArgs e)
        {
            //deschidem fereastra de extragere
            ExtragereDepunere ex = new ExtragereDepunere(cont, 1);
            this.Hide();
            ex.Show();
        }
    }
}
