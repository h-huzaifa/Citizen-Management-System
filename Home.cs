using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            Add addcivil = new Add();
            addcivil.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Add addcivil = new Add();
            addcivil.Show();
            this.Hide();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            login log = new login();
            log.Show();
            this.Hide();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Search search = new Search();
            search.Show();
            this.Hide();
        }
    }
}
