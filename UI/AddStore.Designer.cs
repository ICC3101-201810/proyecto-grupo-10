namespace UI
{
    partial class AddStore
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
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LRut = new System.Windows.Forms.Label();
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
            // 
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(349, 167);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(38, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name:";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(352, 184);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(352, 224);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 4;
            // 
            // LRut
            // 
            this.LRut.AutoSize = true;
            this.LRut.Location = new System.Drawing.Point(349, 207);
            this.LRut.Name = "LRut";
            this.LRut.Size = new System.Drawing.Size(27, 13);
            this.LRut.TabIndex = 3;
            this.LRut.Text = "Rut:";
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LRut);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.BBack);
            this.Name = "AddStore";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddStore";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label LName;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LRut;
    }
}