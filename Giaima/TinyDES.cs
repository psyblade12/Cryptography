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
    public partial class TinyDES : Form
    {
        public TinyDES()
        {
            InitializeComponent();
        }
        string duongdanfile;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    String line = sr.ReadToEnd();
                    MessageBox.Show(line);
                    string khoa = txtKhoa.Text;
                    char[] cackitumuonmahoa = line.ToCharArray();
                    string chuoiketqua = "";
                    foreach (char s in cackitumuonmahoa)
                    {
                        chuoiketqua = chuoiketqua + GiaiThuatTinyDES.MaHoaTinyDES2(s, khoa);
                    }
                    txtKetQua.Text = chuoiketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra rồi.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK)
                {
                    duongdanfile = openFileDialog1.FileName;
                    txtDuongDan.Text = duongdanfile;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void btnGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    String line = sr.ReadToEnd();
                    string khoa = txtKhoa.Text;
                    char[] cackitumuonmahoa = line.ToCharArray();
                    string chuoiketqua = "";
                    foreach (char s in cackitumuonmahoa)
                    {
                        chuoiketqua = chuoiketqua + GiaiThuatTinyDES.GiaiMaTinyDES2(s, khoa);
                    }
                    txtKetQua.Text = chuoiketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnTestMaHoa_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoinhiphan = txtChuoiNhiPhan.Text;
                string khoa = txtKhoa.Text;
                string ketqua = GiaiThuatTinyDES.MaHoaTinyDESTest(chuoinhiphan, khoa);
                txtKetQuaTest.Text = ketqua;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void btnTestGiaiMa_Click(object sender, EventArgs e)
        {
            try
            {
                string chuoinhiphan = txtChuoiNhiPhan.Text;
                string khoa = txtKhoa.Text;
                string ketqua = GiaiThuatTinyDES.GiaiMaTinyDesTest(chuoinhiphan, khoa);
                txtKetQuaTest.Text = ketqua;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }
    }
}
