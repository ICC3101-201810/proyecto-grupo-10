﻿namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.usersLabel = new System.Windows.Forms.Label();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.UsuarioIng = new System.Windows.Forms.TextBox();
            this.UsuarioCont = new System.Windows.Forms.TextBox();
            this.NewUser = new System.Windows.Forms.Button();
            this.Loginboton = new System.Windows.Forms.Button();
            this.BLoginAdmin = new System.Windows.Forms.Button();
            this.BAdminApp = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(153, 30);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(40, 13);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "USER:";
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Location = new System.Drawing.Point(127, 60);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(66, 13);
            this.PaswordLabel.TabIndex = 2;
            this.PaswordLabel.Text = "PASWORD:";
            // 
            // UsuarioIng
            // 
            this.UsuarioIng.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsuarioIng.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UsuarioIng.Location = new System.Drawing.Point(199, 30);
            this.UsuarioIng.Name = "UsuarioIng";
            this.UsuarioIng.Size = new System.Drawing.Size(157, 20);
            this.UsuarioIng.TabIndex = 3;
            this.UsuarioIng.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // UsuarioCont
            // 
            this.UsuarioCont.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsuarioCont.ForeColor = System.Drawing.SystemColors.InfoText;
            this.UsuarioCont.Location = new System.Drawing.Point(199, 56);
            this.UsuarioCont.Name = "UsuarioCont";
            this.UsuarioCont.Size = new System.Drawing.Size(157, 20);
            this.UsuarioCont.TabIndex = 4;
            this.UsuarioCont.UseSystemPasswordChar = true;
            this.UsuarioCont.TextChanged += new System.EventHandler(this.UsuarioCont_TextChanged);
            // 
            // NewUser
            // 
            this.NewUser.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.NewUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.NewUser.Location = new System.Drawing.Point(199, 256);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(100, 28);
            this.NewUser.TabIndex = 5;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = false;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Loginboton
            // 
            this.Loginboton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Loginboton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Loginboton.Location = new System.Drawing.Point(199, 96);
            this.Loginboton.Name = "Loginboton";
            this.Loginboton.Size = new System.Drawing.Size(100, 28);
            this.Loginboton.TabIndex = 6;
            this.Loginboton.Text = "Log In";
            this.Loginboton.UseVisualStyleBackColor = false;
            this.Loginboton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BLoginAdmin
            // 
            this.BLoginAdmin.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BLoginAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BLoginAdmin.Location = new System.Drawing.Point(199, 142);
            this.BLoginAdmin.Name = "BLoginAdmin";
            this.BLoginAdmin.Size = new System.Drawing.Size(100, 28);
            this.BLoginAdmin.TabIndex = 7;
            this.BLoginAdmin.Text = " Admin Log In ";
            this.BLoginAdmin.UseVisualStyleBackColor = false;
            this.BLoginAdmin.Click += new System.EventHandler(this.BLoginAdmin_Click);
            // 
            // BAdminApp
            // 
            this.BAdminApp.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BAdminApp.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAdminApp.Location = new System.Drawing.Point(199, 191);
            this.BAdminApp.Name = "BAdminApp";
            this.BAdminApp.Size = new System.Drawing.Size(100, 28);
            this.BAdminApp.TabIndex = 8;
            this.BAdminApp.Text = " Admin App Log In ";
            this.BAdminApp.UseVisualStyleBackColor = false;
            this.BAdminApp.Click += new System.EventHandler(this.BAdminApp_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Location = new System.Drawing.Point(422, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 28);
            this.button1.TabIndex = 9;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BAdminApp);
            this.Controls.Add(this.BLoginAdmin);
            this.Controls.Add(this.Loginboton);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.UsuarioCont);
            this.Controls.Add(this.UsuarioIng);
            this.Controls.Add(this.PaswordLabel);
            this.Controls.Add(this.usersLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log In";
            this.TransparencyKey = System.Drawing.Color.MediumTurquoise;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label usersLabel;
        private System.Windows.Forms.Label PaswordLabel;
        private System.Windows.Forms.TextBox UsuarioIng;
        private System.Windows.Forms.TextBox UsuarioCont;
        private System.Windows.Forms.Button NewUser;
        private System.Windows.Forms.Button Loginboton;
        private System.Windows.Forms.Button BLoginAdmin;
        private System.Windows.Forms.Button BAdminApp;
        private System.Windows.Forms.Button button1;
    }
}

