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
    public partial class Form1 : Form
    {

        public static string username,password;
        public static string benutzername;
        public static string nachname;
        public static string relbenutzername;
        string aktualisieren;
        public Form1()
        {
            InitializeComponent();
            textBox1.PasswordChar = '*';
            this.AcceptButton = button1;
            this.ActiveControl = textBox2;
            label3.Visible = false;

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool frage = false;
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                label3.Visible = true;

                string verbindung = @"server=;userid=;password=;database=";
                MySqlConnection anmelden = new MySqlConnection(verbindung);
           
                anmelden.Open();
               
                MySqlCommand anmeldeinformation = anmelden.CreateCommand();
                anmeldeinformation.CommandText = "SELECT v2,Nachname,Vorname,username, password FROM password WHERE username = '" + textBox2.Text + "' AND password = '" + textBox1.Text + "' ;";
                
                IDataReader reader = anmeldeinformation.ExecuteReader();

                if (reader.Read())
                {
                   
                    password = (string)reader["password"];
                    username = (string)reader["username"];
                    benutzername = (string)reader["Vorname"];
                    nachname = (string)reader["Nachname"];
                    aktualisieren = (string)reader["v2"];

                    if (textBox2.Text == username && textBox1.Text == password)
                    {
                        MessageBox.Show("Sie haben sich erfolgreich eingeloggt","Wilkommen",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frage = true;
                        textBox1.Text = "";
                        textBox2.Text = "";

                        relbenutzername = username;
                        //  benutzername = username;

                        reader.Close();
                        anmeldeinformation.Dispose();
                        anmelden.Close();

                        if (aktualisieren == "1")
                        {
                            MessageBox.Show("Hallo " + benutzername + " in SnychScreen v2.1 hat sich einiges verändert \r\n \r\n --- Du wirst im Hauptfenster mit dem ganzen Namen angesprochen \r\n --- Ab jetzt kannst du deinen Benutzerdaten nachträglich ändern  \r\n --- Formatierung mit Shortcuts (siehe Hilfe) erstellt werden \r\n --- Die HTML Formatierung wird nun per Knopf erstellt  \r\n --- Die Benutzerdarstellung kann individualisiert werden \r\n  \r\n >>> Version 2.1", "Update",MessageBoxButtons.OK,MessageBoxIcon.Information);

                            reader.Close();
                            anmeldeinformation.Dispose();
                            anmelden.Close();

                            string verbindung2 = @"server=;userid=;password=;database=";
                            MySqlConnection anmelden2 = new MySqlConnection(verbindung2);

                            anmelden2.Open();

                            MySqlCommand anmeldeinformation2 = anmelden2.CreateCommand();
                            anmeldeinformation2.CommandText = "UPDATE password SET v2 = '0' WHERE username = '" + username + "'  ;";

                            IDataReader reader2 = anmeldeinformation2.ExecuteReader();

                            if (reader2.Read())
                            {

                            }
                            reader2.Close();
                            anmeldeinformation2.Dispose();
                            anmelden2.Close();
                        }



                        Form2 fm = new Form2();
                        Hide();
                        fm.Show();
             
                    }
                    else
                    {
                        MessageBox.Show("Benutzername und,oder Passwort sind nicht korrekt,existieren nicht");
                        label3.Visible = false;
                    }

                }
               

               

                }
            else
                MessageBox.Show("Fehler");
            if (!frage)
            {
                MessageBox.Show("Anmeldedaten sind nicht korrekt", "Fehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBox1.Text = "";
                textBox2.Text = "";
                label3.Visible = false;
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

       
    }
}
