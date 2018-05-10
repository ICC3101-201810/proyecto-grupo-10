namespace UI
{
    partial class ChangeMenu
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
            this.LProducto = new System.Windows.Forms.Label();
            this.LLocal = new System.Windows.Forms.Label();
            this.CProducto = new System.Windows.Forms.ComboBox();
            this.CLocal = new System.Windows.Forms.ComboBox();
            this.LRemover = new System.Windows.Forms.Label();
            this.Remove = new System.Windows.Forms.Button();
            this.BAdd = new System.Windows.Forms.Button();
            this.LAdd = new System.Windows.Forms.Label();
            this.LProducto2 = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TPrecio = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.LStock = new System.Windows.Forms.Label();
            this.TStock = new System.Windows.Forms.TextBox();
            this.LId = new System.Windows.Forms.Label();
            this.TId = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(713, 415);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 0;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // LProducto
            // 
            this.LProducto.AutoSize = true;
            this.LProducto.Location = new System.Drawing.Point(337, 173);
            this.LProducto.Name = "LProducto";
            this.LProducto.Size = new System.Drawing.Size(83, 13);
            this.LProducto.TabIndex = 8;
            this.LProducto.Text = "Choose Product";
            // 
            // LLocal
            // 
            this.LLocal.AutoSize = true;
            this.LLocal.Location = new System.Drawing.Point(182, 148);
            this.LLocal.Name = "LLocal";
            this.LLocal.Size = new System.Drawing.Size(71, 13);
            this.LLocal.TabIndex = 7;
            this.LLocal.Text = "Choose Store";
            // 
            // CProducto
            // 
            this.CProducto.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CProducto.FormattingEnabled = true;
            this.CProducto.Location = new System.Drawing.Point(340, 189);
            this.CProducto.Name = "CProducto";
            this.CProducto.Size = new System.Drawing.Size(121, 21);
            this.CProducto.TabIndex = 6;
            // 
            // CLocal
            // 
            this.CLocal.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.CLocal.FormattingEnabled = true;
            this.CLocal.Location = new System.Drawing.Point(185, 164);
            this.CLocal.Name = "CLocal";
            this.CLocal.Size = new System.Drawing.Size(121, 21);
            this.CLocal.TabIndex = 5;
            // 
            // LRemover
            // 
            this.LRemover.AutoSize = true;
            this.LRemover.Location = new System.Drawing.Point(337, 148);
            this.LRemover.Name = "LRemover";
            this.LRemover.Size = new System.Drawing.Size(106, 13);
            this.LRemover.TabIndex = 9;
            this.LRemover.Text = "To Remove Product:";
            this.LRemover.Click += new System.EventHandler(this.label1_Click);
            // 
            // Remove
            // 
            this.Remove.Location = new System.Drawing.Point(340, 225);
            this.Remove.Name = "Remove";
            this.Remove.Size = new System.Drawing.Size(121, 23);
            this.Remove.TabIndex = 10;
            this.Remove.Text = "Remove";
            this.Remove.UseVisualStyleBackColor = true;
            this.Remove.Click += new System.EventHandler(this.Remove_Click);
            // 
            // BAdd
            // 
            this.BAdd.Location = new System.Drawing.Point(489, 368);
            this.BAdd.Name = "BAdd";
            this.BAdd.Size = new System.Drawing.Size(121, 23);
            this.BAdd.TabIndex = 14;
            this.BAdd.Text = "Add";
            this.BAdd.UseVisualStyleBackColor = true;
            this.BAdd.Click += new System.EventHandler(this.BAdd_Click);
            // 
            // LAdd
            // 
            this.LAdd.AutoSize = true;
            this.LAdd.Location = new System.Drawing.Point(486, 148);
            this.LAdd.Name = "LAdd";
            this.LAdd.Size = new System.Drawing.Size(85, 13);
            this.LAdd.TabIndex = 13;
            this.LAdd.Text = "To Add Product:";
            // 
            // LProducto2
            // 
            this.LProducto2.AutoSize = true;
            this.LProducto2.Location = new System.Drawing.Point(486, 173);
            this.LProducto2.Name = "LProducto2";
            this.LProducto2.Size = new System.Drawing.Size(38, 13);
            this.LProducto2.TabIndex = 12;
            this.LProducto2.Text = "Name:";
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TNombre.Location = new System.Drawing.Point(489, 189);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(100, 20);
            this.TNombre.TabIndex = 15;
            // 
            // TPrecio
            // 
            this.TPrecio.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TPrecio.Location = new System.Drawing.Point(489, 232);
            this.TPrecio.Name = "TPrecio";
            this.TPrecio.Size = new System.Drawing.Size(100, 20);
            this.TPrecio.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(489, 216);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Price:";
            // 
            // LStock
            // 
            this.LStock.AutoSize = true;
            this.LStock.Location = new System.Drawing.Point(489, 266);
            this.LStock.Name = "LStock";
            this.LStock.Size = new System.Drawing.Size(38, 13);
            this.LStock.TabIndex = 19;
            this.LStock.Text = "Stock:";
            // 
            // TStock
            // 
            this.TStock.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TStock.Location = new System.Drawing.Point(489, 282);
            this.TStock.Name = "TStock";
            this.TStock.Size = new System.Drawing.Size(100, 20);
            this.TStock.TabIndex = 18;
            // 
            // LId
            // 
            this.LId.AutoSize = true;
            this.LId.Location = new System.Drawing.Point(489, 313);
            this.LId.Name = "LId";
            this.LId.Size = new System.Drawing.Size(21, 13);
            this.LId.TabIndex = 21;
            this.LId.Text = "ID:";
            // 
            // TId
            // 
            this.TId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TId.Location = new System.Drawing.Point(489, 330);
            this.TId.Name = "TId";
            this.TId.Size = new System.Drawing.Size(100, 20);
            this.TId.TabIndex = 20;
            // 
            // ChangeMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LId);
            this.Controls.Add(this.TId);
            this.Controls.Add(this.LStock);
            this.Controls.Add(this.TStock);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TPrecio);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.BAdd);
            this.Controls.Add(this.LAdd);
            this.Controls.Add(this.LProducto2);
            this.Controls.Add(this.Remove);
            this.Controls.Add(this.LRemover);
            this.Controls.Add(this.LProducto);
            this.Controls.Add(this.LLocal);
            this.Controls.Add(this.CProducto);
            this.Controls.Add(this.CLocal);
            this.Controls.Add(this.BBack);
            this.Name = "ChangeMenu";
            this.Text = "ChangeMenu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label LProducto;
        private System.Windows.Forms.Label LLocal;
        private System.Windows.Forms.ComboBox CProducto;
        private System.Windows.Forms.ComboBox CLocal;
        private System.Windows.Forms.Label LRemover;
        private System.Windows.Forms.Button Remove;
        private System.Windows.Forms.Button BAdd;
        private System.Windows.Forms.Label LAdd;
        private System.Windows.Forms.Label LProducto2;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TPrecio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LStock;
        private System.Windows.Forms.TextBox TStock;
        private System.Windows.Forms.Label LId;
        private System.Windows.Forms.TextBox TId;
    }
}