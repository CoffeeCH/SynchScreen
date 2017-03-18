using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace SQL_Password
{
    public partial class Form2 : Form
    {
        static string text;
        string Vorname, Nachname;
        private Form1 frm1;
        int zeilenumbruch = 0;
        int fett = 0;
        int kursiv = 0;
        
      
        public Form2()
        {
            InitializeComponent();

          

            string verbindung = @"server=;userid=;password=;database=";
            MySqlConnection anmelden = new MySqlConnection(verbindung);

            anmelden.Open();

            MySqlCommand anmeldeinformation = anmelden.CreateCommand();
            anmeldeinformation.CommandText = "SELECT Vorname, Nachname FROM password where username = '" + Form1.username + "' ;";

            IDataReader reader2 = anmeldeinformation.ExecuteReader();

            if (reader2.Read())
            {
                
                Vorname = (string)reader2["Vorname"];
                Nachname = (string)reader2["Nachname"];
            }

            reader2.Close();
            anmeldeinformation.Dispose();
            anmelden.Close();

            laBenutzer.Text = Vorname + " " + Nachname;
            label2.BackColor = Color.Yellow;
            label2.Text = "Bereit";
            raInformationen.Checked = true;

            KeyPreview = true;
            KeyDown += new KeyEventHandler(Form1_KeyDown);

        }

      

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            label2.BackColor = Color.Yellow;
            label2.Text = "Bereit";



        }

        private void btnLaden_Click(object sender, EventArgs e)
        {

      

            if (raTermine.Checked)
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "SELECT Termin FROM termine where TerminID = 1";

                IDataReader reader = anmeldeinformation.ExecuteReader();

                if (reader.Read())
                {
                    text = (string)reader["Termin"];
                }

                reader.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
                label2.BackColor = Color.Yellow;
                label2.Text = "Bereit";

            }

            else if (raInformationen.Checked)
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "SELECT Inhalt FROM informationen where TextID = 1";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {
                    text = (string)reader2["Inhalt"];
                }

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
                label2.BackColor = Color.Yellow;
                label2.Text = "Bereit";

            }





            richTextBox1.Text = text;

        }

        private void btnSenden_Click(object sender, EventArgs e)
        {


            if (raTermine.Checked)
            {
                if (MessageBox.Show("Wollen sie ihren Eintrag wirklich senden?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    string verbindung = @"server=;userid=;password=;database=";
                    MySqlConnection anmelden = new MySqlConnection(verbindung);

                    anmelden.Open();

                    MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                    anmeldeinformation.CommandText = "UPDATE termine SET Termin = '" + richTextBox1.Text + "' WHERE TerminID = 1";

                    IDataReader reader = anmeldeinformation.ExecuteReader();

                    /*  if (reader.Read())
                      {
                          text = (string)reader["Inhalt"];
                      }

                      reader.Close(); */
                    anmeldeinformation.Dispose();
                    anmelden.Close();

                    label2.Text = "Gesendet";
                    label2.BackColor = Color.Green;
                }
            }
            else if (raInformationen.Checked)
            {
                if (MessageBox.Show("Wollen sie ihren Eintrag wirklich senden?", " ", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string verbindung = @"server=;userid=;password=;database=";
                    MySqlConnection anmelden = new MySqlConnection(verbindung);

                    anmelden.Open();

                    MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                    anmeldeinformation.CommandText = "UPDATE informationen SET Inhalt = '" + richTextBox1.Text + "' WHERE TextID = 1;";

                    IDataReader reader2 = anmeldeinformation.ExecuteReader();

                    if (reader2.Read())
                    {
                        text = (string)reader2["Inhalt"];
                    }

                    reader2.Close();
                    anmeldeinformation.Dispose();
                    anmelden.Close();

                    label2.Text = "Gesendet";
                    label2.BackColor = Color.Green;
                }
            }
            
        }

        private void Auswahl_Enter(object sender, EventArgs e)
        {

        }

        private void raInformationen_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void raTermine_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void btnBenutzer_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            Hide();
            fmr.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSchliessen_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            richTextBox1.Text = richTextBox1.Text + "<br>";
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richtextbo1_KEyDown(object sender, KeyEventArgs e)
        {
            int laenge;
            if (e.KeyCode == Keys.Enter)
            {
                if (zeilenumbruch == 0 && fett != 1 && kursiv != 1)
                {
                    richTextBox1.Text = richTextBox1.Text + "<br>";
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;

                }
                else if (zeilenumbruch == 1)
                {
                    richTextBox1.Text = richTextBox1.Text + "</li>";
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;

                    richTextBox1.AppendText("<li>");

                }
                else if (fett == 1)
                {
                    richTextBox1.AppendText("</b>" + "<br>");
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;

                    fett = 0;

                }

                else if (kursiv == 1)
                {
                    richTextBox1.AppendText("</i>" + "<br>");
                    richTextBox1.Focus();
                    richTextBox1.SelectionStart = richTextBox1.Text.Length;

                    kursiv = 0;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            if (!richTextBox1.Text.Contains("<ol>"))
            {

                richTextBox1.Text = richTextBox1.Text + "<ol>";
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.AppendText("\r\n" + "<li>");
                zeilenumbruch = 1;


            }

           else  if (zeilenumbruch == 1)
            {
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.AppendText("</li>" + "</ol>" + "\r\n");
                zeilenumbruch = 0;
            }
            
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<b>");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

            fett = 1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.AppendText("<i>");
            richTextBox1.Focus();
            richTextBox1.SelectionStart = richTextBox1.Text.Length;

            kursiv = 1;
        }

        private void btnHilfe_Click(object sender, EventArgs e)
        {
            Form7 fme = new Form7();
            Close();
            fme.Show();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && ((e.KeyCode & Keys.F) == Keys.F))
            {
                button1.PerformClick();

            }

            else if (e.Control && ((e.KeyCode & Keys.K) == Keys.K))
            {
                button2.PerformClick();
            }
                
            else if (e.Control && ((e.KeyCode & Keys.L) == Keys.L))
            {
                button3.PerformClick(); 
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!richTextBox1.Text.Contains("<ol>"))
            {

                richTextBox1.Text = richTextBox1.Text + "<ol>";
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.AppendText("\r\n" + "<li>");
                zeilenumbruch = 1;


            }

            else if (zeilenumbruch == 1)
            {
                richTextBox1.Focus();
                richTextBox1.SelectionStart = richTextBox1.Text.Length;
                richTextBox1.AppendText("</li>" + "</ol>" + "\r\n");
                zeilenumbruch = 0;
            }
        }

        private void lalBefehl_Click(object sender, EventArgs e)
        {

        }

        
        

       


        //  anmeldeinformation.CommandText = "UPDATE password SET password = '" + textBox2.Text +"' WHERE username = '" + ;



    }
}
