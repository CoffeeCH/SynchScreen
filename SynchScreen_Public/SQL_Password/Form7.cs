using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SQL_Password
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnZurück_Click(object sender, EventArgs e)
        {
            Form2 fme = new Form2();
            Close();
            fme.Show();
        }

        private void Form7_Load(object sender, EventArgs e)
        {

        }
    }
}
