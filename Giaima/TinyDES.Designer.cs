namespace Giaima
{
    partial class TinyDES
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
            this.txtDuongDan = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnMaHoa = new System.Windows.Forms.Button();
            this.txtKhoa = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnGiaiMa = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtKetQuaTest = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnTestGiaiMa = new System.Windows.Forms.Button();
            this.btnTestMaHoa = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtChuoiNhiPhan = new System.Windows.Forms.TextBox();
            this.txtKetQua = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtDuongDan
            // 
            this.txtDuongDan.Location = new System.Drawing.Point(130, 32);
            this.txtDuongDan.Name = "txtDuongDan";
            this.txtDuongDan.Size = new System.Drawing.Size(266, 20);
            this.txtDuongDan.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Path:";
            // 
            // btnMaHoa
            // 
            this.btnMaHoa.Location = new System.Drawing.Point(130, 103);
            this.btnMaHoa.Name = "btnMaHoa";
            this.btnMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnMaHoa.TabIndex = 2;
            this.btnMaHoa.Text = "Mã hóa";
            this.btnMaHoa.UseVisualStyleBackColor = true;
            this.btnMaHoa.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtKhoa
            // 
            this.txtKhoa.Location = new System.Drawing.Point(130, 67);
            this.txtKhoa.Name = "txtKhoa";
            this.txtKhoa.Size = new System.Drawing.Size(266, 20);
            this.txtKhoa.TabIndex = 3;
            this.txtKhoa.Text = "10011010";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Khóa";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(402, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 23);
            this.button2.TabIndex = 5;
            this.button2.Text = "Chọn đường dẫn";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnGiaiMa
            // 
            this.btnGiaiMa.Location = new System.Drawing.Point(226, 103);
            this.btnGiaiMa.Name = "btnGiaiMa";
            this.btnGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnGiaiMa.TabIndex = 6;
            this.btnGiaiMa.Text = "Giải mã";
            this.btnGiaiMa.UseVisualStyleBackColor = true;
            this.btnGiaiMa.Click += new System.EventHandler(this.btnGiaiMa_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(77, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Kết quả";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtKetQuaTest);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnTestGiaiMa);
            this.groupBox1.Controls.Add(this.btnTestMaHoa);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtChuoiNhiPhan);
            this.groupBox1.Location = new System.Drawing.Point(535, 32);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(220, 265);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Test";
            // 
            // txtKetQuaTest
            // 
            this.txtKetQuaTest.Location = new System.Drawing.Point(68, 122);
            this.txtKetQuaTest.Name = "txtKetQuaTest";
            this.txtKetQuaTest.Size = new System.Drawing.Size(134, 20);
            this.txtKetQuaTest.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Kết quả:";
            // 
            // btnTestGiaiMa
            // 
            this.btnTestGiaiMa.Location = new System.Drawing.Point(115, 71);
            this.btnTestGiaiMa.Name = "btnTestGiaiMa";
            this.btnTestGiaiMa.Size = new System.Drawing.Size(75, 23);
            this.btnTestGiaiMa.TabIndex = 3;
            this.btnTestGiaiMa.Text = "TestGM";
            this.btnTestGiaiMa.UseVisualStyleBackColor = true;
            this.btnTestGiaiMa.Click += new System.EventHandler(this.btnTestGiaiMa_Click);
            // 
            // btnTestMaHoa
            // 
            this.btnTestMaHoa.Location = new System.Drawing.Point(34, 71);
            this.btnTestMaHoa.Name = "btnTestMaHoa";
            this.btnTestMaHoa.Size = new System.Drawing.Size(75, 23);
            this.btnTestMaHoa.TabIndex = 2;
            this.btnTestMaHoa.Text = "TestMH";
            this.btnTestMaHoa.UseVisualStyleBackColor = true;
            this.btnTestMaHoa.Click += new System.EventHandler(this.btnTestMaHoa_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(15, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Chuỗi nhị phân:";
            // 
            // txtChuoiNhiPhan
            // 
            this.txtChuoiNhiPhan.Location = new System.Drawing.Point(102, 31);
            this.txtChuoiNhiPhan.Name = "txtChuoiNhiPhan";
            this.txtChuoiNhiPhan.Size = new System.Drawing.Size(100, 20);
            this.txtChuoiNhiPhan.TabIndex = 0;
            this.txtChuoiNhiPhan.Text = "01011100";
            // 
            // txtKetQua
            // 
            this.txtKetQua.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKetQua.Location = new System.Drawing.Point(132, 172);
            this.txtKetQua.Multiline = true;
            this.txtKetQua.Name = "txtKetQua";
            this.txtKetQua.Size = new System.Drawing.Size(387, 139);
            this.txtKetQua.TabIndex = 11;
            // 
            // TinyDES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 318);
            this.Controls.Add(this.txtKetQua);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnGiaiMa);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKhoa);
            this.Controls.Add(this.btnMaHoa);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuongDan);
            this.Name = "TinyDES";
            this.Text = "TinyDES";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDuongDan;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnMaHoa;
        private System.Windows.Forms.TextBox txtKhoa;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnGiaiMa;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtKetQuaTest;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnTestGiaiMa;
        private System.Windows.Forms.Button btnTestMaHoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtChuoiNhiPhan;
        private System.Windows.Forms.TextBox txtKetQua;
    }
}