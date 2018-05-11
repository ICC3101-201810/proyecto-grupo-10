﻿namespace UI
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
            this.BNuevaOferta = new System.Windows.Forms.Button();
            this.BQuitarOferta = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.BCambiarMenu = new System.Windows.Forms.Button();
            this.BCambioHorario = new System.Windows.Forms.Button();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BNuevaOferta
            // 
            this.BNuevaOferta.Location = new System.Drawing.Point(323, 143);
            this.BNuevaOferta.Name = "BNuevaOferta";
            this.BNuevaOferta.Size = new System.Drawing.Size(97, 23);
            this.BNuevaOferta.TabIndex = 0;
            this.BNuevaOferta.Text = "Add Sale";
            this.BNuevaOferta.UseVisualStyleBackColor = true;
            this.BNuevaOferta.Click += new System.EventHandler(this.button1_Click);
            // 
            // BQuitarOferta
            // 
            this.BQuitarOferta.Location = new System.Drawing.Point(323, 172);
            this.BQuitarOferta.Name = "BQuitarOferta";
            this.BQuitarOferta.Size = new System.Drawing.Size(97, 23);
            this.BQuitarOferta.TabIndex = 1;
            this.BQuitarOferta.Text = "Remove Sale";
            this.BQuitarOferta.UseCompatibleTextRendering = true;
            this.BQuitarOferta.UseVisualStyleBackColor = true;
            // 
            // BExit
            // 
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
            this.BCambiarMenu.Location = new System.Drawing.Point(323, 201);
            this.BCambiarMenu.Name = "BCambiarMenu";
            this.BCambiarMenu.Size = new System.Drawing.Size(97, 23);
            this.BCambiarMenu.TabIndex = 3;
            this.BCambiarMenu.Text = "Change Menu";
            this.BCambiarMenu.UseVisualStyleBackColor = true;
            // 
            // BCambioHorario
            // 
            this.BCambioHorario.Location = new System.Drawing.Point(323, 230);
            this.BCambioHorario.Name = "BCambioHorario";
            this.BCambioHorario.Size = new System.Drawing.Size(97, 48);
            this.BCambioHorario.TabIndex = 4;
            this.BCambioHorario.Text = "Change opening and closing hours";
            this.BCambioHorario.UseVisualStyleBackColor = true;
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Location = new System.Drawing.Point(320, 103);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(0, 13);
            this.Bienvenida.TabIndex = 5;
            // 
            // MainAdminLocal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.BCambioHorario);
            this.Controls.Add(this.BCambiarMenu);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BQuitarOferta);
            this.Controls.Add(this.BNuevaOferta);
            this.Name = "MainAdminLocal";
            this.Text = "MainAdminLocal";
            this.Load += new System.EventHandler(this.MainAdminLocal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BNuevaOferta;
        private System.Windows.Forms.Button BQuitarOferta;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.Button BCambiarMenu;
        private System.Windows.Forms.Button BCambioHorario;
        private System.Windows.Forms.Label Bienvenida;
    }
}