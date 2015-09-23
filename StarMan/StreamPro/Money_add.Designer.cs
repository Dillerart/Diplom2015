namespace StarMan
{
    partial class Money_add
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Money_add));
            this.t_moneys = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tex_money = new System.Windows.Forms.TextBox();
            this.c_money = new System.Windows.Forms.ComboBox();
            this.b_Close = new System.Windows.Forms.Button();
            this.l_error = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.r_print = new System.Windows.Forms.RichTextBox();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // t_moneys
            // 
            this.t_moneys.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.t_moneys.Location = new System.Drawing.Point(3, 23);
            this.t_moneys.Name = "t_moneys";
            this.t_moneys.ReadOnly = true;
            this.t_moneys.Size = new System.Drawing.Size(141, 25);
            this.t_moneys.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label1.Location = new System.Drawing.Point(0, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Номер карты";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.button1.Location = new System.Drawing.Point(312, 56);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 29);
            this.button1.TabIndex = 14;
            this.button1.Text = "Пополнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label2.Location = new System.Drawing.Point(286, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "Вид оплаты";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.label3.Location = new System.Drawing.Point(147, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(134, 17);
            this.label3.TabIndex = 18;
            this.label3.Text = "Денежные средства";
            // 
            // tex_money
            // 
            this.tex_money.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.tex_money.Location = new System.Drawing.Point(150, 22);
            this.tex_money.MaxLength = 9;
            this.tex_money.Name = "tex_money";
            this.tex_money.Size = new System.Drawing.Size(133, 25);
            this.tex_money.TabIndex = 20;
            this.tex_money.Text = "0";
            this.tex_money.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tex_money_KeyPress);
            // 
            // c_money
            // 
            this.c_money.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.c_money.FormattingEnabled = true;
            this.c_money.Location = new System.Drawing.Point(289, 22);
            this.c_money.Name = "c_money";
            this.c_money.Size = new System.Drawing.Size(151, 25);
            this.c_money.TabIndex = 21;
            // 
            // b_Close
            // 
            this.b_Close.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.b_Close.Location = new System.Drawing.Point(312, 91);
            this.b_Close.Name = "b_Close";
            this.b_Close.Size = new System.Drawing.Size(128, 29);
            this.b_Close.TabIndex = 22;
            this.b_Close.Text = "Закрыть";
            this.b_Close.UseVisualStyleBackColor = true;
            this.b_Close.Click += new System.EventHandler(this.b_Close_Click);
            // 
            // l_error
            // 
            this.l_error.AutoSize = true;
            this.l_error.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.l_error.ForeColor = System.Drawing.Color.Red;
            this.l_error.Location = new System.Drawing.Point(12, 358);
            this.l_error.Name = "l_error";
            this.l_error.Size = new System.Drawing.Size(0, 19);
            this.l_error.TabIndex = 24;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.r_print);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.groupBox1.Location = new System.Drawing.Point(3, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(303, 305);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Чек";
            // 
            // r_print
            // 
            this.r_print.Font = new System.Drawing.Font("Times New Roman", 11.25F);
            this.r_print.Location = new System.Drawing.Point(8, 19);
            this.r_print.Name = "r_print";
            this.r_print.Size = new System.Drawing.Size(287, 280);
            this.r_print.TabIndex = 0;
            this.r_print.Text = "";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // Money_add
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(448, 387);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.l_error);
            this.Controls.Add(this.b_Close);
            this.Controls.Add(this.c_money);
            this.Controls.Add(this.tex_money);
            this.Controls.Add(this.t_moneys);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Money_add";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Пополнение счета";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox t_moneys;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tex_money;
        private System.Windows.Forms.ComboBox c_money;
        private System.Windows.Forms.Button b_Close;
        private System.Windows.Forms.Label l_error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RichTextBox r_print;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;

    }
}