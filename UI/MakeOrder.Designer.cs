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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MakeOrder));
            this.BBack = new System.Windows.Forms.Button();
            this.CLocal = new System.Windows.Forms.ComboBox();
            this.CProducto = new System.Windows.Forms.ComboBox();
            this.LLocal = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.BCredito = new System.Windows.Forms.Button();
            this.BTienda = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ICantidad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BBack
            // 
            this.BBack.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBack.Location = new System.Drawing.Point(158, 304);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 32);
            this.BBack.TabIndex = 0;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // CLocal
            // 
            this.CLocal.FormattingEnabled = true;
            this.CLocal.Location = new System.Drawing.Point(77, 85);
            this.CLocal.Name = "CLocal";
            this.CLocal.Size = new System.Drawing.Size(156, 21);
            this.CLocal.TabIndex = 1;
            this.CLocal.Text = "Choose Store";
            this.CLocal.SelectedIndexChanged += new System.EventHandler(this.CLocal_SelectedIndexChanged);
            // 
            // CProducto
            // 
            this.CProducto.FormattingEnabled = true;
            this.CProducto.Location = new System.Drawing.Point(77, 139);
            this.CProducto.Name = "CProducto";
            this.CProducto.Size = new System.Drawing.Size(156, 21);
            this.CProducto.TabIndex = 2;
            // 
            // LLocal
            // 
            this.LLocal.AutoSize = true;
            this.LLocal.Location = new System.Drawing.Point(74, 69);
            this.LLocal.Name = "LLocal";
            this.LLocal.Size = new System.Drawing.Size(72, 13);
            this.LLocal.TabIndex = 3;
            this.LLocal.Text = "Choose Local";
            this.LLocal.Click += new System.EventHandler(this.label1_Click);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(74, 123);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(83, 13);
            this.LProducto.TabIndex = 4;
            this.LProducto.Text = "Choose Product";
            // 
            // BCredito
            // 
            this.BCredito.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BCredito.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BCredito.Location = new System.Drawing.Point(77, 230);
            this.BCredito.Name = "BCredito";
            this.BCredito.Size = new System.Drawing.Size(75, 23);
            this.BCredito.TabIndex = 5;
            this.BCredito.Text = "Credit ";
            this.BCredito.UseVisualStyleBackColor = true;
            this.BCredito.Click += new System.EventHandler(this.BCredito_Click);
            // 
            // BTienda
            // 
            this.BTienda.FlatAppearance.BorderColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BTienda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BTienda.Location = new System.Drawing.Point(158, 230);
            this.BTienda.Name = "BTienda";
            this.BTienda.Size = new System.Drawing.Size(75, 23);
            this.BTienda.TabIndex = 6;
            this.BTienda.Text = "At Store";
            this.BTienda.UseVisualStyleBackColor = true;
            this.BTienda.Click += new System.EventHandler(this.BTienda_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(74, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Amount";
            // 
            // ICantidad
            // 
            this.ICantidad.Location = new System.Drawing.Point(77, 186);
            this.ICantidad.Name = "ICantidad";
            this.ICantidad.Size = new System.Drawing.Size(100, 20);
            this.ICantidad.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(74, 214);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Payment Method";
            // 
            // MakeOrder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(300, 357);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ICantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTienda);
            this.Controls.Add(this.BCredito);
            this.Controls.Add(this.LProducto);
            this.Controls.Add(this.LLocal);
            this.Controls.Add(this.CProducto);
            this.Controls.Add(this.CLocal);
            this.Controls.Add(this.BBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MakeOrder";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MakeOrder";
            this.Load += new System.EventHandler(this.MakeOrder_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.ComboBox CLocal;
        private System.Windows.Forms.ComboBox CProducto;
        private System.Windows.Forms.Label LLocal;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Button BCredito;
        private System.Windows.Forms.Button BTienda;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ICantidad;
        private System.Windows.Forms.Label label2;
    }
}