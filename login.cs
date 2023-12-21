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
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void loginbt_Click(object sender, EventArgs e)
        {
            if (UseridTb.Text == "" || PasswordTb.Text == "")
            {
                if (UseridTb.Text == "")
                {
                    MessageBox.Show("Enter User ID");
                }
                else
                {
                    MessageBox.Show("Enter Password");
                }
            }
            else if (UseridTb.Text == "sirAdeelTheGreat" || PasswordTb.Text == "siradeeloop")
            {
                Home home = new Home();
                home.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Invalid User Id or Password");
            }
        }

        private void exitbt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void loginbt_MouseHover(object sender, EventArgs e)
        {
            loginbt.BackColor = Color.Green;
            loginbt.ForeColor = Color.LightGray;
        }

        private void loginbt_MouseLeave(object sender, EventArgs e)
        {
            loginbt.BackColor = Color.LightGray;
            loginbt.ForeColor = Color.Green;
        }

        private void exitbt_MouseHover(object sender, EventArgs e)
        {
            exitbt.BackColor = Color.Green;
            exitbt.ForeColor = Color.LightGray;
        }

        private void exitbt_MouseLeave(object sender, EventArgs e)
        {
            exitbt.BackColor = Color.LightGray;
            exitbt.ForeColor = Color.Green;
        }
    }
}
