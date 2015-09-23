namespace StarMan
{
    partial class edit_userBD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(edit_userBD));
            this.c_role = new System.Windows.Forms.ComboBox();
            this.r_info = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_fio = new System.Windows.Forms.TextBox();
            this.t_pass = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_login = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // c_role
            // 
            this.c_role.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.c_role.FormattingEnabled = true;
            this.c_role.Items.AddRange(new object[] {
            "Кассир",
            "Бухгалтер",
            "Администратор БД"});
            this.c_role.Location = new System.Drawing.Point(12, 148);
            this.c_role.Name = "c_role";
            this.c_role.Size = new System.Drawing.Size(469, 25);
            this.c_role.TabIndex = 24;
            // 
            // r_info
            // 
            this.r_info.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.r_info.Location = new System.Drawing.Point(12, 190);
            this.r_info.MaxLength = 200;
            this.r_info.Name = "r_info";
            this.r_info.Size = new System.Drawing.Size(469, 96);
            this.r_info.TabIndex = 23;
            this.r_info.Text = "";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(12, 130);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 17);
            this.label5.TabIndex = 15;
            this.label5.Text = "Права доступа";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(9, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 16;
            this.label4.Text = "ФИО";
            // 
            // t_fio
            // 
            this.t_fio.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_fio.Location = new System.Drawing.Point(12, 106);
            this.t_fio.MaxLength = 60;
            this.t_fio.Name = "t_fio";
            this.t_fio.Size = new System.Drawing.Size(469, 25);
            this.t_fio.TabIndex = 20;
            // 
            // t_pass
            // 
            this.t_pass.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_pass.Location = new System.Drawing.Point(12, 64);
            this.t_pass.MaxLength = 20;
            this.t_pass.Name = "t_pass";
            this.t_pass.Size = new System.Drawing.Size(469, 25);
            this.t_pass.TabIndex = 21;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 17;
            this.label3.Text = "Доп. информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(9, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Пароль";
            // 
            // t_login
            // 
            this.t_login.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_login.Location = new System.Drawing.Point(12, 22);
            this.t_login.MaxLength = 20;
            this.t_login.Name = "t_login";
            this.t_login.Size = new System.Drawing.Size(469, 25);
            this.t_login.TabIndex = 22;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 17);
            this.label1.TabIndex = 19;
            this.label1.Text = "Логин";
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_edit.Location = new System.Drawing.Point(251, 292);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(136, 29);
            this.b_edit.TabIndex = 14;
            this.b_edit.Text = "Редактировать";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(393, 292);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(88, 29);
            this.b_Close.TabIndex = 25;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 296);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 17);
            this.l_error.TabIndex = 26;
            // 
            // edit_userBD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 326);
            this.ControlBox = false;
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.c_role);
            this.Controls.Add(this.r_info);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.t_fio);
            this.Controls.Add(this.t_pass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_login);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "edit_userBD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактировать пользователя базы данных";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox c_role;
        private System.Windows.Forms.RichTextBox r_info;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_fio;
        private System.Windows.Forms.TextBox t_pass;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_login;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Label l_error;

    }
}