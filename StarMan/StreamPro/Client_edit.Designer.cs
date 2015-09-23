namespace StarMan
{
    partial class Client_edit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client_edit));
            this.r_info = new System.Windows.Forms.RichTextBox();
            this.t_fio = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_num = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_edit = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            this.c_Bonus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // r_info
            // 
            this.r_info.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.r_info.Location = new System.Drawing.Point(15, 148);
            this.r_info.MaxLength = 200;
            this.r_info.Name = "r_info";
            this.r_info.Size = new System.Drawing.Size(572, 96);
            this.r_info.TabIndex = 12;
            this.r_info.Text = "";
            // 
            // t_fio
            // 
            this.t_fio.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_fio.Location = new System.Drawing.Point(15, 64);
            this.t_fio.MaxLength = 100;
            this.t_fio.Name = "t_fio";
            this.t_fio.Size = new System.Drawing.Size(572, 25);
            this.t_fio.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(12, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(115, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Доп. информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "ФИО";
            // 
            // t_num
            // 
            this.t_num.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_num.Location = new System.Drawing.Point(15, 22);
            this.t_num.Name = "t_num";
            this.t_num.Size = new System.Drawing.Size(572, 25);
            this.t_num.TabIndex = 11;
            this.t_num.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_num_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "Номер карты";
            // 
            // b_edit
            // 
            this.b_edit.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_edit.Location = new System.Drawing.Point(377, 250);
            this.b_edit.Name = "b_edit";
            this.b_edit.Size = new System.Drawing.Size(116, 29);
            this.b_edit.TabIndex = 5;
            this.b_edit.Text = "Редактировать";
            this.b_edit.UseVisualStyleBackColor = true;
            this.b_edit.Click += new System.EventHandler(this.b_edit_Click);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(499, 250);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(88, 29);
            this.b_Close.TabIndex = 14;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // c_Bonus
            // 
            this.c_Bonus.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.c_Bonus.FormattingEnabled = true;
            this.c_Bonus.Location = new System.Drawing.Point(15, 106);
            this.c_Bonus.Name = "c_Bonus";
            this.c_Bonus.Size = new System.Drawing.Size(224, 25);
            this.c_Bonus.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(12, 88);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 15;
            this.label6.Text = "Бонусы";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 260);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 17);
            this.l_error.TabIndex = 25;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "Использовать уровень бонусной системы"});
            this.checkedListBox1.Location = new System.Drawing.Point(245, 108);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(287, 24);
            this.checkedListBox1.TabIndex = 26;
            this.checkedListBox1.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.checkedListBox1_ItemCheck);
            // 
            // Client_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 284);
            this.ControlBox = false;
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.c_Bonus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.r_info);
            this.Controls.Add(this.t_fio);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_num);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.b_edit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Client_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование данных клиента*";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox r_info;
        private System.Windows.Forms.TextBox t_fio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_num;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button b_edit;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.ComboBox c_Bonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
    }
}