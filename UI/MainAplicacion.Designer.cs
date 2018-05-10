﻿namespace UI
{
    partial class MainAplicacion
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
            this.CSesion = new System.Windows.Forms.Button();
            this.ANota = new System.Windows.Forms.Button();
            this.IPresupuesto = new System.Windows.Forms.Button();
            this.VLocales = new System.Windows.Forms.Button();
            this.RPedido = new System.Windows.Forms.Button();
            this.ASaldo = new System.Windows.Forms.Button();
            this.IBudget = new System.Windows.Forms.TextBox();
            this.ISaldo = new System.Windows.Forms.TextBox();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CSesion
            // 
            this.CSesion.Location = new System.Drawing.Point(707, 409);
            this.CSesion.Name = "CSesion";
            this.CSesion.Size = new System.Drawing.Size(81, 29);
            this.CSesion.TabIndex = 0;
            this.CSesion.Text = "Exit";
            this.CSesion.UseVisualStyleBackColor = true;
            this.CSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // ANota
            // 
            this.ANota.Location = new System.Drawing.Point(330, 259);
            this.ANota.Name = "ANota";
            this.ANota.Size = new System.Drawing.Size(75, 31);
            this.ANota.TabIndex = 1;
            this.ANota.Text = "Grade and Comments";
            this.ANota.UseCompatibleTextRendering = true;
            this.ANota.UseVisualStyleBackColor = true;
            this.ANota.Click += new System.EventHandler(this.ANota_Click);
            // 
            // IPresupuesto
            // 
            this.IPresupuesto.Location = new System.Drawing.Point(330, 126);
            this.IPresupuesto.Name = "IPresupuesto";
            this.IPresupuesto.Size = new System.Drawing.Size(75, 23);
            this.IPresupuesto.TabIndex = 2;
            this.IPresupuesto.Text = "See Options";
            this.IPresupuesto.UseVisualStyleBackColor = true;
            this.IPresupuesto.Click += new System.EventHandler(this.IPresupuesto_Click);
            // 
            // VLocales
            // 
            this.VLocales.Location = new System.Drawing.Point(330, 155);
            this.VLocales.Name = "VLocales";
            this.VLocales.Size = new System.Drawing.Size(75, 23);
            this.VLocales.TabIndex = 3;
            this.VLocales.Text = "View Stores";
            this.VLocales.UseVisualStyleBackColor = true;
            this.VLocales.Click += new System.EventHandler(this.VLocales_Click);
            // 
            // RPedido
            // 
            this.RPedido.Location = new System.Drawing.Point(330, 184);
            this.RPedido.Name = "RPedido";
            this.RPedido.Size = new System.Drawing.Size(75, 40);
            this.RPedido.TabIndex = 4;
            this.RPedido.Text = "Make an Order";
            this.RPedido.UseCompatibleTextRendering = true;
            this.RPedido.UseVisualStyleBackColor = true;
            this.RPedido.Click += new System.EventHandler(this.RPedido_Click);
            // 
            // ASaldo
            // 
            this.ASaldo.Location = new System.Drawing.Point(330, 230);
            this.ASaldo.Name = "ASaldo";
            this.ASaldo.Size = new System.Drawing.Size(75, 23);
            this.ASaldo.TabIndex = 5;
            this.ASaldo.Text = "Add Credit";
            this.ASaldo.UseVisualStyleBackColor = true;
            this.ASaldo.Click += new System.EventHandler(this.ASaldo_Click);
            // 
            // IBudget
            // 
            this.IBudget.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.IBudget.Location = new System.Drawing.Point(215, 126);
            this.IBudget.Name = "IBudget";
            this.IBudget.Size = new System.Drawing.Size(109, 20);
            this.IBudget.TabIndex = 6;
            this.IBudget.Text = "Budget";
            this.IBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IBudget.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ISaldo
            // 
            this.ISaldo.Location = new System.Drawing.Point(215, 233);
            this.ISaldo.Name = "ISaldo";
            this.ISaldo.Size = new System.Drawing.Size(109, 20);
            this.ISaldo.TabIndex = 7;
            this.ISaldo.Text = "Money";
            this.ISaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Location = new System.Drawing.Point(212, 80);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(0, 13);
            this.Bienvenida.TabIndex = 8;
            this.Bienvenida.Click += new System.EventHandler(this.Bienvenida_Click);
            // 
            // MainAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.ISaldo);
            this.Controls.Add(this.IBudget);
            this.Controls.Add(this.ASaldo);
            this.Controls.Add(this.RPedido);
            this.Controls.Add(this.VLocales);
            this.Controls.Add(this.IPresupuesto);
            this.Controls.Add(this.ANota);
            this.Controls.Add(this.CSesion);
            this.Name = "MainAplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.MainAplicacion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CSesion;
        private System.Windows.Forms.Button ANota;
        private System.Windows.Forms.Button IPresupuesto;
        private System.Windows.Forms.Button VLocales;
        private System.Windows.Forms.Button RPedido;
        private System.Windows.Forms.Button ASaldo;
        private System.Windows.Forms.TextBox IBudget;
        private System.Windows.Forms.TextBox ISaldo;
        private System.Windows.Forms.Label Bienvenida;
    }
}