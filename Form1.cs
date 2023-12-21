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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int startPoint = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            startPoint += 3;
            progressCircle.Value = startPoint;
            if(progressCircle.Value >= 100)
            {
                progressCircle.Value = 0;
                timer1.Stop();
                login log = new login();
                log.Show();
                this.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
