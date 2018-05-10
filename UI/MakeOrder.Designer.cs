namespace UI
{
    partial class MakeOrder
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
            this.BBack = new System.Windows.Forms.Button();
            this.CLocal = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.LLocal = new System.Windows.Forms.Label();
            this.CProducto = new System.Windows.Forms.Label();
            this.BCredito = new System.Windows.Forms.Button();
            this.BTienda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(695, 402);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 0;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // CLocal
            // 
            this.CLocal.FormattingEnabled = true;
            this.CLocal.Location = new System.Drawing.Point(83, 79);
            this.CLocal.Name = "CLocal";
            this.CLocal.Size = new System.Drawing.Size(156, 21);
            this.CLocal.TabIndex = 1;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(83, 133);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(156, 21);
            this.comboBox2.TabIndex = 2;
            // 
            // LLocal
            // 
            this.LLocal.AutoSize = true;
            this.LLocal.Location = new System.Drawing.Point(80, 63);
            this.LLocal.Name = "LLocal";
            this.LLocal.Size = new System.Drawing.Size(72, 13);
            this.LLocal.TabIndex = 3;
            this.LLocal.Text = "Choose Local";
            this.LLocal.Click += new System.EventHandler(this.label1_Click);
            // 
            // CProducto
            // 
            this.CProducto.AutoSize = true;
            this.CProducto.Location = new System.Drawing.Point(80, 117);
            this.CProducto.Name = "CProducto";
            this.CProducto.Size = new System.Drawing.Size(83, 13);
            this.CProducto.TabIndex = 4;
            this.CProducto.Text = "Choose Product";
            // 
            // BCredito
            // 
            this.BCredito.Location = new System.Drawing.Point(83, 179);
            this.BCredito.Name = "BCredito";
            this.BCredito.Size = new System.Drawing.Size(75, 23);
            this.BCredito.TabIndex = 5;
            this.BCredito.Text = "Credit ";
            this.BCredito.UseVisualStyleBackColor = true;
            this.BCredito.Click += new System.EventHandler(this.BCredito_Click);
            // 
            // BTienda
            // 
            this.BTienda.Location = new System.Drawing.Point(164, 179);
            this.BTienda.Name = "BTienda";
            this.BTienda.Size = new System.Drawing.Size(75, 23);
            this.BTienda.TabIndex = 6;
            this.BTienda.Text = "At Store";
            this.BTienda.UseVisualStyleBackColor = true;
            this.BTienda.Click += new System.EventHandler(this.BTienda_Click);
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTienda);
            this.Controls.Add(this.BCredito);
            this.Controls.Add(this.CProducto);
            this.Controls.Add(this.LLocal);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.CLocal);
            this.Controls.Add(this.BBack);
            this.Name = "MakeOrder";
            this.Text = "MakeOrder";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.ComboBox CLocal;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label LLocal;
        private System.Windows.Forms.Label CProducto;
        private System.Windows.Forms.Button BCredito;
        private System.Windows.Forms.Button BTienda;
    }
}