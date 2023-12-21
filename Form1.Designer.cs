namespace Project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressCircle = new Guna.UI.WinForms.GunaCircleProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(152, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(243, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Civilian Mangement System";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.ForestGreen;
            this.label2.Location = new System.Drawing.Point(178, 227);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(169, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Developed By CASE Students";
            // 
            // progressCircle
            // 
            this.progressCircle.AnimationSpeed = 0.6F;
            this.progressCircle.BackColor = System.Drawing.Color.Transparent;
            this.progressCircle.BaseColor = System.Drawing.Color.Transparent;
            this.progressCircle.IdleColor = System.Drawing.Color.Gainsboro;
            this.progressCircle.IdleOffset = 20;
            this.progressCircle.IdleThickness = 15;
            this.progressCircle.Image = null;
            this.progressCircle.ImageSize = new System.Drawing.Size(52, 52);
            this.progressCircle.Location = new System.Drawing.Point(177, 39);
            this.progressCircle.Name = "progressCircle";
            this.progressCircle.ProgressMaxColor = System.Drawing.Color.DarkGreen;
            this.progressCircle.ProgressMinColor = System.Drawing.Color.Green;
            this.progressCircle.ProgressOffset = 20;
            this.progressCircle.ProgressThickness = 15;
            this.progressCircle.Size = new System.Drawing.Size(167, 160);
            this.progressCircle.TabIndex = 2;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(523, 251);
            this.Controls.Add(this.progressCircle);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaCircleProgressBar progressCircle;
        private System.Windows.Forms.Timer timer1;
    }
}

