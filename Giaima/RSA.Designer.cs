namespace Giaima
{
    partial class RSA
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
            this.txtp = new System.Windows.Forms.TextBox();
            this.txtq = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNhap = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txte = new System.Windows.Forms.TextBox();
            this.txtN = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.txtd = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.txtKetQua = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTestM = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTestResult = new System.Windows.Forms.TextBox();
            this.btnTestMHBM = new System.Windows.Forms.Button();
            this.btnTestGMBM = new System.Windows.Forms.Button();
            this.btnTestMHCT = new System.Windows.Forms.Button();
            this.btnTestGMCT = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTestC = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtp
            // 
            this.txtp.Location = new System.Drawing.Point(60, 50);
            this.txtp.Name = "txtp";
            this.txtp.Size = new System.Drawing.Size(46, 20);
            this.txtp.TabIndex = 0;
            this.txtp.Text = "23";
            // 
            // txtq
            // 
            this.txtq.Location = new System.Drawing.Point(155, 50);
            this.txtq.Name = "txtq";
            this.txtq.Size = new System.Drawing.Size(50, 20);
            this.txtq.TabIndex = 1;
            this.txtq.Text = "41";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "p:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "q:";
            // 
            // txtNhap
            // 
            this.txtNhap.Location = new System.Drawing.Point(61, 16);
            this.txtNhap.Name = "txtNhap";
            this.txtNhap.Size = new System.Drawing.Size(292, 20);
            this.txtNhap.TabIndex = 4;
            this.txtNhap.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Path:";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(27, 128);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(110, 23);
            this.btnMaHoa.TabIndex = 6;
            this.btnMaHoa.Text = "Mã hóa bảo mật";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.btnMaHoa_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(143, 128);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Giải mã bảo mật";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Kết quả:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 87);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Khóa công khai";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(280, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Khóa bí mât";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(369, 14);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 15;
            this.button3.Text = "Chọn file";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(223, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Tạo khóa";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(112, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "e:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(176, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 18;
            this.label8.Text = "N:";
            // 
            // txte
            // 
            this.txte.Location = new System.Drawing.Point(128, 84);
            this.txte.Name = "txte";
            this.txte.Size = new System.Drawing.Size(33, 20);
            this.txte.TabIndex = 19;
            // 
            // txtN
            // 
            this.txtN.Location = new System.Drawing.Point(200, 84);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(32, 20);
            this.txtN.TabIndex = 20;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(416, 87);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(18, 13);
            this.label.TabIndex = 22;
            this.label.Text = "N:";
            // 
            // txtd
            // 
            this.txtd.Location = new System.Drawing.Point(369, 84);
            this.txtd.Name = "txtd";
            this.txtd.Size = new System.Drawing.Size(32, 20);
            this.txtd.TabIndex = 23;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(431, 84);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(28, 20);
            this.txtN2.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(351, 87);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(16, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "d:";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(263, 128);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(113, 23);
            this.button5.TabIndex = 26;
            this.button5.Text = "Mã hóa chứng thực";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(382, 128);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 23);
            this.button6.TabIndex = 27;
            this.button6.Text = "Giải mã chứng thực";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(76, 180);
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(427, 102);
            this.txtKetQua.TabIndex = 28;
            this.txtKetQua.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTestC);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.btnTestGMCT);
            this.groupBox1.Controls.Add(this.btnTestMHCT);
            this.groupBox1.Controls.Add(this.btnTestGMBM);
            this.groupBox1.Controls.Add(this.btnTestMHBM);
            this.groupBox1.Controls.Add(this.txtTestResult);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.txtTestM);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Location = new System.Drawing.Point(521, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(172, 262);
            this.groupBox1.TabIndex = 29;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 34);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(19, 13);
            this.label10.TabIndex = 0;
            this.label10.Text = "M:";
            // 
            // txtTestM
            // 
            this.txtTestM.Location = new System.Drawing.Point(42, 31);
            this.txtTestM.Name = "txtTestM";
            this.txtTestM.Size = new System.Drawing.Size(94, 20);
            this.txtTestM.TabIndex = 1;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(6, 207);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 13);
            this.label11.TabIndex = 2;
            this.label11.Text = "Kết quả:";
            // 
            // txtTestResult
            // 
            this.txtTestResult.Location = new System.Drawing.Point(59, 204);
            this.txtTestResult.Name = "txtTestResult";
            this.txtTestResult.Size = new System.Drawing.Size(97, 20);
            this.txtTestResult.TabIndex = 3;
            // 
            // btnTestMHBM
            // 
            this.btnTestMHBM.Location = new System.Drawing.Point(9, 68);
            this.btnTestMHBM.Name = "btnTestMHBM";
            this.btnTestMHBM.Size = new System.Drawing.Size(70, 23);
            this.btnTestMHBM.TabIndex = 4;
            this.btnTestMHBM.Text = "MHBM";
            this.btnTestMHBM.UseVisualStyleBackColor = true;
            this.btnTestMHBM.Click += new System.EventHandler(this.btnTestMHBM_Click);
            // 
            // btnTestGMBM
            // 
            this.btnTestGMBM.Location = new System.Drawing.Point(10, 146);
            this.btnTestGMBM.Name = "btnTestGMBM";
            this.btnTestGMBM.Size = new System.Drawing.Size(70, 23);
            this.btnTestGMBM.TabIndex = 5;
            this.btnTestGMBM.Text = "GMBM";
            this.btnTestGMBM.UseVisualStyleBackColor = true;
            this.btnTestGMBM.Click += new System.EventHandler(this.btnTestGMBM_Click);
            // 
            // btnTestMHCT
            // 
            this.btnTestMHCT.Location = new System.Drawing.Point(88, 68);
            this.btnTestMHCT.Name = "btnTestMHCT";
            this.btnTestMHCT.Size = new System.Drawing.Size(70, 23);
            this.btnTestMHCT.TabIndex = 6;
            this.btnTestMHCT.Text = "MHCT";
            this.btnTestMHCT.UseVisualStyleBackColor = true;
            this.btnTestMHCT.Click += new System.EventHandler(this.btnTestMHCT_Click);
            // 
            // btnTestGMCT
            // 
            this.btnTestGMCT.Location = new System.Drawing.Point(86, 146);
            this.btnTestGMCT.Name = "btnTestGMCT";
            this.btnTestGMCT.Size = new System.Drawing.Size(70, 23);
            this.btnTestGMCT.TabIndex = 7;
            this.btnTestGMCT.Text = "GMCT";
            this.btnTestGMCT.UseVisualStyleBackColor = true;
            this.btnTestGMCT.Click += new System.EventHandler(this.btnTestGMCT_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(17, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "C:";
            // 
            // txtTestC
            // 
            this.txtTestC.Location = new System.Drawing.Point(42, 111);
            this.txtTestC.Name = "txtTestC";
            this.txtTestC.Size = new System.Drawing.Size(94, 20);
            this.txtTestC.TabIndex = 9;
            // 
            // RSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(705, 293);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtN2);
            this.Controls.Add(this.txtd);
            this.Controls.Add(this.label);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.txte);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNhap);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtq);
            this.Controls.Add(this.txtp);
            this.Name = "RSA";
            this.Text = "RSA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtp;
        private System.Windows.Forms.TextBox txtq;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNhap;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txte;
        private System.Windows.Forms.TextBox txtN;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.TextBox txtd;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.RichTextBox txtKetQua;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnTestGMCT;
        private System.Windows.Forms.Button btnTestMHCT;
        private System.Windows.Forms.Button btnTestGMBM;
        private System.Windows.Forms.Button btnTestMHBM;
        private System.Windows.Forms.TextBox txtTestResult;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTestM;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtTestC;
        private System.Windows.Forms.Label label12;
    }
}