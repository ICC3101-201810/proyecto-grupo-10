﻿namespace UI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainAdminApp));
            this.BRemoveUser = new System.Windows.Forms.Button();
            this.BAddStores = new System.Windows.Forms.Button();
            this.BRemoveStores = new System.Windows.Forms.Button();
            this.BReplaceAdmin = new System.Windows.Forms.Button();
            this.BExit = new System.Windows.Forms.Button();
            this.CStore = new System.Windows.Forms.ComboBox();
            this.CMail = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // BRemoveUser
            // 
            this.BRemoveUser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRemoveUser.Location = new System.Drawing.Point(161, 106);
            this.BRemoveUser.Name = "BRemoveUser";
            this.BRemoveUser.Size = new System.Drawing.Size(99, 23);
            this.BRemoveUser.TabIndex = 0;
            this.BRemoveUser.Text = "Remove User";
            this.BRemoveUser.UseVisualStyleBackColor = true;
            this.BRemoveUser.Click += new System.EventHandler(this.BRemoveUser_Click);
            // 
            // BAddStores
            // 
            this.BAddStores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BAddStores.Location = new System.Drawing.Point(161, 48);
            this.BAddStores.Name = "BAddStores";
            this.BAddStores.Size = new System.Drawing.Size(99, 23);
            this.BAddStores.TabIndex = 1;
            this.BAddStores.Text = "Add Stores";
            this.BAddStores.UseVisualStyleBackColor = true;
            this.BAddStores.Click += new System.EventHandler(this.BAddStores_Click);
            // 
            // BRemoveStores
            // 
            this.BRemoveStores.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BRemoveStores.Location = new System.Drawing.Point(161, 77);
            this.BRemoveStores.Name = "BRemoveStores";
            this.BRemoveStores.Size = new System.Drawing.Size(99, 23);
            this.BRemoveStores.TabIndex = 2;
            this.BRemoveStores.Text = "Remove Stores";
            this.BRemoveStores.UseVisualStyleBackColor = true;
            this.BRemoveStores.Click += new System.EventHandler(this.BRemoveStores_Click);
            // 
            // BReplaceAdmin
            // 
            this.BReplaceAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BReplaceAdmin.Location = new System.Drawing.Point(161, 135);
            this.BReplaceAdmin.Name = "BReplaceAdmin";
            this.BReplaceAdmin.Size = new System.Drawing.Size(99, 45);
            this.BReplaceAdmin.TabIndex = 3;
            this.BReplaceAdmin.Text = "Add/Remove Store Admin";
            this.BReplaceAdmin.UseVisualStyleBackColor = true;
            this.BReplaceAdmin.Click += new System.EventHandler(this.BReplaceAdmin_Click);
            // 
            // BExit
            // 
            this.BExit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BExit.Location = new System.Drawing.Point(185, 223);
            this.BExit.Name = "BExit";
            this.BExit.Size = new System.Drawing.Size(75, 23);
            this.BExit.TabIndex = 4;
            this.BExit.Text = "Exit";
            this.BExit.UseVisualStyleBackColor = true;
            this.BExit.Click += new System.EventHandler(this.BExit_Click);
            // 
            // CStore
            // 
            this.CStore.FormattingEnabled = true;
            this.CStore.Location = new System.Drawing.Point(23, 77);
            this.CStore.Name = "CStore";
            this.CStore.Size = new System.Drawing.Size(132, 21);
            this.CStore.TabIndex = 6;
            this.CStore.Text = "Store to remove";
            // 
            // CMail
            // 
            this.CMail.FormattingEnabled = true;
            this.CMail.Location = new System.Drawing.Point(23, 108);
            this.CMail.Name = "CMail";
            this.CMail.Size = new System.Drawing.Size(132, 21);
            this.CMail.TabIndex = 7;
            this.CMail.Text = "User to remove";
            // 
            // MainAdminApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(304, 346);
            this.Controls.Add(this.CMail);
            this.Controls.Add(this.CStore);
            this.Controls.Add(this.BExit);
            this.Controls.Add(this.BReplaceAdmin);
            this.Controls.Add(this.BRemoveStores);
            this.Controls.Add(this.BAddStores);
            this.Controls.Add(this.BRemoveUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainAdminApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MenuAdminApp";
            this.Load += new System.EventHandler(this.MainAdminApp_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BRemoveUser;
        private System.Windows.Forms.Button BAddStores;
        private System.Windows.Forms.Button BRemoveStores;
        private System.Windows.Forms.Button BReplaceAdmin;
        private System.Windows.Forms.Button BExit;
        private System.Windows.Forms.ComboBox CStore;
        private System.Windows.Forms.ComboBox CMail;
    }
}