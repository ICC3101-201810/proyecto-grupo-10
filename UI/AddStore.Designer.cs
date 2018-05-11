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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStore));
            this.BBack = new System.Windows.Forms.Button();
            this.LName = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TRut = new System.Windows.Forms.TextBox();
            this.LRut = new System.Windows.Forms.Label();
            this.LOpening = new System.Windows.Forms.Label();
            this.TOpening = new System.Windows.Forms.TextBox();
            this.TClosing = new System.Windows.Forms.TextBox();
            this.LClosing = new System.Windows.Forms.Label();
            this.BAddStore = new System.Windows.Forms.Button();
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
            // LName
            // 
            this.LName.AutoSize = true;
            this.LName.Location = new System.Drawing.Point(270, 80);
            this.LName.Name = "LName";
            this.LName.Size = new System.Drawing.Size(38, 13);
            this.LName.TabIndex = 1;
            this.LName.Text = "Name:";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(273, 96);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(100, 20);
            this.TName.TabIndex = 2;
            // 
            // TRut
            // 
            this.TRut.Location = new System.Drawing.Point(273, 135);
            this.TRut.Name = "TRut";
            this.TRut.Size = new System.Drawing.Size(100, 20);
            this.TRut.TabIndex = 4;
            // 
            // LRut
            // 
            this.LRut.AutoSize = true;
            this.LRut.Location = new System.Drawing.Point(270, 119);
            this.LRut.Name = "LRut";
            this.LRut.Size = new System.Drawing.Size(27, 13);
            this.LRut.TabIndex = 3;
            this.LRut.Text = "Rut:";
            // 
            // LOpening
            // 
            this.LOpening.AutoSize = true;
            this.LOpening.ForeColor = System.Drawing.SystemColors.InfoText;
            this.LOpening.Location = new System.Drawing.Point(270, 163);
            this.LOpening.Name = "LOpening";
            this.LOpening.Size = new System.Drawing.Size(76, 13);
            this.LOpening.TabIndex = 5;
            this.LOpening.Text = "Opening Hour:";
            // 
            // TOpening
            // 
            this.TOpening.Location = new System.Drawing.Point(273, 179);
            this.TOpening.Name = "TOpening";
            this.TOpening.Size = new System.Drawing.Size(100, 20);
            this.TOpening.TabIndex = 6;
            // 
            // TClosing
            // 
            this.TClosing.Location = new System.Drawing.Point(273, 224);
            this.TClosing.Name = "TClosing";
            this.TClosing.Size = new System.Drawing.Size(100, 20);
            this.TClosing.TabIndex = 8;
            // 
            // LClosing
            // 
            this.LClosing.AutoSize = true;
            this.LClosing.Location = new System.Drawing.Point(270, 207);
            this.LClosing.Name = "LClosing";
            this.LClosing.Size = new System.Drawing.Size(70, 13);
            this.LClosing.TabIndex = 7;
            this.LClosing.Text = "Closing Hour:";
            // 
            // BAddStore
            // 
            this.BAddStore.Location = new System.Drawing.Point(273, 250);
            this.BAddStore.Name = "BAddStore";
            this.BAddStore.Size = new System.Drawing.Size(75, 23);
            this.BAddStore.TabIndex = 9;
            this.BAddStore.Text = "Add Store";
            this.BAddStore.UseVisualStyleBackColor = true;
            this.BAddStore.Click += new System.EventHandler(this.button1_Click);
            // 
            // AddStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BAddStore);
            this.Controls.Add(this.TClosing);
            this.Controls.Add(this.LClosing);
            this.Controls.Add(this.TOpening);
            this.Controls.Add(this.LOpening);
            this.Controls.Add(this.TRut);
            this.Controls.Add(this.LRut);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.LName);
            this.Controls.Add(this.BBack);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.TextBox TRut;
        private System.Windows.Forms.Label LRut;
        private System.Windows.Forms.Label LOpening;
        private System.Windows.Forms.TextBox TOpening;
        private System.Windows.Forms.TextBox TClosing;
        private System.Windows.Forms.Label LClosing;
        private System.Windows.Forms.Button BAddStore;
    }
}