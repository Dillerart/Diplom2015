namespace StarMan
{
    partial class Property_connect
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
            this.t_Login = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.t_Pass = new System.Windows.Forms.TextBox();
            this.txtBoxBD = new System.Windows.Forms.TextBox();
            this.txtBoxSRV = new System.Windows.Forms.TextBox();
            this.b_Access = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_save = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_Login
            // 
            this.t_Login.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Login.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_Login.Location = new System.Drawing.Point(76, 86);
            this.t_Login.Margin = new System.Windows.Forms.Padding(4);
            this.t_Login.Name = "t_Login";
            this.t_Login.Size = new System.Drawing.Size(418, 25);
            this.t_Login.TabIndex = 3;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label6.Location = new System.Drawing.Point(5, 127);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 17);
            this.label6.TabIndex = 0;
            this.label6.Text = "Password:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label4.Location = new System.Drawing.Point(5, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Login:";
            // 
            // t_Pass
            // 
            this.t_Pass.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.t_Pass.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_Pass.Location = new System.Drawing.Point(76, 127);
            this.t_Pass.Margin = new System.Windows.Forms.Padding(4);
            this.t_Pass.Name = "t_Pass";
            this.t_Pass.PasswordChar = '*';
            this.t_Pass.Size = new System.Drawing.Size(418, 25);
            this.t_Pass.TabIndex = 4;
            // 
            // txtBoxBD
            // 
            this.txtBoxBD.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxBD.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtBoxBD.Location = new System.Drawing.Point(76, 47);
            this.txtBoxBD.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxBD.Name = "txtBoxBD";
            this.txtBoxBD.Size = new System.Drawing.Size(418, 25);
            this.txtBoxBD.TabIndex = 2;
            // 
            // txtBoxSRV
            // 
            this.txtBoxSRV.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBoxSRV.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.txtBoxSRV.Location = new System.Drawing.Point(76, 13);
            this.txtBoxSRV.Margin = new System.Windows.Forms.Padding(4);
            this.txtBoxSRV.Name = "txtBoxSRV";
            this.txtBoxSRV.Size = new System.Drawing.Size(418, 25);
            this.txtBoxSRV.TabIndex = 1;
            // 
            // b_Access
            // 
            this.b_Access.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_Access.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Access.Location = new System.Drawing.Point(121, 155);
            this.b_Access.Margin = new System.Windows.Forms.Padding(4);
            this.b_Access.Name = "b_Access";
            this.b_Access.Size = new System.Drawing.Size(162, 35);
            this.b_Access.TabIndex = 5;
            this.b_Access.Text = "Проверить соединение";
            this.b_Access.UseVisualStyleBackColor = true;
            this.b_Access.Click += new System.EventHandler(this.b_Access_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label5.Location = new System.Drawing.Point(5, 50);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "Имя БД:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(5, 17);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Сервер:";
            // 
            // b_save
            // 
            this.b_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_save.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_save.Location = new System.Drawing.Point(291, 155);
            this.b_save.Margin = new System.Windows.Forms.Padding(4);
            this.b_save.Name = "b_save";
            this.b_save.Size = new System.Drawing.Size(101, 35);
            this.b_save.TabIndex = 6;
            this.b_save.Text = "Cохранить";
            this.b_save.UseVisualStyleBackColor = true;
            this.b_save.Click += new System.EventHandler(this.b_save_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.button1.Location = new System.Drawing.Point(399, 155);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 35);
            this.button1.TabIndex = 7;
            this.button1.Text = "Закрыть";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Property_connect
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 197);
            this.ControlBox = false;
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Login);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxBD);
            this.Controls.Add(this.t_Pass);
            this.Controls.Add(this.txtBoxSRV);
            this.Controls.Add(this.b_save);
            this.Controls.Add(this.b_Access);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Property_connect";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Свойство подключения";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_Login;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox t_Pass;
        private System.Windows.Forms.TextBox txtBoxBD;
        private System.Windows.Forms.TextBox txtBoxSRV;
        private System.Windows.Forms.Button b_Access;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_save;
        private System.Windows.Forms.Button button1;
    }
}