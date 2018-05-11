namespace UI
{
    partial class SetSales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetSales));
            this.BBack = new System.Windows.Forms.Button();
            this.CLocal = new System.Windows.Forms.ComboBox();
            this.CProducto = new System.Windows.Forms.ComboBox();
            this.LLocal = new System.Windows.Forms.Label();
            this.LProducto = new System.Windows.Forms.Label();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.LPrecios = new System.Windows.Forms.Label();
            this.BSale = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BBack
            // 
            this.BBack.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BBack.Location = new System.Drawing.Point(144, 251);
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
            this.CLocal.Location = new System.Drawing.Point(42, 59);
            this.CLocal.Name = "CLocal";
            this.CLocal.Size = new System.Drawing.Size(121, 21);
            this.CLocal.TabIndex = 1;
            this.CLocal.SelectedIndexChanged += new System.EventHandler(this.CLocal_SelectedIndexChanged);
            // 
            // CProducto
            // 
            this.CProducto.FormattingEnabled = true;
            this.CProducto.Location = new System.Drawing.Point(42, 109);
            this.CProducto.Name = "CProducto";
            this.CProducto.Size = new System.Drawing.Size(121, 21);
            this.CProducto.TabIndex = 2;
            // 
            // LLocal
            // 
            this.LLocal.AutoSize = true;
            this.LLocal.Location = new System.Drawing.Point(39, 43);
            this.LLocal.Name = "LLocal";
            this.LLocal.Size = new System.Drawing.Size(71, 13);
            this.LLocal.TabIndex = 3;
            this.LLocal.Text = "Choose Store";
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(39, 93);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(83, 13);
            this.LProducto.TabIndex = 4;
            this.LProducto.Text = "Choose Product";
            // 
            // TPrecio
            // 
            this.TPrecio.Location = new System.Drawing.Point(42, 159);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(121, 20);
            this.TPrecio.TabIndex = 5;
            // 
            // LPrecios
            // 
            this.LPrecios.AutoSize = true;
            this.LPrecios.Location = new System.Drawing.Point(39, 143);
            this.LPrecios.Name = "LPrecios";
            this.LPrecios.Size = new System.Drawing.Size(75, 13);
            this.LPrecios.TabIndex = 6;
            this.LPrecios.Text = "Set New Price";
            // 
            // BSale
            // 
            this.BSale.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BSale.Location = new System.Drawing.Point(42, 185);
            this.BSale.Name = "BSale";
            this.BSale.Size = new System.Drawing.Size(75, 23);
            this.BSale.TabIndex = 7;
            this.BSale.Text = "Set Sale";
            this.BSale.UseVisualStyleBackColor = true;
            this.BSale.Click += new System.EventHandler(this.BSale_Click);
            // 
            // SetSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(235, 290);
            this.Controls.Add(this.BSale);
            this.Controls.Add(this.LPrecios);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.LProducto);
            this.Controls.Add(this.LLocal);
            this.Controls.Add(this.CProducto);
            this.Controls.Add(this.CLocal);
            this.Controls.Add(this.BBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SetSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddSale";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.ComboBox CLocal;
        private System.Windows.Forms.ComboBox CProducto;
        private System.Windows.Forms.Label LLocal;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label LPrecios;
        private System.Windows.Forms.Button BSale;
    }
}