namespace UI
{
    partial class Hours
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
            this.TAbrir = new System.Windows.Forms.TextBox();
            this.LAbrir = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TCerrar = new System.Windows.Forms.TextBox();
            this.BListo = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TAbrir
            // 
            this.TAbrir.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TAbrir.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TAbrir.Location = new System.Drawing.Point(86, 77);
            this.TAbrir.Name = "TAbrir";
            this.TAbrir.Size = new System.Drawing.Size(100, 20);
            this.TAbrir.TabIndex = 0;
            // 
            // LAbrir
            // 
            this.LAbrir.AutoSize = true;
            this.LAbrir.Location = new System.Drawing.Point(86, 58);
            this.LAbrir.Name = "LAbrir";
            this.LAbrir.Size = new System.Drawing.Size(101, 13);
            this.LAbrir.TabIndex = 1;
            this.LAbrir.Text = "New Opening Hour:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(86, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "New Closing Hour:";
            // 
            // TCerrar
            // 
            this.TCerrar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TCerrar.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TCerrar.Location = new System.Drawing.Point(86, 133);
            this.TCerrar.Name = "TCerrar";
            this.TCerrar.Size = new System.Drawing.Size(100, 20);
            this.TCerrar.TabIndex = 2;
            // 
            // BListo
            // 
            this.BListo.Location = new System.Drawing.Point(86, 177);
            this.BListo.Name = "BListo";
            this.BListo.Size = new System.Drawing.Size(101, 23);
            this.BListo.TabIndex = 4;
            this.BListo.Text = "Done";
            this.BListo.UseVisualStyleBackColor = true;
            this.BListo.Click += new System.EventHandler(this.BListo_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(200, 224);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 5;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            // 
            // Hours
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BListo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TCerrar);
            this.Controls.Add(this.LAbrir);
            this.Controls.Add(this.TAbrir);
            this.Name = "Hours";
            this.Text = "Hours";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TAbrir;
        private System.Windows.Forms.Label LAbrir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TCerrar;
        private System.Windows.Forms.Button BListo;
        private System.Windows.Forms.Button BBack;
    }
}