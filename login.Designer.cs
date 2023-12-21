namespace Project
{
    partial class login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(login));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.UseridTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PasswordTb = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginbt = new System.Windows.Forms.Button();
            this.exitbt = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.GreenYellow;
            this.label1.Location = new System.Drawing.Point(373, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "CivilSoft";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(113, 59);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // UseridTb
            // 
            this.UseridTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.UseridTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.UseridTb.BackColor = System.Drawing.Color.DarkGray;
            this.UseridTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.UseridTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UseridTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UseridTb.ForeColor = System.Drawing.Color.Black;
            this.UseridTb.HintForeColor = System.Drawing.Color.Empty;
            this.UseridTb.HintText = "";
            this.UseridTb.isPassword = false;
            this.UseridTb.LineFocusedColor = System.Drawing.Color.LightGreen;
            this.UseridTb.LineIdleColor = System.Drawing.Color.GreenYellow;
            this.UseridTb.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.UseridTb.LineThickness = 4;
            this.UseridTb.Location = new System.Drawing.Point(248, 88);
            this.UseridTb.Margin = new System.Windows.Forms.Padding(5);
            this.UseridTb.MaxLength = 32767;
            this.UseridTb.Name = "UseridTb";
            this.UseridTb.Size = new System.Drawing.Size(178, 35);
            this.UseridTb.TabIndex = 3;
            this.UseridTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.GreenYellow;
            this.label2.Location = new System.Drawing.Point(144, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "User ID:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.GreenYellow;
            this.label3.Location = new System.Drawing.Point(144, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 23);
            this.label3.TabIndex = 6;
            this.label3.Text = "Password:";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordTb
            // 
            this.PasswordTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.PasswordTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.PasswordTb.BackColor = System.Drawing.Color.DarkGray;
            this.PasswordTb.characterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.PasswordTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PasswordTb.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasswordTb.ForeColor = System.Drawing.Color.Black;
            this.PasswordTb.HintForeColor = System.Drawing.Color.Empty;
            this.PasswordTb.HintText = "";
            this.PasswordTb.isPassword = true;
            this.PasswordTb.LineFocusedColor = System.Drawing.Color.LightGreen;
            this.PasswordTb.LineIdleColor = System.Drawing.Color.GreenYellow;
            this.PasswordTb.LineMouseHoverColor = System.Drawing.Color.LightGreen;
            this.PasswordTb.LineThickness = 4;
            this.PasswordTb.Location = new System.Drawing.Point(248, 132);
            this.PasswordTb.Margin = new System.Windows.Forms.Padding(5);
            this.PasswordTb.MaxLength = 32767;
            this.PasswordTb.Name = "PasswordTb";
            this.PasswordTb.Size = new System.Drawing.Size(178, 35);
            this.PasswordTb.TabIndex = 5;
            this.PasswordTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // loginbt
            // 
            this.loginbt.BackColor = System.Drawing.Color.LightGray;
            this.loginbt.FlatAppearance.BorderSize = 0;
            this.loginbt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbt.ForeColor = System.Drawing.Color.Green;
            this.loginbt.Location = new System.Drawing.Point(148, 194);
            this.loginbt.Name = "loginbt";
            this.loginbt.Size = new System.Drawing.Size(105, 33);
            this.loginbt.TabIndex = 7;
            this.loginbt.Text = "Login";
            this.loginbt.UseVisualStyleBackColor = false;
            this.loginbt.Click += new System.EventHandler(this.loginbt_Click);
            this.loginbt.MouseLeave += new System.EventHandler(this.loginbt_MouseLeave);
            this.loginbt.MouseHover += new System.EventHandler(this.loginbt_MouseHover);
            // 
            // exitbt
            // 
            this.exitbt.FlatAppearance.BorderSize = 0;
            this.exitbt.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitbt.ForeColor = System.Drawing.Color.Green;
            this.exitbt.Location = new System.Drawing.Point(321, 194);
            this.exitbt.Name = "exitbt";
            this.exitbt.Size = new System.Drawing.Size(105, 33);
            this.exitbt.TabIndex = 8;
            this.exitbt.Text = "Exit";
            this.exitbt.UseVisualStyleBackColor = true;
            this.exitbt.Click += new System.EventHandler(this.exitbt_Click);
            this.exitbt.MouseLeave += new System.EventHandler(this.exitbt_MouseLeave);
            this.exitbt.MouseHover += new System.EventHandler(this.exitbt_MouseHover);
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(472, 261);
            this.Controls.Add(this.exitbt);
            this.Controls.Add(this.loginbt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PasswordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.UseridTb);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UseridTb;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PasswordTb;
        private System.Windows.Forms.Button loginbt;
        private System.Windows.Forms.Button exitbt;
    }
}