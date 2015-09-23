namespace StarMan
{
    partial class Level_bns
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
            this.DatGridUser = new System.Windows.Forms.DataGridView();
            this.delete_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_min = new System.Windows.Forms.TextBox();
            this.t_max = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.c_Bonus = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.l_error = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridUser)).BeginInit();
            this.SuspendLayout();
            // 
            // DatGridUser
            // 
            this.DatGridUser.AllowUserToAddRows = false;
            this.DatGridUser.AllowUserToDeleteRows = false;
            this.DatGridUser.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DatGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridUser.Location = new System.Drawing.Point(2, 96);
            this.DatGridUser.Name = "DatGridUser";
            this.DatGridUser.ReadOnly = true;
            this.DatGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatGridUser.Size = new System.Drawing.Size(587, 258);
            this.DatGridUser.TabIndex = 0;
            // 
            // delete_bt
            // 
            this.delete_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.delete_bt.Image = global::StarMan.Properties.Resources._delete32;
            this.delete_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.delete_bt.Location = new System.Drawing.Point(548, 48);
            this.delete_bt.Name = "delete_bt";
            this.delete_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.delete_bt.Size = new System.Drawing.Size(41, 42);
            this.delete_bt.TabIndex = 16;
            this.delete_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.delete_bt.UseVisualStyleBackColor = true;
            this.delete_bt.Click += new System.EventHandler(this.delete_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_bt.Image = global::StarMan.Properties.Resources.Add_32;
            this.add_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_bt.Location = new System.Drawing.Point(501, 48);
            this.add_bt.Name = "add_bt";
            this.add_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_bt.Size = new System.Drawing.Size(41, 42);
            this.add_bt.TabIndex = 18;
            this.add_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(-1, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Накопленные пополнения ->MIN";
            // 
            // t_min
            // 
            this.t_min.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_min.Location = new System.Drawing.Point(2, 22);
            this.t_min.MaxLength = 9;
            this.t_min.Name = "t_min";
            this.t_min.Size = new System.Drawing.Size(208, 25);
            this.t_min.TabIndex = 20;
            this.t_min.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_min_KeyPress);
            // 
            // t_max
            // 
            this.t_max.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_max.Location = new System.Drawing.Point(2, 69);
            this.t_max.MaxLength = 9;
            this.t_max.Name = "t_max";
            this.t_max.Size = new System.Drawing.Size(208, 25);
            this.t_max.TabIndex = 20;
            this.t_max.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_max_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(-1, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 17);
            this.label3.TabIndex = 22;
            this.label3.Text = "Накопленные пополнения ->MAX";
            // 
            // c_Bonus
            // 
            this.c_Bonus.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.c_Bonus.FormattingEnabled = true;
            this.c_Bonus.Location = new System.Drawing.Point(225, 68);
            this.c_Bonus.Name = "c_Bonus";
            this.c_Bonus.Size = new System.Drawing.Size(271, 25);
            this.c_Bonus.TabIndex = 24;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(222, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "Бонусы";
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 367);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 19);
            this.l_error.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(222, 1);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Уровень";
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_name.Location = new System.Drawing.Point(225, 22);
            this.t_name.MaxLength = 60;
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(271, 25);
            this.t_name.TabIndex = 26;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.button1.Location = new System.Drawing.Point(501, 360);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 30);
            this.button1.TabIndex = 28;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Level_bns
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 395);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_name);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.c_Bonus);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_max);
            this.Controls.Add(this.t_min);
            this.Controls.Add(this.delete_bt);
            this.Controls.Add(this.add_bt);
            this.Controls.Add(this.DatGridUser);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Level_bns";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Уровни бонусов";
            ((System.ComponentModel.ISupportInitialize)(this.DatGridUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DatGridUser;
        private System.Windows.Forms.Button delete_bt;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_min;
        private System.Windows.Forms.TextBox t_max;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox c_Bonus;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Button button1;
    }
}