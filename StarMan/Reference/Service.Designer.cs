namespace StarMan
{
    partial class Service
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Service));
            this.DatGridUser = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.l_error = new System.Windows.Forms.Label();
            this.b_remove = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.t_money = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_name = new System.Windows.Forms.TextBox();
            this.edit_bt = new System.Windows.Forms.Button();
            this.add_bt = new System.Windows.Forms.Button();
            this.b_Close = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DatGridUser)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DatGridUser
            // 
            this.DatGridUser.AllowUserToAddRows = false;
            this.DatGridUser.AllowUserToDeleteRows = false;
            this.DatGridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DatGridUser.Location = new System.Drawing.Point(4, 115);
            this.DatGridUser.Name = "DatGridUser";
            this.DatGridUser.ReadOnly = true;
            this.DatGridUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DatGridUser.Size = new System.Drawing.Size(504, 192);
            this.DatGridUser.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.l_error);
            this.groupBox1.Controls.Add(this.b_remove);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.t_money);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.t_name);
            this.groupBox1.Controls.Add(this.edit_bt);
            this.groupBox1.Controls.Add(this.add_bt);
            this.groupBox1.Location = new System.Drawing.Point(4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(504, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(207, 69);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 19);
            this.l_error.TabIndex = 27;
            // 
            // b_remove
            // 
            this.b_remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.b_remove.Image = global::StarMan.Properties.Resources._del32;
            this.b_remove.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.b_remove.Location = new System.Drawing.Point(150, 58);
            this.b_remove.Name = "b_remove";
            this.b_remove.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.b_remove.Size = new System.Drawing.Size(41, 42);
            this.b_remove.TabIndex = 26;
            this.b_remove.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.b_remove.UseVisualStyleBackColor = true;
            this.b_remove.Click += new System.EventHandler(this.b_remove_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Image = global::StarMan.Properties.Resources._delete32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(103, 58);
            this.button1.Name = "button1";
            this.button1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button1.Size = new System.Drawing.Size(41, 42);
            this.button1.TabIndex = 24;
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(254, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Цена";
            // 
            // t_money
            // 
            this.t_money.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_money.Location = new System.Drawing.Point(257, 32);
            this.t_money.MaxLength = 9;
            this.t_money.Name = "t_money";
            this.t_money.Size = new System.Drawing.Size(240, 25);
            this.t_money.TabIndex = 22;
            this.t_money.Text = "0";
            this.t_money.TextChanged += new System.EventHandler(this.t_money_TextChanged);
            this.t_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.t_money_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(6, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Наименование услуги";
            // 
            // t_name
            // 
            this.t_name.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_name.Location = new System.Drawing.Point(9, 32);
            this.t_name.MaxLength = 60;
            this.t_name.Name = "t_name";
            this.t_name.Size = new System.Drawing.Size(240, 25);
            this.t_name.TabIndex = 22;
            // 
            // edit_bt
            // 
            this.edit_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.edit_bt.Image = global::StarMan.Properties.Resources.Redackt_32;
            this.edit_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.edit_bt.Location = new System.Drawing.Point(56, 58);
            this.edit_bt.Name = "edit_bt";
            this.edit_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.edit_bt.Size = new System.Drawing.Size(41, 42);
            this.edit_bt.TabIndex = 20;
            this.edit_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.edit_bt.UseVisualStyleBackColor = true;
            this.edit_bt.Click += new System.EventHandler(this.edit_bt_Click);
            // 
            // add_bt
            // 
            this.add_bt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.add_bt.Image = global::StarMan.Properties.Resources.Add_32;
            this.add_bt.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.add_bt.Location = new System.Drawing.Point(9, 58);
            this.add_bt.Name = "add_bt";
            this.add_bt.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.add_bt.Size = new System.Drawing.Size(41, 42);
            this.add_bt.TabIndex = 21;
            this.add_bt.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.add_bt.UseVisualStyleBackColor = true;
            this.add_bt.Click += new System.EventHandler(this.add_bt_Click);
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(420, 313);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(88, 29);
            this.b_Close.TabIndex = 6;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // Service
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 348);
            this.ControlBox = false;
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.DatGridUser);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Service";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Услуги";
            this.Activated += new System.EventHandler(this.Service_Activated);
            ((System.ComponentModel.ISupportInitialize)(this.DatGridUser)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DatGridUser;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox t_money;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox t_name;
        private System.Windows.Forms.Button edit_bt;
        private System.Windows.Forms.Button add_bt;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.Button b_remove;

    }
}