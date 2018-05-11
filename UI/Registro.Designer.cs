namespace UI
{
    partial class Registro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            this.LNombre = new System.Windows.Forms.Label();
            this.TNombre = new System.Windows.Forms.TextBox();
            this.TAppellido = new System.Windows.Forms.TextBox();
            this.LApellido = new System.Windows.Forms.Label();
            this.TMail = new System.Windows.Forms.TextBox();
            this.LMail = new System.Windows.Forms.Label();
            this.TRut = new System.Windows.Forms.TextBox();
            this.LRut = new System.Windows.Forms.Label();
            this.TClave = new System.Windows.Forms.TextBox();
            this.LClave = new System.Windows.Forms.Label();
            this.BRegistrar = new System.Windows.Forms.Button();
            this.BAtras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LNombre
            // 
            this.LNombre.AutoSize = true;
            this.LNombre.Location = new System.Drawing.Point(63, 55);
            this.LNombre.Name = "LNombre";
            this.LNombre.Size = new System.Drawing.Size(35, 13);
            this.LNombre.TabIndex = 0;
            this.LNombre.Text = "Name";
            this.LNombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // TNombre
            // 
            this.TNombre.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TNombre.Location = new System.Drawing.Point(66, 71);
            this.TNombre.Name = "TNombre";
            this.TNombre.Size = new System.Drawing.Size(129, 20);
            this.TNombre.TabIndex = 1;
            // 
            // TAppellido
            // 
            this.TAppellido.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TAppellido.Location = new System.Drawing.Point(66, 116);
            this.TAppellido.Name = "TAppellido";
            this.TAppellido.Size = new System.Drawing.Size(129, 20);
            this.TAppellido.TabIndex = 3;
            this.TAppellido.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // LApellido
            // 
            this.LApellido.AutoSize = true;
            this.LApellido.Location = new System.Drawing.Point(63, 100);
            this.LApellido.Name = "LApellido";
            this.LApellido.Size = new System.Drawing.Size(58, 13);
            this.LApellido.TabIndex = 2;
            this.LApellido.Text = "Last Name";
            this.LApellido.Click += new System.EventHandler(this.label2_Click);
            // 
            // TMail
            // 
            this.TMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TMail.Location = new System.Drawing.Point(66, 205);
            this.TMail.Name = "TMail";
            this.TMail.Size = new System.Drawing.Size(129, 20);
            this.TMail.TabIndex = 7;
            this.TMail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // LMail
            // 
            this.LMail.AutoSize = true;
            this.LMail.Location = new System.Drawing.Point(63, 189);
            this.LMail.Name = "LMail";
            this.LMail.Size = new System.Drawing.Size(26, 13);
            this.LMail.TabIndex = 6;
            this.LMail.Text = "Mail";
            this.LMail.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // TRut
            // 
            this.TRut.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TRut.Location = new System.Drawing.Point(66, 160);
            this.TRut.Name = "TRut";
            this.TRut.Size = new System.Drawing.Size(129, 20);
            this.TRut.TabIndex = 5;
            this.TRut.TextChanged += new System.EventHandler(this.textBox2_TextChanged_1);
            // 
            // LRut
            // 
            this.LRut.AutoSize = true;
            this.LRut.Location = new System.Drawing.Point(63, 144);
            this.LRut.Name = "LRut";
            this.LRut.Size = new System.Drawing.Size(24, 13);
            this.LRut.TabIndex = 4;
            this.LRut.Text = "Rut";
            this.LRut.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // TClave
            // 
            this.TClave.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TClave.Location = new System.Drawing.Point(66, 249);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(129, 20);
            this.TClave.TabIndex = 9;
            this.TClave.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // LClave
            // 
            this.LClave.AutoSize = true;
            this.LClave.Location = new System.Drawing.Point(63, 233);
            this.LClave.Name = "LClave";
            this.LClave.Size = new System.Drawing.Size(78, 13);
            this.LClave.TabIndex = 8;
            this.LClave.Text = "New Password";
            this.LClave.Click += new System.EventHandler(this.label1_Click_2);
            // 
            // BRegistrar
            // 
            this.BRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRegistrar.Location = new System.Drawing.Point(66, 285);
            this.BRegistrar.Name = "BRegistrar";
            this.BRegistrar.Size = new System.Drawing.Size(100, 23);
            this.BRegistrar.TabIndex = 10;
            this.BRegistrar.Text = "Register";
            this.BRegistrar.UseVisualStyleBackColor = true;
            this.BRegistrar.Click += new System.EventHandler(this.BRegistrar_Click);
            // 
            // BAtras
            // 
            this.BAtras.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAtras.Location = new System.Drawing.Point(66, 323);
            this.BAtras.Name = "BAtras";
            this.BAtras.Size = new System.Drawing.Size(100, 23);
            this.BAtras.TabIndex = 11;
            this.BAtras.Text = "Back";
            this.BAtras.UseVisualStyleBackColor = true;
            this.BAtras.Click += new System.EventHandler(this.BAtras_Click);
            // 
            // Registro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(267, 417);
            this.Controls.Add(this.BAtras);
            this.Controls.Add(this.BRegistrar);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.LClave);
            this.Controls.Add(this.TMail);
            this.Controls.Add(this.LMail);
            this.Controls.Add(this.TRut);
            this.Controls.Add(this.LRut);
            this.Controls.Add(this.TAppellido);
            this.Controls.Add(this.LApellido);
            this.Controls.Add(this.TNombre);
            this.Controls.Add(this.LNombre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Registro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro";
            this.Load += new System.EventHandler(this.Registro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LNombre;
        private System.Windows.Forms.TextBox TNombre;
        private System.Windows.Forms.TextBox TAppellido;
        private System.Windows.Forms.Label LApellido;
        private System.Windows.Forms.TextBox TMail;
        private System.Windows.Forms.Label LMail;
        private System.Windows.Forms.TextBox TRut;
        private System.Windows.Forms.Label LRut;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label LClave;
        private System.Windows.Forms.Button BRegistrar;
        private System.Windows.Forms.Button BAtras;
    }
}