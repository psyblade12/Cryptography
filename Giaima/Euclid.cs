using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaima
{
    public partial class Euclid : Form
    {
        public Euclid()
        {
            InitializeComponent();
        }
        private SoKetQua TinhEuclid(int a, int b)
        {
            SoKetQua kq = new SoKetQua();
            int A1 = 1;
            int A2 = 0;
            int A3 = a;
            int B1 = 0;
            int B2 = 1;
            int B3 = b;
            int Q = 0;
            int R1 = 0;
            int R2 = 0;
            int R3 = 0;
            while (B3 != 0 && B3 != 1)
            {
                Q = A3 / B3;
                R1 = A1 - (Q * B1);
                R2 = A2 - (Q * B2);
                R3 = A3 - (Q * B3);
                A1 = B1;
                A2 = B2;
                A3 = B3;
                B1 = R1;
                B2 = R2;
                B3 = R3;

            }
            if (B3 == 0)
            {
                kq.Ucln = A3;
                kq.Nghichdao = 0;
                return kq;
            }
            else
            {
                kq.Ucln = 1;
                if (B2 < 0)
                {
                    kq.Nghichdao = B2 + a;
                }
                else
                {
                    kq.Nghichdao = B2;
                }
                return kq;
            }

        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SoKetQua a = TinhEuclid(Convert.ToInt32(textBox1.Text), Convert.ToInt32(textBox2.Text));
                textBox3.Text = a.Ucln.ToString();
                textBox4.Text = a.Nghichdao.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi ");
            }
        }
    }
}
