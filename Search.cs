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
    public partial class Search : Form
    {
        public Search()
        {
            InitializeComponent();
        }
        
        SqlConnection Con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\H.A.R\Documents\MyCivilianDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void fetchCivilData()
        {
            Con.Open();
            string query = "select * from CivilianTbl where Civilid = '" + CivilidTb.Text + "'";
            SqlCommand cmd = new SqlCommand(query, Con);
            DataTable dt = new DataTable();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            sda.Fill(dt);
            foreach(DataRow dr in dt.Rows)
            {
                CivilidLb.Text = dr["Civilid"].ToString();
                CivilnameLb.Text = dr["Civilname"].ToString();
                CiviladdLb.Text = dr["Civiladd"].ToString();
                CivilFatheridLb.Text = dr["CivilFatherid"].ToString();
                CivilFathernameLb.Text = dr["CivilFathername"].ToString();
                CivilDOBLb.Text = dr["CivilDOB"].ToString();
                CivilphoneLb.Text = dr["Civilphone"].ToString();
                CivilGenderLb.Text = dr["CivilGender"].ToString();
                CivilidLb.Visible = true;
                CivilnameLb.Visible = true; ;
                CiviladdLb.Visible = true; ;
                CivilFatheridLb.Visible = true; ;
                CivilFathernameLb.Visible = true; ;
                CivilDOBLb.Visible = true; ;
                CivilphoneLb.Visible = true; ;
                CivilGenderLb.Visible = true; ;
            }
            Con.Close();
        }

        private void Search_Load(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {
            fetchCivilData();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label11_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            if (printPreviewDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString("=======Civilian Summary=======", new Font("Times New Roman", 22, FontStyle.Bold), Brushes.Black, new Point(200));
            e.Graphics.DrawString("Civilian Id: " + CivilidLb.Text + "\t\t\t\tName: " + CivilnameLb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(10, 100));
            e.Graphics.DrawString("Address: " + CiviladdLb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(10, 160));
            e.Graphics.DrawString("Father's Id: " + CivilFatheridLb.Text + "\t\t\t\tFather's Name: " + CivilFathernameLb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(10, 220));
            e.Graphics.DrawString("Date of Birth: " + CivilDOBLb.Text + "\t\tPhone Number: " + CivilphoneLb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(10, 280));
            e.Graphics.DrawString("Gender: " + CivilGenderLb.Text, new Font("Times New Roman", 18, FontStyle.Regular), Brushes.Black, new Point(10, 340));
            e.Graphics.DrawString("=======CivilSoft=======", new Font("Times New Roman", 22, FontStyle.Bold), Brushes.Black, new Point(250, 400));
        }

        private void cross_MouseHover(object sender, EventArgs e)
        {
            cross.ForeColor = Color.Red;
        }

        private void cross_MouseLeave_1(object sender, EventArgs e)
        {
            cross.ForeColor = Color.GreenYellow;
        }
    }
}
