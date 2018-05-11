namespace UI
{
    partial class ReplaceAdmin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReplaceAdmin));
            this.TOld = new System.Windows.Forms.TextBox();
            this.LOld = new System.Windows.Forms.Label();
            this.LNew = new System.Windows.Forms.Label();
            this.TNew = new System.Windows.Forms.TextBox();
            this.BReplace = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.LNew2 = new System.Windows.Forms.Label();
            this.BAddAdmin = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TOld
            // 
            this.TOld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TOld.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TOld.Location = new System.Drawing.Point(12, 29);
            this.TOld.Name = "TOld";
            this.TOld.Size = new System.Drawing.Size(100, 20);
            this.TOld.TabIndex = 0;
            this.TOld.Text = "Mail:";
            // 
            // LOld
            // 
            this.LOld.AutoSize = true;
            this.LOld.Location = new System.Drawing.Point(12, 10);
            this.LOld.Name = "LOld";
            this.LOld.Size = new System.Drawing.Size(58, 13);
            this.LOld.TabIndex = 1;
            this.LOld.Text = "Old Admin:";
            // 
            // LNew
            // 
            this.LNew.AutoSize = true;
            this.LNew.Location = new System.Drawing.Point(12, 56);
            this.LNew.Name = "LNew";
            this.LNew.Size = new System.Drawing.Size(64, 13);
            this.LNew.TabIndex = 2;
            this.LNew.Text = "New Admin:";
            // 
            // TNew
            // 
            this.TNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TNew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TNew.Location = new System.Drawing.Point(12, 73);
            this.TNew.Name = "TNew";
            this.TNew.Size = new System.Drawing.Size(100, 20);
            this.TNew.TabIndex = 3;
            this.TNew.Text = "Mail:";
            // 
            // BReplace
            // 
            this.BReplace.Location = new System.Drawing.Point(12, 109);
            this.BReplace.Name = "BReplace";
            this.BReplace.Size = new System.Drawing.Size(97, 23);
            this.BReplace.TabIndex = 4;
            this.BReplace.Text = "Replace Admin";
            this.BReplace.UseVisualStyleBackColor = true;
            this.BReplace.Click += new System.EventHandler(this.BReplace_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(149, 73);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.Text = "Mail:";
            // 
            // LNew2
            // 
            this.LNew2.AutoSize = true;
            this.LNew2.Location = new System.Drawing.Point(149, 56);
            this.LNew2.Name = "LNew2";
            this.LNew2.Size = new System.Drawing.Size(64, 13);
            this.LNew2.TabIndex = 5;
            this.LNew2.Text = "New Admin:";
            // 
            // BAddAdmin
            // 
            this.BAddAdmin.Location = new System.Drawing.Point(149, 109);
            this.BAddAdmin.Name = "BAddAdmin";
            this.BAddAdmin.Size = new System.Drawing.Size(100, 23);
            this.BAddAdmin.TabIndex = 7;
            this.BAddAdmin.Text = "Add Admin";
            this.BAddAdmin.UseVisualStyleBackColor = true;
            this.BAddAdmin.Click += new System.EventHandler(this.BAddAdmin_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(174, 138);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 8;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // ReplaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(264, 181);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BAddAdmin);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.LNew2);
            this.Controls.Add(this.BReplace);
            this.Controls.Add(this.TNew);
            this.Controls.Add(this.LNew);
            this.Controls.Add(this.LOld);
            this.Controls.Add(this.TOld);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReplaceAdmin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReplaceAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TOld;
        private System.Windows.Forms.Label LOld;
        private System.Windows.Forms.Label LNew;
        private System.Windows.Forms.TextBox TNew;
        private System.Windows.Forms.Button BReplace;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label LNew2;
        private System.Windows.Forms.Button BAddAdmin;
        private System.Windows.Forms.Button BBack;
    }
}