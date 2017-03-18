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
    public partial class Form5 : Form


    {
        string geb;

        public Form5()
        {
            InitializeComponent();
            laBenutzername.Text = Form1.username;
            label1.Text = "";

            string verbindung = @"server=;userid=;password=;database=";
            MySqlConnection anmelden = new MySqlConnection(verbindung);

            anmelden.Open();

            MySqlCommand anmeldeinformation = anmelden.CreateCommand();
            anmeldeinformation.CommandText = "SELECT GebAnzeigen from password WHERE username = '" + laBenutzername.Text + "';";

            IDataReader reader2 = anmeldeinformation.ExecuteReader();

            if (reader2.Read())
            {
                geb = (string)reader2["GebAnzeigen"];
            }

           

            reader2.Close();
            anmeldeinformation.Dispose();
            anmelden.Close();



            if (geb == "1")
            {
                checkGeburtstag.Checked = true;
            }
            else if (geb != "1")
            {
                checkGeburtstag.Checked = false;
            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }

        private void laBenutzername_Click(object sender, EventArgs e)
        {

        }

        private void txtVorname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNachname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtGeburtstag_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkGeburtstag_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            Hide();
            fmr.Show();
        }

        private void btnSpeichern_Click(object sender, EventArgs e)
        {
            if (txtVorname.Text != "")
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET Vorname = '" + txtVorname.Text + "'WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
            }
            else if (txtNachname.Text != "")
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET Nachname = '" + txtNachname.Text + "'WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
            }
            else if (txtNachname.Text != "" && txtVorname.Text != "")
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET Nachname = '" + txtNachname.Text + "'WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
            }
            else if (txtNachname.Text != "" && txtVorname.Text != "" && checkGeburtstag.Checked)
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET Nachname = '" + txtNachname.Text + "' , GebAnzeigen = '1' WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();

            }
            else if (checkGeburtstag.Checked)
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET GebAnzeigen = '1' WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
            }

            else if (!checkGeburtstag.Checked)
            {
                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET GebAnzeigen = '0' WHERE username = '" + laBenutzername.Text + "';";

                IDataReader reader2 = anmeldeinformation.ExecuteReader();

                if (reader2.Read())
                {

                }

                label1.BackColor = Color.Green;
                label1.Text = "Geändert";
                label1.ForeColor = Color.White;

                reader2.Close();
                anmeldeinformation.Dispose();
                anmelden.Close();
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
