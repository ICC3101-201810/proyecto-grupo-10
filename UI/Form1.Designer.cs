namespace UI
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
            this.usersLabel = new System.Windows.Forms.Label();
            this.PaswordLabel = new System.Windows.Forms.Label();
            this.UsuarioIng = new System.Windows.Forms.TextBox();
            this.UsuarioCont = new System.Windows.Forms.TextBox();
            this.NewUser = new System.Windows.Forms.Button();
            this.Loginboton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // usersLabel
            // 
            this.usersLabel.AutoSize = true;
            this.usersLabel.Location = new System.Drawing.Point(153, 98);
            this.usersLabel.Name = "usersLabel";
            this.usersLabel.Size = new System.Drawing.Size(40, 13);
            this.usersLabel.TabIndex = 1;
            this.usersLabel.Text = "USER:";
            // 
            // PaswordLabel
            // 
            this.PaswordLabel.AutoSize = true;
            this.PaswordLabel.Location = new System.Drawing.Point(127, 128);
            this.PaswordLabel.Name = "PaswordLabel";
            this.PaswordLabel.Size = new System.Drawing.Size(66, 13);
            this.PaswordLabel.TabIndex = 2;
            this.PaswordLabel.Text = "PASWORD:";
            this.PaswordLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // UsuarioIng
            // 
            this.UsuarioIng.Location = new System.Drawing.Point(199, 98);
            this.UsuarioIng.Name = "UsuarioIng";
            this.UsuarioIng.Size = new System.Drawing.Size(157, 20);
            this.UsuarioIng.TabIndex = 3;
            this.UsuarioIng.TextChanged += new System.EventHandler(this.usuario_TextChanged);
            // 
            // UsuarioCont
            // 
            this.UsuarioCont.Location = new System.Drawing.Point(199, 124);
            this.UsuarioCont.Name = "UsuarioCont";
            this.UsuarioCont.Size = new System.Drawing.Size(157, 20);
            this.UsuarioCont.TabIndex = 4;
            this.UsuarioCont.TextChanged += new System.EventHandler(this.UsuarioCont_TextChanged);
            // 
            // NewUser
            // 
            this.NewUser.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.NewUser.Location = new System.Drawing.Point(199, 198);
            this.NewUser.Name = "NewUser";
            this.NewUser.Size = new System.Drawing.Size(100, 28);
            this.NewUser.TabIndex = 5;
            this.NewUser.Text = "New User";
            this.NewUser.UseVisualStyleBackColor = false;
            this.NewUser.Click += new System.EventHandler(this.NewUser_Click);
            // 
            // Loginboton
            // 
            this.Loginboton.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Loginboton.Location = new System.Drawing.Point(199, 164);
            this.Loginboton.Name = "Loginboton";
            this.Loginboton.Size = new System.Drawing.Size(100, 28);
            this.Loginboton.TabIndex = 6;
            this.Loginboton.Text = "Log In";
            this.Loginboton.UseVisualStyleBackColor = false;
            this.Loginboton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(534, 311);
            this.Controls.Add(this.Loginboton);
            this.Controls.Add(this.NewUser);
            this.Controls.Add(this.UsuarioCont);
            this.Controls.Add(this.UsuarioIng);
            this.Controls.Add(this.PaswordLabel);
            this.Controls.Add(this.usersLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.White;
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
    }
}

