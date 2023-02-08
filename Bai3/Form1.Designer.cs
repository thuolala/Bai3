namespace Bai3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.stuID = new System.Windows.Forms.TextBox();
            this.fullName = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.semI = new System.Windows.Forms.RadioButton();
            this.semII = new System.Windows.Forms.RadioButton();
            this.semIII = new System.Windows.Forms.RadioButton();
            this.semIV = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.sign = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.checkList = new System.Windows.Forms.CheckedListBox();
            this.del = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Location = new System.Drawing.Point(189, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "ĐĂNG KÝ MÔN HỌC";
            // 
            // stuID
            // 
            this.stuID.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.stuID.Location = new System.Drawing.Point(167, 91);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(161, 27);
            this.stuID.TabIndex = 1;
            // 
            // fullName
            // 
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fullName.Location = new System.Drawing.Point(167, 139);
            this.fullName.Name = "fullName";
            this.fullName.Size = new System.Drawing.Size(317, 27);
            this.fullName.TabIndex = 2;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(167, 190);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 28);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(167, 242);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 28);
            this.comboBox2.TabIndex = 4;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // semI
            // 
            this.semI.AutoSize = true;
            this.semI.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semI.Location = new System.Drawing.Point(3, 3);
            this.semI.Name = "semI";
            this.semI.Size = new System.Drawing.Size(32, 25);
            this.semI.TabIndex = 5;
            this.semI.TabStop = true;
            this.semI.Text = "I";
            this.semI.UseVisualStyleBackColor = true;
            // 
            // semII
            // 
            this.semII.AutoSize = true;
            this.semII.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semII.Location = new System.Drawing.Point(51, 3);
            this.semII.Name = "semII";
            this.semII.Size = new System.Drawing.Size(36, 25);
            this.semII.TabIndex = 6;
            this.semII.TabStop = true;
            this.semII.Text = "II";
            this.semII.UseVisualStyleBackColor = true;
            // 
            // semIII
            // 
            this.semIII.AutoSize = true;
            this.semIII.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semIII.Location = new System.Drawing.Point(103, 3);
            this.semIII.Name = "semIII";
            this.semIII.Size = new System.Drawing.Size(40, 25);
            this.semIII.TabIndex = 7;
            this.semIII.TabStop = true;
            this.semIII.Text = "III";
            this.semIII.UseVisualStyleBackColor = true;
            // 
            // semIV
            // 
            this.semIV.AutoSize = true;
            this.semIV.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.semIV.Location = new System.Drawing.Point(158, 3);
            this.semIV.Name = "semIV";
            this.semIV.Size = new System.Drawing.Size(42, 25);
            this.semIV.TabIndex = 8;
            this.semIV.TabStop = true;
            this.semIV.Text = "IV";
            this.semIV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(88, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 21);
            this.label2.TabIndex = 14;
            this.label2.Text = "MSSV:";
            // 
            // sign
            // 
            this.sign.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.sign.Location = new System.Drawing.Point(122, 487);
            this.sign.Name = "sign";
            this.sign.Size = new System.Drawing.Size(75, 33);
            this.sign.TabIndex = 15;
            this.sign.Text = "Đăng ký";
            this.sign.UseVisualStyleBackColor = true;
            this.sign.Click += new System.EventHandler(this.sign_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(59, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 16;
            this.label3.Text = "Họ và tên:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(53, 188);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(84, 21);
            this.label4.TabIndex = 17;
            this.label4.Text = "Niên khóa:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(104, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(40, 21);
            this.label5.TabIndex = 18;
            this.label5.Text = "Lớp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(80, 292);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 21);
            this.label6.TabIndex = 19;
            this.label6.Text = "Học kỳ:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(65, 346);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(74, 21);
            this.label7.TabIndex = 20;
            this.label7.Text = "Môn học:";
            // 
            // checkList
            // 
            this.checkList.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.checkList.FormattingEnabled = true;
            this.checkList.Location = new System.Drawing.Point(167, 346);
            this.checkList.Name = "checkList";
            this.checkList.Size = new System.Drawing.Size(210, 92);
            this.checkList.TabIndex = 21;
            this.checkList.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // del
            // 
            this.del.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.del.Location = new System.Drawing.Point(230, 487);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(75, 33);
            this.del.TabIndex = 22;
            this.del.Text = "Hủy";
            this.del.UseVisualStyleBackColor = true;
            this.del.Click += new System.EventHandler(this.del_Click);
            // 
            // exit
            // 
            this.exit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exit.Location = new System.Drawing.Point(341, 487);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(75, 33);
            this.exit.TabIndex = 23;
            this.exit.Text = "Thoát";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.semI);
            this.panel1.Controls.Add(this.semII);
            this.panel1.Controls.Add(this.semIII);
            this.panel1.Controls.Add(this.semIV);
            this.panel1.Location = new System.Drawing.Point(167, 292);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(210, 42);
            this.panel1.TabIndex = 24;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(580, 548);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.del);
            this.Controls.Add(this.checkList);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.sign);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.stuID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Đăng ký môn học";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox stuID;
        private TextBox fullName;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton semI;
        private RadioButton semII;
        private RadioButton semIII;
        private RadioButton semIV;
        private Label label2;
        private Button sign;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private CheckedListBox checkList;
        private Button del;
        private Button exit;
        private Panel panel1;
    }
}