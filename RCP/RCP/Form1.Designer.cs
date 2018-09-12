namespace RCP
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.plikToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuEndApp = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuUsers = new System.Windows.Forms.ToolStripMenuItem();
            this.AddUser = new System.Windows.Forms.ToolStripMenuItem();
            this.DelUser = new System.Windows.Forms.ToolStripMenuItem();
            this.edytujUżytkownikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plikToolStripMenuItem,
            this.MenuUsers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // plikToolStripMenuItem
            // 
            this.plikToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuEndApp});
            this.plikToolStripMenuItem.Name = "plikToolStripMenuItem";
            this.plikToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.plikToolStripMenuItem.Text = "Plik";
            // 
            // MenuEndApp
            // 
            this.MenuEndApp.Name = "MenuEndApp";
            this.MenuEndApp.Size = new System.Drawing.Size(118, 22);
            this.MenuEndApp.Text = "Zakończ";
            this.MenuEndApp.Click += new System.EventHandler(this.MenuEndApp_Click);
            // 
            // MenuUsers
            // 
            this.MenuUsers.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AddUser,
            this.DelUser,
            this.edytujUżytkownikaToolStripMenuItem});
            this.MenuUsers.Name = "MenuUsers";
            this.MenuUsers.Size = new System.Drawing.Size(86, 20);
            this.MenuUsers.Text = "Użytkownicy";
            // 
            // AddUser
            // 
            this.AddUser.Name = "AddUser";
            this.AddUser.Size = new System.Drawing.Size(180, 22);
            this.AddUser.Text = "Dodaj użytkownika";
            this.AddUser.Click += new System.EventHandler(this.AddUser_Click);
            // 
            // DelUser
            // 
            this.DelUser.Name = "DelUser";
            this.DelUser.Size = new System.Drawing.Size(180, 22);
            this.DelUser.Text = "Usuń użytkownika";
            // 
            // edytujUżytkownikaToolStripMenuItem
            // 
            this.edytujUżytkownikaToolStripMenuItem.Name = "edytujUżytkownikaToolStripMenuItem";
            this.edytujUżytkownikaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.edytujUżytkownikaToolStripMenuItem.Text = "Edytuj użytkownika";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "RCP";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem plikToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuEndApp;
        private System.Windows.Forms.ToolStripMenuItem MenuUsers;
        private System.Windows.Forms.ToolStripMenuItem AddUser;
        private System.Windows.Forms.ToolStripMenuItem DelUser;
        private System.Windows.Forms.ToolStripMenuItem edytujUżytkownikaToolStripMenuItem;
    }
}

