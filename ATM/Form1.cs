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
    public partial class Form1 : Form
    {
        System.IO.FileStream f = new System.IO.FileStream("testLog.txt", System.IO.FileMode.OpenOrCreate);
        SQLiteConnection _conn = new SQLiteConnection("DataSource=C:/Users/Acasa/Documents/MVP/ATM/ATM/new_db.sqlite;Version=3;");
        
        public Form1()
        {
            InitializeComponent();
            _conn.Open();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = this.userTextBox.Text;
            string password = this.passTextBox.Text;

            string stmt = "select id from clienti where username = @username and password = @password";
            SQLiteCommand command = new SQLiteCommand(stmt, _conn);
            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            

            TextWriterTraceListener txtLst = new TextWriterTraceListener(f);
            Trace.Listeners.Add(txtLst);
            Trace.AutoFlush = true; 
            Trace.WriteLine("LOGIN ATTEMPT WITH " + username + " -- " + password);

            try
            {
                int idRezultat = Int32.Parse(command.ExecuteScalar().ToString());
                Trace.WriteLine("login succesful");

                f.Close();
                _conn.Close();
                _conn.Dispose();
                _conn = null;


                ClientForm clientForm = new ClientForm(idRezultat);
                this.Hide();
                clientForm.Show();

               
                
            }
            catch(Exception ex)
            {
                Trace.WriteLine("login failed");

                this.resultLabel.Text = "Username sau parola incorecte.";
            }


            
        }
    }
}
