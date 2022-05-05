namespace Olmp
{
    partial class SignUp
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
            this.panellLogo = new System.Windows.Forms.Panel();
            this.tb_passwordr = new System.Windows.Forms.TextBox();
            this.lbl_error = new System.Windows.Forms.Label();
            this.btn_reg = new System.Windows.Forms.Button();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btn_sigin = new System.Windows.Forms.Button();
            this.btn_main = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.panellLogo.SuspendLayout();
            this.panelMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // panellLogo
            // 
            this.panellLogo.Controls.Add(this.tb_passwordr);
            this.panellLogo.Controls.Add(this.lbl_error);
            this.panellLogo.Controls.Add(this.btn_reg);
            this.panellLogo.Controls.Add(this.tb_password);
            this.panellLogo.Controls.Add(this.tb_email);
            this.panellLogo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panellLogo.Location = new System.Drawing.Point(147, 0);
            this.panellLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panellLogo.Name = "panellLogo";
            this.panellLogo.Size = new System.Drawing.Size(386, 292);
            this.panellLogo.TabIndex = 3;
            // 
            // tb_passwordr
            // 
            this.tb_passwordr.Location = new System.Drawing.Point(32, 149);
            this.tb_passwordr.Margin = new System.Windows.Forms.Padding(2);
            this.tb_passwordr.Multiline = true;
            this.tb_passwordr.Name = "tb_passwordr";
            this.tb_passwordr.PasswordChar = '*';
            this.tb_passwordr.Size = new System.Drawing.Size(319, 29);
            this.tb_passwordr.TabIndex = 7;
            // 
            // lbl_error
            // 
            this.lbl_error.AutoSize = true;
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Location = new System.Drawing.Point(167, 202);
            this.lbl_error.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(35, 13);
            this.lbl_error.TabIndex = 6;
            this.lbl_error.Text = "label1";
            this.lbl_error.Visible = false;
            // 
            // btn_reg
            // 
            this.btn_reg.Location = new System.Drawing.Point(123, 226);
            this.btn_reg.Margin = new System.Windows.Forms.Padding(2);
            this.btn_reg.Name = "btn_reg";
            this.btn_reg.Size = new System.Drawing.Size(130, 49);
            this.btn_reg.TabIndex = 5;
            this.btn_reg.Text = "Регистрация";
            this.btn_reg.UseVisualStyleBackColor = true;
            this.btn_reg.Click += new System.EventHandler(this.btn_reg_Click);
            // 
            // tb_password
            // 
            this.tb_password.Location = new System.Drawing.Point(32, 103);
            this.tb_password.Margin = new System.Windows.Forms.Padding(2);
            this.tb_password.Multiline = true;
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(319, 29);
            this.tb_password.TabIndex = 1;
            // 
            // tb_email
            // 
            this.tb_email.Location = new System.Drawing.Point(32, 52);
            this.tb_email.Margin = new System.Windows.Forms.Padding(2);
            this.tb_email.Multiline = true;
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(319, 29);
            this.tb_email.TabIndex = 0;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.btn_sigin);
            this.panelMenu.Controls.Add(this.btn_main);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Margin = new System.Windows.Forms.Padding(2);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(147, 292);
            this.panelMenu.TabIndex = 2;
            // 
            // btn_sigin
            // 
            this.btn_sigin.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_sigin.FlatAppearance.BorderSize = 0;
            this.btn_sigin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_sigin.ForeColor = System.Drawing.Color.White;
            this.btn_sigin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sigin.Location = new System.Drawing.Point(0, 91);
            this.btn_sigin.Margin = new System.Windows.Forms.Padding(2);
            this.btn_sigin.Name = "btn_sigin";
            this.btn_sigin.Size = new System.Drawing.Size(147, 39);
            this.btn_sigin.TabIndex = 5;
            this.btn_sigin.Text = "Войти";
            this.btn_sigin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_sigin.UseVisualStyleBackColor = true;
            this.btn_sigin.Click += new System.EventHandler(this.btn_sigin_Click);
            // 
            // btn_main
            // 
            this.btn_main.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_main.FlatAppearance.BorderSize = 0;
            this.btn_main.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_main.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.btn_main.ForeColor = System.Drawing.Color.White;
            this.btn_main.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_main.Location = new System.Drawing.Point(0, 52);
            this.btn_main.Margin = new System.Windows.Forms.Padding(2);
            this.btn_main.Name = "btn_main";
            this.btn_main.Size = new System.Drawing.Size(147, 39);
            this.btn_main.TabIndex = 0;
            this.btn_main.Text = "На главную";
            this.btn_main.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_main.UseVisualStyleBackColor = true;
            this.btn_main.Click += new System.EventHandler(this.btn_main_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(2);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(147, 52);
            this.panelLogo.TabIndex = 1;
            // 
            // SignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(533, 292);
            this.Controls.Add(this.panellLogo);
            this.Controls.Add(this.panelMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "SignUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SignUp";
            this.panellLogo.ResumeLayout(false);
            this.panellLogo.PerformLayout();
            this.panelMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panellLogo;
        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btn_main;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Button btn_reg;
        private System.Windows.Forms.Label lbl_error;
        private System.Windows.Forms.TextBox tb_passwordr;
        private System.Windows.Forms.Button btn_sigin;
    }
}