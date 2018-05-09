namespace UI
{
    partial class GradesComm
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
            this.TNota = new System.Windows.Forms.TextBox();
            this.TComentario = new System.Windows.Forms.TextBox();
            this.CLocal = new System.Windows.Forms.ComboBox();
            this.LElegir = new System.Windows.Forms.Label();
            this.LNota = new System.Windows.Forms.Label();
            this.LComentario = new System.Windows.Forms.Label();
            this.BVolver = new System.Windows.Forms.Button();
            this.BEnviar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TNota
            // 
            this.TNota.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TNota.Location = new System.Drawing.Point(128, 131);
            this.TNota.Name = "TNota";
            this.TNota.Size = new System.Drawing.Size(100, 20);
            this.TNota.TabIndex = 0;
            this.TNota.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TComentario
            // 
            this.TComentario.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TComentario.Location = new System.Drawing.Point(128, 192);
            this.TComentario.Multiline = true;
            this.TComentario.Name = "TComentario";
            this.TComentario.Size = new System.Drawing.Size(500, 200);
            this.TComentario.TabIndex = 1;
            this.TComentario.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // CLocal
            // 
            this.CLocal.FormattingEnabled = true;
            this.CLocal.Location = new System.Drawing.Point(128, 82);
            this.CLocal.Name = "CLocal";
            this.CLocal.Size = new System.Drawing.Size(121, 21);
            this.CLocal.TabIndex = 2;
            this.CLocal.SelectedIndexChanged += new System.EventHandler(this.CLocal_SelectedIndexChanged);
            // 
            // LElegir
            // 
            this.LElegir.AutoSize = true;
            this.LElegir.Location = new System.Drawing.Point(125, 64);
            this.LElegir.Name = "LElegir";
            this.LElegir.Size = new System.Drawing.Size(71, 13);
            this.LElegir.TabIndex = 3;
            this.LElegir.Text = "Choose Store";
            this.LElegir.Click += new System.EventHandler(this.label1_Click);
            // 
            // LNota
            // 
            this.LNota.AutoSize = true;
            this.LNota.Location = new System.Drawing.Point(125, 115);
            this.LNota.Name = "LNota";
            this.LNota.Size = new System.Drawing.Size(58, 13);
            this.LNota.TabIndex = 4;
            this.LNota.Text = "Add Grade";
            this.LNota.Click += new System.EventHandler(this.label2_Click);
            // 
            // LComentario
            // 
            this.LComentario.AutoSize = true;
            this.LComentario.Location = new System.Drawing.Point(125, 176);
            this.LComentario.Name = "LComentario";
            this.LComentario.Size = new System.Drawing.Size(73, 13);
            this.LComentario.TabIndex = 5;
            this.LComentario.Text = "Add Comment";
            // 
            // BVolver
            // 
            this.BVolver.Location = new System.Drawing.Point(691, 400);
            this.BVolver.Name = "BVolver";
            this.BVolver.Size = new System.Drawing.Size(81, 29);
            this.BVolver.TabIndex = 6;
            this.BVolver.Text = "Back";
            this.BVolver.UseVisualStyleBackColor = true;
            this.BVolver.Click += new System.EventHandler(this.CSesion_Click);
            // 
            // BEnviar
            // 
            this.BEnviar.Location = new System.Drawing.Point(691, 363);
            this.BEnviar.Name = "BEnviar";
            this.BEnviar.Size = new System.Drawing.Size(81, 29);
            this.BEnviar.TabIndex = 7;
            this.BEnviar.Text = "Send";
            this.BEnviar.UseVisualStyleBackColor = true;
            this.BEnviar.Click += new System.EventHandler(this.BEnviar_Click);
            // 
            // GradesComm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BEnviar);
            this.Controls.Add(this.BVolver);
            this.Controls.Add(this.LComentario);
            this.Controls.Add(this.LNota);
            this.Controls.Add(this.LElegir);
            this.Controls.Add(this.CLocal);
            this.Controls.Add(this.TComentario);
            this.Controls.Add(this.TNota);
            this.Name = "GradesComm";
            this.Text = "GradesComm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TNota;
        private System.Windows.Forms.TextBox TComentario;
        private System.Windows.Forms.ComboBox CLocal;
        private System.Windows.Forms.Label LElegir;
        private System.Windows.Forms.Label LNota;
        private System.Windows.Forms.Label LComentario;
        private System.Windows.Forms.Button BVolver;
        private System.Windows.Forms.Button BEnviar;
    }
}