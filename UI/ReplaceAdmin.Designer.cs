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
            this.TMail = new System.Windows.Forms.TextBox();
            this.LNew2 = new System.Windows.Forms.Label();
            this.BAddAdmin = new System.Windows.Forms.Button();
            this.BBack = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TName = new System.Windows.Forms.TextBox();
            this.TApellido = new System.Windows.Forms.TextBox();
            this.TRut = new System.Windows.Forms.TextBox();
            this.TClave = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TOld
            // 
            this.TOld.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TOld.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TOld.Location = new System.Drawing.Point(12, 44);
            this.TOld.Name = "TOld";
            this.TOld.Size = new System.Drawing.Size(100, 20);
            this.TOld.TabIndex = 0;
            this.TOld.Text = "Mail:";
            // 
            // LOld
            // 
            this.LOld.AutoSize = true;
            this.LOld.Location = new System.Drawing.Point(12, 25);
            this.LOld.Name = "LOld";
            this.LOld.Size = new System.Drawing.Size(58, 13);
            this.LOld.TabIndex = 1;
            this.LOld.Text = "Old Admin:";
            // 
            // LNew
            // 
            this.LNew.AutoSize = true;
            this.LNew.Location = new System.Drawing.Point(12, 71);
            this.LNew.Name = "LNew";
            this.LNew.Size = new System.Drawing.Size(64, 13);
            this.LNew.TabIndex = 2;
            this.LNew.Text = "New Admin:";
            // 
            // TNew
            // 
            this.TNew.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TNew.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TNew.Location = new System.Drawing.Point(12, 88);
            this.TNew.Name = "TNew";
            this.TNew.Size = new System.Drawing.Size(100, 20);
            this.TNew.TabIndex = 3;
            this.TNew.Text = "Mail:";
            // 
            // BReplace
            // 
            this.BReplace.Location = new System.Drawing.Point(12, 124);
            this.BReplace.Name = "BReplace";
            this.BReplace.Size = new System.Drawing.Size(97, 23);
            this.BReplace.TabIndex = 4;
            this.BReplace.Text = "Replace Admin";
            this.BReplace.UseVisualStyleBackColor = true;
            this.BReplace.Click += new System.EventHandler(this.BReplace_Click);
            // 
            // TMail
            // 
            this.TMail.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.TMail.ForeColor = System.Drawing.SystemColors.InfoText;
            this.TMail.Location = new System.Drawing.Point(12, 400);
            this.TMail.Name = "TMail";
            this.TMail.Size = new System.Drawing.Size(100, 20);
            this.TMail.TabIndex = 6;
            // 
            // LNew2
            // 
            this.LNew2.AutoSize = true;
            this.LNew2.Location = new System.Drawing.Point(12, 181);
            this.LNew2.Name = "LNew2";
            this.LNew2.Size = new System.Drawing.Size(64, 13);
            this.LNew2.TabIndex = 5;
            this.LNew2.Text = "New Admin:";
            // 
            // BAddAdmin
            // 
            this.BAddAdmin.Location = new System.Drawing.Point(12, 426);
            this.BAddAdmin.Name = "BAddAdmin";
            this.BAddAdmin.Size = new System.Drawing.Size(100, 23);
            this.BAddAdmin.TabIndex = 7;
            this.BAddAdmin.Text = "Add Admin";
            this.BAddAdmin.UseVisualStyleBackColor = true;
            this.BAddAdmin.Click += new System.EventHandler(this.BAddAdmin_Click);
            // 
            // BBack
            // 
            this.BBack.Location = new System.Drawing.Point(37, 455);
            this.BBack.Name = "BBack";
            this.BBack.Size = new System.Drawing.Size(75, 23);
            this.BBack.TabIndex = 8;
            this.BBack.Text = "Back";
            this.BBack.UseVisualStyleBackColor = true;
            this.BBack.Click += new System.EventHandler(this.BBack_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 203);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 246);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 288);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Rut";
            // 
            // TName
            // 
            this.TName.Location = new System.Drawing.Point(14, 219);
            this.TName.Name = "TName";
            this.TName.Size = new System.Drawing.Size(98, 20);
            this.TName.TabIndex = 12;
            // 
            // TApellido
            // 
            this.TApellido.Location = new System.Drawing.Point(12, 266);
            this.TApellido.Name = "TApellido";
            this.TApellido.Size = new System.Drawing.Size(100, 20);
            this.TApellido.TabIndex = 13;
            // 
            // TRut
            // 
            this.TRut.Location = new System.Drawing.Point(12, 304);
            this.TRut.Name = "TRut";
            this.TRut.Size = new System.Drawing.Size(100, 20);
            this.TRut.TabIndex = 14;
            // 
            // TClave
            // 
            this.TClave.Location = new System.Drawing.Point(12, 351);
            this.TClave.Name = "TClave";
            this.TClave.Size = new System.Drawing.Size(100, 20);
            this.TClave.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 335);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Password";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 384);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(26, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Mail";
            // 
            // ReplaceAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(264, 560);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TClave);
            this.Controls.Add(this.TRut);
            this.Controls.Add(this.TApellido);
            this.Controls.Add(this.TName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BBack);
            this.Controls.Add(this.BAddAdmin);
            this.Controls.Add(this.TMail);
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
        private System.Windows.Forms.TextBox TMail;
        private System.Windows.Forms.Label LNew2;
        private System.Windows.Forms.Button BAddAdmin;
        private System.Windows.Forms.Button BBack;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TName;
        private System.Windows.Forms.TextBox TApellido;
        private System.Windows.Forms.TextBox TRut;
        private System.Windows.Forms.TextBox TClave;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
    }
}