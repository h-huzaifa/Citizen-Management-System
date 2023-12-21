using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Project
{
    public partial class Add : Form
    {
        public Add()
        {
            InitializeComponent();
        }
        
        // To create Connection
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H.A.R\Documents\MyCivilianDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (CivilidTb.Text == "" || CivilnameTb.Text == "" || CiviladdTb.Text == "" || CivilFatheridTb.Text == "" || CivilFathernameTb.Text == "" || CivilphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    // To open Connection
                    Con.Open();
                    // To create Commond
                    string query = "insert into CivilianTbl values('" + CivilidTb.Text + "','" + CivilnameTb.Text + "','" + CiviladdTb.Text + "','" + CivilFatheridTb.Text + "','" + CivilFathernameTb.Text + "','" + CivilDOB.Value.Date + "','" + CivilphoneTb.Text + "','" + CivilGenderCb.SelectedItem.ToString() + "')";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    // To Excute The Command
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Civilian Data Successfully Recorded");
                    // To Close Connection
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }

        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void populate()
        {
            Con.Open();
            // To create a bridge between the dataset and database
            string query = "select * from CivilianTbl";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con);
            // if Changes are made then update the database
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet(); // Local Copy of the DataBase in form of Rows and Columns
            sda.Fill(ds); // To fill the Local Copy
            CivilianDGV.DataSource = ds.Tables[0]; // Display The Local Copy
            Con.Close();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            populate();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            if (CivilidTb.Text == "")
            {
                MessageBox.Show("Enter The Employee ID");
            } 
            else
            {
                try
                {
                    Con.Open();
                    string query = "delete from CivilianTbl where Civilid ='" + CivilidTb.Text + "'";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Civilian Data Successfully Deleted");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CivilianDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CivilidTb.Text = CivilianDGV.SelectedRows[0].Cells[0].Value.ToString();
            CivilnameTb.Text = CivilianDGV.SelectedRows[0].Cells[1].Value.ToString();
            CiviladdTb.Text = CivilianDGV.SelectedRows[0].Cells[2].Value.ToString();
            CivilFatheridTb.Text = CivilianDGV.SelectedRows[0].Cells[3].Value.ToString();
            CivilFathernameTb.Text = CivilianDGV.SelectedRows[0].Cells[4].Value.ToString();
            CivilphoneTb.Text = CivilianDGV.SelectedRows[0].Cells[6].Value.ToString();
            CivilGenderCb.SelectedItem = CivilianDGV.SelectedRows[0].Cells[7].Value.ToString();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            if (CivilidTb.Text == "" || CivilnameTb.Text == "" || CiviladdTb.Text == "" || CivilFatheridTb.Text == "" || CivilFathernameTb.Text == "" || CivilphoneTb.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Con.Open();
                    string query = "update CivilianTbl set Civilname = '" + CivilnameTb.Text + "', Civiladd = '" + CiviladdTb.Text + "', CivilFatherid = '" + CivilFatheridTb.Text + "', CivilFathername = '" + CivilFathernameTb.Text + "', CivilDOB = '" + CivilDOB.Value.Date + "', Civilphone = '" + CivilphoneTb.Text + "', CivilGender = '" + CivilGenderCb.SelectedItem.ToString() + "' where Civilid = '" + CivilidTb.Text + "';";
                    SqlCommand cmd = new SqlCommand(query, Con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Civilian Data Successfully Updated");
                    Con.Close();
                    populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void cross_MouseHover(object sender, EventArgs e)
        {
            cross.ForeColor = Color.Red;
        }

        private void cross_MouseLeave(object sender, EventArgs e)
        {
            cross.ForeColor = Color.GreenYellow;
        }
    }
}
