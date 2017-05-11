using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Giaima
{
    public partial class RSA : Form
    {
        public RSA()
        {
            InitializeComponent();
        }
        string duongdanfile;
        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        
        private void btnMaHoa_Click(object sender, EventArgs e1)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    string ketqua = "";
                    int e = Convert.ToInt32(txte.Text);
                    int N = Convert.ToInt32(txtN.Text);
                    String line = sr.ReadToEnd();
                    string textnhapvao = line;
                    char[] mangchar = line.ToCharArray();
                    List<int> mangso = new List<int>();
                    foreach (char c in mangchar)
                    {
                        mangso.Add(Convert.ToInt32(c));
                    }
                    foreach (int i in mangso)
                    {
                        int soketquagiaima = GiaiThuat.MaHoaBaoMatRSA(e, N, i);
                        char charduocmahoa = (char)soketquagiaima;
                        ketqua = ketqua + charduocmahoa;
                    }
                    txtKetQua.Text = ketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button1_Click(object sender, EventArgs e1)
        {
            try
            {
                int p = Convert.ToInt32(txtp.Text);
                int q = Convert.ToInt32(txtq.Text);
                Khoa khoacongkhai = new Khoa();
                Khoa khoabimat = new Khoa();
                int N = p * q;
                int n = (p - 1) * (q - 1);
                int e = 0;
                for (int i = 2; i < n; i++)
                {
                    SoKetQua kq = GiaiThuat.TinhEuclid(i, n);
                    if (kq.Ucln == 1)
                    {
                        e = i;
                        break;
                    }
                    else
                    {
                        continue;
                    }
                }
                int d = GiaiThuat.TinhEuclid(n, e).Nghichdao;
                txte.Text = e.ToString();
                txtN.Text = N.ToString();
                txtd.Text = d.ToString();
                txtN2.Text = N.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    duongdanfile = openFileDialog1.FileName;
                    txtNhap.Text = duongdanfile;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ketqua = GiaiThuat.GiaiMaChungThucRSA(Convert.ToInt32(txte.Text), Convert.ToInt32(txtN.Text), 27);
            MessageBox.Show(ketqua.ToString());
        }

        private void button2_Click(object sender, EventArgs e1)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    string ketqua = "";
                    int d = Convert.ToInt32(txtd.Text);
                    int N = Convert.ToInt32(txtN.Text);
                    String line = sr.ReadToEnd();
                    string textnhapvao = line;
                    char[] mangchar = line.ToCharArray();
                    List<int> mangso = new List<int>();
                    foreach (char c in mangchar)
                    {
                        mangso.Add(Convert.ToInt32(c));
                    }
                    foreach (int i in mangso)
                    {
                        int soketquagiaima = GiaiThuat.GiaiMaBaoMatRSA(d, N, i);
                        char charduocmahoa = (char)soketquagiaima;
                        ketqua = ketqua + charduocmahoa;
                    }
                    txtKetQua.Text = ketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button5_Click(object sender, EventArgs e1)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    string ketqua = "";
                    int d = Convert.ToInt32(txtd.Text);
                    int N = Convert.ToInt32(txtN2.Text);
                    String line = sr.ReadToEnd();
                    string textnhapvao = line;
                    char[] mangchar = line.ToCharArray();
                    List<int> mangso = new List<int>();
                    foreach (char c in mangchar)
                    {
                        mangso.Add(Convert.ToInt32(c));
                    }
                    foreach (int i in mangso)
                    {
                        int soketquagiaima = GiaiThuat.MaHoaChungThucRSA(d, N, i);
                        char charduocmahoa = (char)soketquagiaima;
                        ketqua = ketqua + charduocmahoa;
                    }
                    txtKetQua.Text = ketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void button6_Click(object sender, EventArgs e1)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    string ketqua = "";
                    int e = Convert.ToInt32(txte.Text);
                    int N = Convert.ToInt32(txtN.Text);
                    String line = sr.ReadToEnd();
                    string textnhapvao = line;
                    char[] mangchar = line.ToCharArray();
                    List<int> mangso = new List<int>();
                    foreach (char c in mangchar)
                    {
                        mangso.Add(Convert.ToInt32(c));
                    }
                    foreach (int i in mangso)
                    {
                        int soketquagiaima = GiaiThuat.GiaiMaChungThucRSA(e, N, i);
                        char charduocmahoa = (char)soketquagiaima;
                        ketqua = ketqua + charduocmahoa;
                    }
                    txtKetQua.Text = ketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }

        private void btnTestMHBM_Click(object sender, EventArgs e1)
        {
            try
            {
                int M = Convert.ToInt32(txtTestM.Text);
                int e = Convert.ToInt32(txte.Text);
                int N = Convert.ToInt32(txtN.Text);
                int soketqua = GiaiThuat.MaHoaBaoMatRSA(e, N, M);
                txtTestResult.Text = soketqua.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void btnTestMHCT_Click(object sender, EventArgs e1)
        {
            try
            {
                int M = Convert.ToInt32(txtTestM.Text);
                int d = Convert.ToInt32(txtd.Text);
                int N = Convert.ToInt32(txtN.Text);
                int soketqua = GiaiThuat.MaHoaChungThucRSA(d, N, M);
                txtTestResult.Text = soketqua.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void btnTestGMCT_Click(object sender, EventArgs e1)
        {
            try
            {
                int C = Convert.ToInt32(txtTestC.Text);
                int e = Convert.ToInt32(txte.Text);
                int N = Convert.ToInt32(txtN.Text);
                int soketqua = GiaiThuat.GiaiMaChungThucRSA(e, N, C);
                txtTestResult.Text = soketqua.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void btnTestGMBM_Click(object sender, EventArgs e)
        {
            try
            {
                int C = Convert.ToInt32(txtTestC.Text);
                int d = Convert.ToInt32(txtd.Text);
                int N = Convert.ToInt32(txtN.Text);
                int soketqua = GiaiThuat.GiaiMaChungThucRSA(d, N, C);
                txtTestResult.Text = soketqua.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }
    }
}
