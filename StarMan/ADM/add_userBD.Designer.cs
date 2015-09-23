namespace StarMan
{
    partial class add_userBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(add_userBD));
            this.cBox_role = new System.Windows.Forms.ComboBox();
            this.t_info = new System.Windows.Forms.RichTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Close = new System.Windows.Forms.Button();
            this.txt_FIO = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.b_add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cBox_role
            // 
            this.cBox_role.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.cBox_role.FormattingEnabled = true;
            this.cBox_role.Items.AddRange(new object[] {
            "Кассир",
            "Бухгалтер",
            "Администратор БД"});
            this.cBox_role.Location = new System.Drawing.Point(12, 149);
            this.cBox_role.Name = "cBox_role";
            this.cBox_role.Size = new System.Drawing.Size(469, 25);
            this.cBox_role.TabIndex = 13;
            // 
            // t_info
            // 
            this.t_info.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_info.Location = new System.Drawing.Point(12, 191);
            this.t_info.MaxLength = 200;
            this.t_info.Name = "t_info";
            this.t_info.Size = new System.Drawing.Size(469, 96);
            this.t_info.TabIndex = 12;
            this.t_info.Text = "";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "ФИО";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_pass.Location = new System.Drawing.Point(12, 65);
            this.txt_pass.MaxLength = 20;
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(469, 25);
            this.txt_pass.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Доп. информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(9, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "Пароль";
            // 
            // txt_login
            // 
            this.txt_login.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_login.Location = new System.Drawing.Point(12, 23);
            this.txt_login.MaxLength = 20;
            this.txt_login.Name = "txt_login";
            this.txt_login.Size = new System.Drawing.Size(469, 25);
            this.txt_login.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Логин";
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(393, 293);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(88, 29);
            this.b_Close.TabIndex = 5;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // txt_FIO
            // 
            this.txt_FIO.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txt_FIO.Location = new System.Drawing.Point(12, 107);
            this.txt_FIO.MaxLength = 60;
            this.txt_FIO.Name = "txt_FIO";
            this.txt_FIO.Size = new System.Drawing.Size(469, 25);
            this.txt_FIO.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(12, 131);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 6;
            this.label5.Text = "Права доступа";
            // 
            // b_add
            // 
            this.b_add.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_add.Location = new System.Drawing.Point(278, 293);
            this.b_add.Name = "b_add";
            this.b_add.Size = new System.Drawing.Size(109, 29);
            this.b_add.TabIndex = 5;
            this.b_add.Text = "Добавить";
            this.b_add.UseVisualStyleBackColor = true;
            this.b_add.Click += new System.EventHandler(this.b_add_Click);
            // 
            // add_userBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(490, 330);
            this.ControlBox = false;
            this.Controls.Add(this.cBox_role);
            this.Controls.Add(this.t_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_FIO);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_add);
            this.Controls.Add(this.b_Close);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "add_userBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Новый пользователь*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cBox_role;
        private System.Windows.Forms.RichTextBox t_info;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.TextBox txt_FIO;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b_add;
    }
}