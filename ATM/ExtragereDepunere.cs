using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Diagnostics;

namespace ATM
{
    public partial class ExtragereDepunere : Form
    {
        public Cont cont;
        public int tipOperatiune;

        System.IO.FileStream f = new System.IO.FileStream("testLog.txt", System.IO.FileMode.OpenOrCreate);
        SQLiteConnection _conn = new SQLiteConnection("DataSource=C:/Users/Acasa/Documents/MVP/ATM/ATM/new_db.sqlite;Version=3;");

        public ExtragereDepunere(Cont cont, int tip)
        {
            InitializeComponent();
            this.cont = cont;
            this.tipOperatiune = tip;

            _conn.Open();

            this.disponibilLabel.Text = "Disponibil: " + cont.disponibil.ToString();

            if (tipOperatiune == 0){
                this.titleLabel.Text = "EXTRAGERE";
            }
            else {
                this.titleLabel.Text = "DEPUNERE";
            }

        }

        private void okButon_Click(object sender, EventArgs e)
        {
            int valoare = Int32.Parse(this.valoareTextBox.Text);
            //extragere
            if (tipOperatiune == 0)
            {         
                if (valoare > cont.disponibil)
                {
                    this.infoLabel.Text = "Fonduri insuficiente!";
                }
                else {
                    //update valoare in db si in obiect
                    string stmt = "update conturi set disponibil = @disponibil where id = @id";
                    SQLiteCommand cmd = new SQLiteCommand(stmt, _conn);
                    cmd.Parameters.AddWithValue("@id", cont.id);
                    cmd.Parameters.AddWithValue("@disponibil", cont.disponibil - valoare);
                    try {
                        cmd.ExecuteNonQuery();
                        cont.disponibil = cont.disponibil - valoare;
                    } 
                    catch (Exception ex) { 
                        
                    }
                }
            }
            else {
                //update valoare in db si in obiect
                string stmt = "update conturi set disponibil = @disponibil where id = @id";
                SQLiteCommand cmd = new SQLiteCommand(stmt, _conn);
                cmd.Parameters.AddWithValue("@id", cont.id);
                cmd.Parameters.AddWithValue("@disponibil", cont.disponibil + valoare);

                try
                {
                    cmd.ExecuteNonQuery();
                    cont.disponibil = cont.disponibil + valoare;
                }
                catch (Exception ex)
                {

                }
            }

            f.Close();
            _conn.Close();
            _conn.Dispose();
            _conn = null;

            //deschid fereastra anterioara
            AccountForm ac = new AccountForm(cont);
            this.Hide();
            ac.Show();
           
        }
    }
}
