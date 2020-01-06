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
    public partial class ClientForm : Form
    {
        public int idClient { get; }
        private Client client;

        System.IO.FileStream f = new System.IO.FileStream("testLog.txt", System.IO.FileMode.OpenOrCreate);
        SQLiteConnection _conn = new SQLiteConnection("DataSource=C:/Users/Acasa/Documents/MVP/ATM/ATM/new_db.sqlite;Version=3;");

        public ClientForm(int idClient)
        {
            InitializeComponent();
            this.idClient = idClient;

            _conn.Open();

            //obtinem toate datele despre client
            string stmt = "select * from clienti where id = @id";
            SQLiteCommand command = new SQLiteCommand(stmt, _conn);
            command.Parameters.AddWithValue("@id", idClient);
            SQLiteDataReader reader = null;
            try
            {
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    client = new Client(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetString(3), reader.GetString(5), DateTime.Parse(reader.GetString(6)));
                    this.titleLabel.Text = reader.GetString(1) + " " + reader.GetString(2) + ", bine ai revenit";
                }

            }
            catch (Exception ex)
            {
                Trace.WriteLine("Eroare la crearea obiectului de tip client.");
            }
            reader.Close();

            //obtinem toate conturile clientului
            stmt = "select * from conturi where client = @id";
            SQLiteCommand command2 = new SQLiteCommand(stmt, _conn);
            command2.Parameters.AddWithValue("@id", idClient);
            try
            {
                reader = command2.ExecuteReader();
                while (reader.Read())
                {
                    string contText = reader.GetInt64(0).ToString() + " - " + reader.GetString(2) + ", disponibil: " + reader.GetFloat(3).ToString();
                    this.accountsList.Items.Add(contText);
                }

            }
            catch (Exception ex2)
            {
                Trace.WriteLine("Eroare la obtinerea conturilor clientului");
            }
            reader.Close();
        }

        private void chooseButon_Click(object sender, EventArgs e)
        {
            //obtinem obiectul de tip CONT

            //obtin id-ul contului
            string infoCont = this.accountsList.SelectedItem.ToString();
            int idCont = Int32.Parse(infoCont.Split(' ')[0]);


            string stmt = "select * from conturi where id = @id";
            SQLiteCommand command = new SQLiteCommand(stmt, _conn);
            command.Parameters.AddWithValue("@id", idCont);
            SQLiteDataReader reader = null;
            try
            {
                float disponibil = 0;
                String dataDeschidere = "";
                String tipMoneda = "";
                reader = command.ExecuteReader();
                while (reader.Read())
                {
                    tipMoneda = reader.GetString(2);
                    //cont = new Cont(idCont, moneda, reader.GetFloat(3), DateTime.Parse(reader.GetString(4)), client);
                    disponibil = reader.GetFloat(3);
                    dataDeschidere = reader.GetString(4);
                }
                reader.Close();
                Moneda moneda = new Moneda(tipMoneda);
                Cont cont = new Cont(idCont, moneda, disponibil, DateTime.Parse(dataDeschidere), client);

                f.Close();
                _conn.Close();
                _conn.Dispose();
                _conn = null;
               
                AccountForm acc = new AccountForm(cont);
                this.Hide();
                acc.Show();

            }
            catch (Exception ex)
            {
                Trace.WriteLine("Eroare la crearea obiectului de tip cont.");
            }
            

        }

        private void logoutButon_Click(object sender, EventArgs e)
        {
            //inchidem fereastra curenta, deschidem fereastra de login

            f.Close();
            _conn.Close();
            _conn.Dispose();
            _conn = null;

            this.Hide();
            Form1 form = new Form1();
            form.Show();

        }
    }
}
