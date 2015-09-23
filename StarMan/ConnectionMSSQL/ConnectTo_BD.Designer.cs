namespace StarMan
{
    partial class ConnectTo_BD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConnectTo_BD));
            this.b_ConnetTo_BD = new System.Windows.Forms.Button();
            this.b_login = new System.Windows.Forms.TextBox();
            this.b_pass = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.свойствоПодключенияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.b_Close = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // b_ConnetTo_BD
            // 
            this.b_ConnetTo_BD.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_ConnetTo_BD.Location = new System.Drawing.Point(197, 95);
            this.b_ConnetTo_BD.Name = "b_ConnetTo_BD";
            this.b_ConnetTo_BD.Size = new System.Drawing.Size(100, 30);
            this.b_ConnetTo_BD.TabIndex = 3;
            this.b_ConnetTo_BD.Text = "Подключиться";
            this.b_ConnetTo_BD.UseVisualStyleBackColor = true;
            this.b_ConnetTo_BD.Click += new System.EventHandler(this.b_ConnetTo_BD_Click);
            // 
            // b_login
            // 
            this.b_login.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_login.Location = new System.Drawing.Point(68, 22);
            this.b_login.MaxLength = 20;
            this.b_login.Name = "b_login";
            this.b_login.Size = new System.Drawing.Size(323, 25);
            this.b_login.TabIndex = 1;
            // 
            // b_pass
            // 
            this.b_pass.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_pass.Location = new System.Drawing.Point(68, 64);
            this.b_pass.MaxLength = 20;
            this.b_pass.Name = "b_pass";
            this.b_pass.PasswordChar = '*';
            this.b_pass.Size = new System.Drawing.Size(323, 25);
            this.b_pass.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(14, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Пароль:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(397, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.свойствоПодключенияToolStripMenuItem});
            this.файлToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(49, 20);
            this.файлToolStripMenuItem.Text = "Ф&айл";
            // 
            // свойствоПодключенияToolStripMenuItem
            // 
            this.свойствоПодключенияToolStripMenuItem.Name = "свойствоПодключенияToolStripMenuItem";
            this.свойствоПодключенияToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.свойствоПодключенияToolStripMenuItem.Text = "Свойство подключения";
            this.свойствоПодключенияToolStripMenuItem.Click += new System.EventHandler(this.свойствоПодключенияToolStripMenuItem_Click);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(303, 96);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(88, 29);
            this.b_Close.TabIndex = 4;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // ConnectTo_BD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 129);
            this.ControlBox = false;
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_pass);
            this.Controls.Add(this.b_login);
            this.Controls.Add(this.b_ConnetTo_BD);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "ConnectTo_BD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Подключение";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button b_ConnetTo_BD;
        private System.Windows.Forms.TextBox b_login;
        private System.Windows.Forms.TextBox b_pass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem файлToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem свойствоПодключенияToolStripMenuItem;
        private System.Windows.Forms.Button b_Close;

    }
}