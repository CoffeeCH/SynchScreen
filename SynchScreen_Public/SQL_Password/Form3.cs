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
    public partial class Form3 : Form
    {
        static string tmpbenutzer;
        static string reltmpbenutzer;
        static string vorname, nachname;
        string geb,gebu;
        
        
        public Form3()
        {
            InitializeComponent();
            
            lblBenutzerkontoOut.Text = Form1.relbenutzername;
            tmpbenutzer = Form1.benutzername;
            reltmpbenutzer = Form1.relbenutzername;
            laGeburtstag.Visible = false;
            laGeburtstagOut.Visible = false;

           
            string verbindung = @"server=;userid=;password=;database=";
            MySqlConnection anmelden = new MySqlConnection(verbindung);

            anmelden.Open();

            MySqlCommand anmeldeinformation = anmelden.CreateCommand();
            anmeldeinformation.CommandText = "SELECT Geburtstag, GebAnzeigen, username, Vorname, Nachname FROM password where username = '" + reltmpbenutzer + "' ;";

            IDataReader reader2 = anmeldeinformation.ExecuteReader();

            if (reader2.Read())
            {
                tmpbenutzer = (string)reader2["username"];
                vorname = (string)reader2["Vorname"];
                nachname = (string)reader2["Nachname"];
                geb = (string)reader2["GebAnzeigen"];
                gebu = (string)reader2["Geburtstag"];
            }

            reader2.Close();
            anmeldeinformation.Dispose();
            anmelden.Close();

            if (geb == "0")
            {
                laGeburtstag.Visible = false;
                laGeburtstagOut.Visible = false;
            }
            else if (geb == "1")
            {
                laGeburtstag.Visible = true;
                laGeburtstagOut.Visible = true;
                laGeburtstagOut.Text = gebu;
            }
            label4.Text = vorname;
            label6.Text = nachname;


        }

        private void lblBenuterkonto_Click(object sender, EventArgs e)
        {

        }

        private void lblVorname_Click(object sender, EventArgs e)
        {

        }

        private void lblNachname_Click(object sender, EventArgs e)
        {

        }

        private void txtNeuPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWiderholen_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnPasswortChange_Click(object sender, EventArgs e)
        {
         
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Form2 fme = new Form2();
            Close();
            fme.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form6 fmr = new Form6();
            Hide();
            fmr.Show();
        }

        private void btnZurueck_Click_1(object sender, EventArgs e)
        {
            Form2 fme = new Form2();
            Close();
            fme.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form4 fmr = new Form4();
            Hide();
            fmr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form5 fmr = new Form5();
            Hide();
            fmr.Show();
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }
    }
}
