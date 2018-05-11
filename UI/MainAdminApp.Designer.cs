namespace UI
{
    partial class MainAdminApp
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
            this.BRemoveUser = new System.Windows.Forms.Button();
            this.BAddStores = new System.Windows.Forms.Button();
            this.BRemoveStores = new System.Windows.Forms.Button();
            this.BReplaceAdmin = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.TMail = new System.Windows.Forms.TextBox();
            this.CStore = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BRemoveUser
            // 
            this.BRemoveUser.Location = new System.Drawing.Point(337, 192);
            this.BRemoveUser.Name = "BRemoveUser";
            this.BRemoveUser.Size = new System.Drawing.Size(99, 23);
            this.BRemoveUser.TabIndex = 0;
            this.BRemoveUser.Text = "Remove User";
            this.BRemoveUser.UseVisualStyleBackColor = true;
            this.BRemoveUser.Click += new System.EventHandler(this.BRemoveUser_Click);
            // 
            // BAddStores
            // 
            this.BAddStores.Location = new System.Drawing.Point(337, 134);
            this.BAddStores.Name = "BAddStores";
            this.BAddStores.Size = new System.Drawing.Size(99, 23);
            this.BAddStores.TabIndex = 1;
            this.BAddStores.Text = "Add Stores";
            this.BAddStores.UseVisualStyleBackColor = true;
            // 
            // BRemoveStores
            // 
            this.BRemoveStores.Location = new System.Drawing.Point(337, 163);
            this.BRemoveStores.Name = "BRemoveStores";
            this.BRemoveStores.Size = new System.Drawing.Size(99, 23);
            this.BRemoveStores.TabIndex = 2;
            this.BRemoveStores.Text = "Remove Stores";
            this.BRemoveStores.UseVisualStyleBackColor = true;
            this.BRemoveStores.Click += new System.EventHandler(this.BRemoveStores_Click);
            // 
            // BReplaceAdmin
            // 
            this.BReplaceAdmin.Location = new System.Drawing.Point(337, 221);
            this.BReplaceAdmin.Name = "BReplaceAdmin";
            this.BReplaceAdmin.Size = new System.Drawing.Size(99, 45);
            this.BReplaceAdmin.TabIndex = 3;
            this.BReplaceAdmin.Text = "Replace Local Admin";
            this.BReplaceAdmin.UseVisualStyleBackColor = true;
            // 
            // BExit
            // 
            this.BExit.Location = new System.Drawing.Point(713, 415);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(75, 23);
            this.BExit.TabIndex = 4;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // TMail
            // 
            this.TMail.Location = new System.Drawing.Point(199, 195);
            this.TMail.Name = "TMail";
            this.TMail.Size = new System.Drawing.Size(132, 20);
            this.TMail.TabIndex = 5;
            this.TMail.Text = "Mail of User to Remove:";
            // 
            // CStore
            // 
            this.CStore.FormattingEnabled = true;
            this.CStore.Location = new System.Drawing.Point(199, 163);
            this.CStore.Name = "CStore";
            this.CStore.Size = new System.Drawing.Size(132, 21);
            this.CStore.TabIndex = 6;
            // 
            // MainAdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.CStore);
            this.Controls.Add(this.TMail);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BReplaceAdmin);
            this.Controls.Add(this.BRemoveStores);
            this.Controls.Add(this.BAddStores);
            this.Controls.Add(this.BRemoveUser);
            this.Name = "MainAdminApp";
            this.Text = "MainAdminApp";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BRemoveUser;
        private System.Windows.Forms.Button BAddStores;
        private System.Windows.Forms.Button BRemoveStores;
        private System.Windows.Forms.Button BReplaceAdmin;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.TextBox TMail;
        private System.Windows.Forms.ComboBox CStore;
    }
}