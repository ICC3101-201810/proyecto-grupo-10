namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAplicacion));
            this.CSesion = new System.Windows.Forms.Button();
            this.ANota = new System.Windows.Forms.Button();
            this.IPresupuesto = new System.Windows.Forms.Button();
            this.VLocales = new System.Windows.Forms.Button();
            this.RPedido = new System.Windows.Forms.Button();
            this.ASaldo = new System.Windows.Forms.Button();
            this.IBudget = new System.Windows.Forms.TextBox();
            this.ISaldo = new System.Windows.Forms.TextBox();
            this.Bienvenida = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CSesion
            // 
            this.CSesion.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.CSesion.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.CSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CSesion.Location = new System.Drawing.Point(151, 263);
            this.CSesion.Name = "CSesion";
            this.CSesion.Size = new System.Drawing.Size(75, 29);
            this.CSesion.TabIndex = 0;
            this.CSesion.Text = "Exit";
            this.CSesion.UseVisualStyleBackColor = true;
            this.CSesion.Click += new System.EventHandler(this.button1_Click);
            // 
            // ANota
            // 
            this.ANota.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.ANota.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ANota.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ANota.Location = new System.Drawing.Point(151, 217);
            this.ANota.Name = "ANota";
            this.ANota.Size = new System.Drawing.Size(75, 40);
            this.ANota.TabIndex = 1;
            this.ANota.Text = "Grade and Comments";
            this.ANota.UseCompatibleTextRendering = true;
            this.ANota.UseVisualStyleBackColor = true;
            this.ANota.Click += new System.EventHandler(this.ANota_Click);
            // 
            // IPresupuesto
            // 
            this.IPresupuesto.BackColor = System.Drawing.Color.Transparent;
            this.IPresupuesto.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.IPresupuesto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.IPresupuesto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IPresupuesto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.IPresupuesto.Location = new System.Drawing.Point(151, 84);
            this.IPresupuesto.Name = "IPresupuesto";
            this.IPresupuesto.Size = new System.Drawing.Size(75, 23);
            this.IPresupuesto.TabIndex = 2;
            this.IPresupuesto.Text = "See Options";
            this.IPresupuesto.UseVisualStyleBackColor = false;
            this.IPresupuesto.Click += new System.EventHandler(this.IPresupuesto_Click);
            // 
            // VLocales
            // 
            this.VLocales.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.VLocales.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.VLocales.ForeColor = System.Drawing.SystemColors.ControlText;
            this.VLocales.Location = new System.Drawing.Point(151, 113);
            this.VLocales.Name = "VLocales";
            this.VLocales.Size = new System.Drawing.Size(75, 23);
            this.VLocales.TabIndex = 3;
            this.VLocales.Text = "View Stores";
            this.VLocales.UseVisualStyleBackColor = true;
            this.VLocales.Click += new System.EventHandler(this.VLocales_Click);
            // 
            // RPedido
            // 
            this.RPedido.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.RPedido.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.RPedido.ForeColor = System.Drawing.SystemColors.ControlText;
            this.RPedido.Location = new System.Drawing.Point(151, 142);
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
            this.ASaldo.FlatAppearance.BorderColor = System.Drawing.SystemColors.InactiveBorder;
            this.ASaldo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ASaldo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ASaldo.Location = new System.Drawing.Point(151, 188);
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
            this.IBudget.Location = new System.Drawing.Point(36, 84);
            this.IBudget.Name = "IBudget";
            this.IBudget.Size = new System.Drawing.Size(109, 20);
            this.IBudget.TabIndex = 6;
            this.IBudget.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.IBudget.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ISaldo
            // 
            this.ISaldo.Location = new System.Drawing.Point(36, 191);
            this.ISaldo.Name = "ISaldo";
            this.ISaldo.Size = new System.Drawing.Size(109, 20);
            this.ISaldo.TabIndex = 7;
            this.ISaldo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Bienvenida
            // 
            this.Bienvenida.AutoSize = true;
            this.Bienvenida.Location = new System.Drawing.Point(33, 40);
            this.Bienvenida.Name = "Bienvenida";
            this.Bienvenida.Size = new System.Drawing.Size(0, 13);
            this.Bienvenida.TabIndex = 8;
            this.Bienvenida.Click += new System.EventHandler(this.Bienvenida_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(33, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Budget";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(33, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Money";
            // 
            // MainAplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(282, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Bienvenida);
            this.Controls.Add(this.ISaldo);
            this.Controls.Add(this.IBudget);
            this.Controls.Add(this.ASaldo);
            this.Controls.Add(this.RPedido);
            this.Controls.Add(this.VLocales);
            this.Controls.Add(this.IPresupuesto);
            this.Controls.Add(this.ANota);
            this.Controls.Add(this.CSesion);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}