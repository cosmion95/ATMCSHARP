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
using System.Xml;

namespace ATM
{
    public partial class TransferForm : Form
    {
        System.IO.FileStream f = new System.IO.FileStream("testLog.txt", System.IO.FileMode.OpenOrCreate);
        SQLiteConnection _conn = new SQLiteConnection("DataSource=C:/Users/Acasa/Documents/MVP/ATM/ATM/new_db.sqlite;Version=3;");

        public Cont cont { get; }
        public TransferForm(Cont cont)
        {
            InitializeComponent();
            this.cont = cont;
            _conn.Open();

            string contLabel = "Contul " + cont.id + ", moneda: " + cont.tip.cod;
            this.contLabel.Text = contLabel;
            this.disponibilLabel.Text = cont.disponibil.ToString();
        }

        private void acceptButton_Click(object sender, EventArgs e)
        {
            //obtin valorile introduse
            int idContDestinatie = Int32.Parse(this.contTextBox.Text);

            if (cont.id == idContDestinatie)
            {
                this.infoLabel.Text = "Nu puteti efectua transferuri intre acelasi cont.";
            }
            else {
                string numeBeneficiar = this.NumeTextBox.Text;
                string mesaj = this.MesajTextBox.Text;
                float valoare = float.Parse(this.ValoareTextBox.Text);

                float dobanda = (float) (valoare * 0.01);

                if (valoare + dobanda > cont.disponibil)
                {
                    this.infoLabel.Text = "Fonduri insuficiente.";
                }
                else {
                    string stmt = "select conturi.tip from conturi, clienti where conturi.client = clienti.id and conturi.id = @idCont";
                    SQLiteCommand cmd = new SQLiteCommand(stmt, _conn);
                    cmd.Parameters.AddWithValue("@idCont", idContDestinatie);
                    try
                    {
                        string monedaDest = cmd.ExecuteScalar().ToString();
                        float valoareRezultata;
                        if (cont.tip.cod.Equals(monedaDest))
                        {
                            //conturile au aceeasi moneda
                            valoareRezultata = valoare;
                        }
                        else
                        {
                            //conturile folosesc monede diferite
                            //obtin cursul de schimb la zi

                            string m;
                            //aflu moneda care nu e ron
                            if (cont.tip.cod.Equals("RON"))
                            {
                                m = monedaDest;
                            }
                            else {
                                m = cont.tip.cod;
                            }
                            String URLString = "https://www.bnr.ro/nbrfxrates.xml";
                            XmlTextReader reader = new XmlTextReader(URLString);
                            String cursSchimb = "";
                            while (reader.Read())
                            {
                                if (reader.NodeType == XmlNodeType.Element && reader.Name == "Rate" &&
                                    reader.GetAttribute("currency").Equals(m))
                                {
                                    cursSchimb = reader.ReadElementContentAsString();
                                }
                            }

                            float cSchimb = float.Parse(cursSchimb);
                            if (cont.tip.cod.Equals("RON"))
                            {
                                //facem impartire 
                                valoareRezultata = valoare / cSchimb;
                            }
                            else {
                                //facem inmultire
                                valoareRezultata = valoare * cSchimb;
                            }

                            Console.WriteLine("actualizez valoare in contul nou +" + valoareRezultata);
                            //adaug valoarea la noul cont
                            string stmt2 = "update conturi set disponibil = disponibil + @valoare where id = @idCont";
                            SQLiteCommand cmd2 = new SQLiteCommand(stmt2, _conn);
                            cmd2.Parameters.AddWithValue("@valoare", valoareRezultata);
                            cmd2.Parameters.AddWithValue("@idCont", idContDestinatie);
                            cmd2.ExecuteNonQuery();

                            Console.WriteLine("actualizez valoare in contul vechi -" + valoare);
                            //scad valoarea din contul vechi
                            string stmt3 = "update conturi set disponibil = disponibil - @valoare where id = @idCont";
                            SQLiteCommand cmd3 = new SQLiteCommand(stmt3, _conn);
                            cmd3.Parameters.AddWithValue("@valoare", valoare);
                            cmd3.Parameters.AddWithValue("@idCont", cont.id);
                            cmd3.ExecuteNonQuery();

                            //actualizez valoarea si in obiect
                            cont.disponibil = cont.disponibil - valoare;
                            string stmt4 = "INSERT INTO tranzactii(dinC,inC,tip_tranzactie,valoare,data,mesaj) VALUES(@dinC,@inC,@tipTranz,@valoare,@data,@mesaj)";
                            SQLiteCommand cmd4 = new SQLiteCommand(stmt4, _conn);
                            cmd4.Parameters.AddWithValue("@dinC", cont.id);
                            cmd4.Parameters.AddWithValue("@inC", idContDestinatie);
                            cmd4.Parameters.AddWithValue("@tipTranz", "TRANSFER");
                            cmd4.Parameters.AddWithValue("@valoare", valoare);
                            cmd4.Parameters.AddWithValue("@data", DateTime.Now);
                            cmd4.Parameters.AddWithValue("@mesaj", this.MesajTextBox.Text);
                            cmd4.ExecuteNonQuery();

                            //inregistrez o tranzactie noua

                            f.Close();
                            _conn.Close();
                            _conn.Dispose();
                            _conn = null;


                            //deschid pagina anterioara
                            //deschid fereastra de transfer
                            AccountForm ex = new AccountForm(cont);
                            this.Hide();
                            ex.Show();


                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine("ajuns aici");
                    }

                }

            }
            //string stmt = "update conturi set disponibil = @disponibil where id = @id";
            
        }
    }
}
