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
    public partial class Form4 : Form
    {
        public static string tmpbenutzer;
        
        
        public Form4()
        {
            tmpbenutzer = Form1.username;
            InitializeComponent();
        }

        private void btnZurueck_Click(object sender, EventArgs e)
        {
            Form3 fmr = new Form3();
            Hide();
            fmr.Show();
        }

        private void btnPasswortChange_Click(object sender, EventArgs e)
        {
            if (txtNeuPass.Text == txtWiderholen.Text)
            {

                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);

                anmelden.Open();

                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "UPDATE password SET password = '" + txtWiderholen.Text + "' WHERE username = '" + tmpbenutzer + "';";

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

            else if (txtNeuPass.Text != txtWiderholen.Text)
            {
                MessageBox.Show("Die neuen Passwörter stimmen nicht überein", "Achtung", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNeuPass.Text = "";
                txtWiderholen.Text = "";
            }
            
        }

        private void txtNeuPass_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWiderholen_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }
    }
}
