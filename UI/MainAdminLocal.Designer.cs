namespace UI
{
    partial class MainAdminLocal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminLocal));
            this.BOferta = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.BCambiarMenu = new System.Windows.Forms.Button();
            this.BCambioHorario = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BOferta
            // 
            this.BOferta.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BOferta.Location = new System.Drawing.Point(22, 55);
            this.BOferta.Name = "BOferta";
            this.BOferta.Size = new System.Drawing.Size(97, 23);
            this.BOferta.TabIndex = 0;
            this.BOferta.Text = "Set Sales";
            this.BOferta.UseVisualStyleBackColor = true;
            this.BOferta.Click += new System.EventHandler(this.button1_Click);
            // 
            // BExit
            // 
            this.BExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BExit.Location = new System.Drawing.Point(691, 415);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(97, 23);
            this.BExit.TabIndex = 2;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.button2_Click);
            // 
            // BCambiarMenu
            // 
            this.BCambiarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCambiarMenu.Location = new System.Drawing.Point(22, 84);
            this.BCambiarMenu.Name = "BCambiarMenu";
            this.BCambiarMenu.Size = new System.Drawing.Size(97, 23);
            this.BCambiarMenu.TabIndex = 3;
            this.BCambiarMenu.Text = "Change Menu";
            this.BCambiarMenu.UseVisualStyleBackColor = true;
            this.BCambiarMenu.Click += new System.EventHandler(this.BCambiarMenu_Click);
            // 
            // BCambioHorario
            // 
            this.BCambioHorario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCambioHorario.Location = new System.Drawing.Point(22, 113);
            this.BCambioHorario.Name = "BCambioHorario";
            this.BCambioHorario.Size = new System.Drawing.Size(97, 48);
            this.BCambioHorario.TabIndex = 4;
            this.BCambioHorario.Text = "Change opening and closing hours";
            this.BCambioHorario.UseVisualStyleBackColor = true;
            this.BCambioHorario.Click += new System.EventHandler(this.BCambioHorario_Click);
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Location = new System.Drawing.Point(320, 103);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(0, 13);
            this.Bienvenida.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 185);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainAdminLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(159, 234);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.BCambioHorario);
            this.Controls.Add(this.BCambiarMenu);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BOferta);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAdminLocal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainAdminLocal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BOferta;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BCambiarMenu;
        private System.Windows.Forms.Button BCambioHorario;
        private System.Windows.Forms.Label Bienvenida;
        private System.Windows.Forms.Button button1;
    }
}