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
    public partial class A51 : Form
    {
        public A51()
        {
            InitializeComponent();
        }
        public static string ChuyenThanhDecima8KiTu(string chuoidecima)
        {
            string ketqua = chuoidecima;
            int demsokituconthieu = 8 - chuoidecima.Length;
            if (demsokituconthieu > 0)
            {
                ketqua = "0" + ketqua;
                if (ketqua.Length < 8)
                {
                    ketqua = ChuyenThanhDecima8KiTu(ketqua);
                }
            }
            return ketqua;
        }
        public static string ChuyenThanhDecima16KiTu(string chuoidecima)
        {
            string ketqua = chuoidecima;
            int demsokituconthieu = 16 - chuoidecima.Length;
            if (demsokituconthieu > 0)
            {
                ketqua = "0" + ketqua;
                if (ketqua.Length < 16)
                {
                    ketqua = ChuyenThanhDecima16KiTu(ketqua);
                }
            }
            return ketqua;
        }
        private string ChuyenKiTuThanhNhiPhan(char kitu)
        {
            int sodecima = Convert.ToInt32(kitu);
            string chuoinhiphan = Convert.ToString(sodecima, 2);
            chuoinhiphan = ChuyenThanhDecima16KiTu(chuoinhiphan);
            return chuoinhiphan;
        }
        public string ChuyenNhiPhanThanhKiTu(string binary)
        {
            int sodecima = Convert.ToInt32(binary, 2);
            char kitu = Convert.ToChar(sodecima);
            return kitu.ToString();
        }
        private char Major(char a, char b, char c)
        {
            char ketqua = '0';
            int dem1 = 0;
            if (a == '1')
            {
                dem1 = dem1 + 1;
            }
            if (b == '1')
            {
                dem1 = dem1 + 1;
            }
            if (c == '1')
            {
                dem1 = dem1 + 1;
            }

            if (dem1 >= 2)
            {
                ketqua = '1';
            }
            return ketqua;
        }
        private char SoSanh(char a, char b)
        {
            char ketqua = '1';
            if (a=='1' && b =='1')
            {
                ketqua = '0';
            }
            else if(a == '0' && b=='0')
            {
                ketqua = '0';
            }
            else
            {
                ketqua = '1';
            }
            return ketqua;
        }
        private void QuayX(ref char[] mangthanhghiX)
        {
            char t= SoSanh(mangthanhghiX[13], mangthanhghiX[16]);
            t = SoSanh(t, mangthanhghiX[17]);
            t = SoSanh(t, mangthanhghiX[18]);
            for(int i=18; i>0; i--)
            {
                mangthanhghiX[i] = mangthanhghiX[i - 1];
            }
            mangthanhghiX[0] = t;
        }
        private void QuayY(ref char[] mangthanhghiY)
        {
            char t = SoSanh(mangthanhghiY[20], mangthanhghiY[21]);
            for (int i = 21; i > 0; i--)
            {
                mangthanhghiY[i] = mangthanhghiY[i - 1];
            }
            mangthanhghiY[0] = t;
        }
        private void QuayZ(ref char[] mangthanhghiZ)
        {
            char t = SoSanh(mangthanhghiZ[7], mangthanhghiZ[20]);
            t = SoSanh(t, mangthanhghiZ[21]);
            t = SoSanh(t, mangthanhghiZ[22]);
            for (int i = 22; i > 0; i--)
            {
                mangthanhghiZ[i] = mangthanhghiZ[i - 1];
            }
            mangthanhghiZ[0] = t;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string stringketqua = "";
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    #region docfile
                    String line = sr.ReadToEnd();
                    string thanhghixyz = txtXYZ.Text;
                    #endregion
                    #region Chuan bi cac thanh ghi
                    string thanhghiX = thanhghixyz.Substring(0, 19);
                    string thanhghiY = thanhghixyz.Substring(19, 22);
                    string thanhghiZ = thanhghixyz.Substring(41, 23);
                    char[] mangthanhghiX = thanhghiX.ToCharArray();
                    char[] mangthanhghiY = thanhghiY.ToCharArray();
                    char[] mangthanhghiZ = thanhghiZ.ToCharArray();
                    string textnhapvao = line;
                    char[] mangchuatextnhapvao = textnhapvao.ToCharArray();
                    string[] mangchuanhiphan = new string[textnhapvao.Length];
                    StringBuilder strb = new StringBuilder();

                    #endregion
                    for (int i = 0; i < mangchuatextnhapvao.Length; i++)
                    {
                        mangchuanhiphan[i] = ChuyenKiTuThanhNhiPhan(mangchuatextnhapvao[i]);
                    }
                    for (int i = 0; i < mangchuanhiphan.Length; i++)
                    {
                        string Xtam = new string(mangthanhghiX);
                        char[] mangthanhghiXtam = Xtam.ToCharArray();
                        string Ytam = new string(mangthanhghiY);
                        char[] mangthanhghiYtam = Ytam.ToCharArray();
                        string Ztam = new string(mangthanhghiZ);
                        char[] mangthanhghiZtam = Ztam.ToCharArray();
                        char[] mangnhiphandaidienkitu = mangchuanhiphan[i].ToCharArray();
                        for (int j = 0; j < 16; j++)
                        {
                            char s = mangnhiphandaidienkitu[j];
                            char m = Major(mangthanhghiXtam[8], mangthanhghiYtam[10], mangthanhghiZtam[10]);
                            if (mangthanhghiXtam[8] == m)
                            {
                                QuayX(ref mangthanhghiXtam);
                            }
                            if (mangthanhghiYtam[10] == m)
                            {
                                QuayY(ref mangthanhghiYtam);
                            }
                            if (mangthanhghiZtam[10] == m)
                            {
                                QuayZ(ref mangthanhghiZtam);
                            }
                            //char si = Major(mangthanhghiX[18], mangthanhghiY[21], mangthanhghiZ[22]);
                            char si = SoSanh(mangthanhghiXtam[18], mangthanhghiYtam[21]);
                            si = SoSanh(si, mangthanhghiZtam[22]);
                            key = key + si;
                            mangnhiphandaidienkitu[j] = SoSanh(s, si);
                        }
                        dskey.Add(key);
                        key = "";
                        string ketqua = new string(mangnhiphandaidienkitu);
                        mangchuanhiphan[i] = ketqua;
                    }
                    List<string> kitu = new List<string>();

                    foreach (string s in mangchuanhiphan)
                    {
                        stringketqua = stringketqua + ChuyenNhiPhanThanhKiTu(s);
                        kitu.Add(ChuyenNhiPhanThanhKiTu(s));
                    }
                    txtXuat.Text = stringketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        List<string> dskey  = new List<string>();
        string key;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string stringketqua = "";
                using (StreamReader sr = new StreamReader(duongdanfile))
                {
                    #region docfile
                    String line = sr.ReadToEnd();
                    string thanhghixyz = txtXYZ.Text;
                    #endregion
                    #region Chuan bi cac thanh ghi
                    string thanhghiX = thanhghixyz.Substring(0, 19);
                    string thanhghiY = thanhghixyz.Substring(19, 22);
                    string thanhghiZ = thanhghixyz.Substring(41, 23);
                    char[] mangthanhghiX = thanhghiX.ToCharArray();
                    char[] mangthanhghiY = thanhghiY.ToCharArray();
                    char[] mangthanhghiZ = thanhghiZ.ToCharArray();
                    string textnhapvao = line;
                    char[] mangchuatextnhapvao = textnhapvao.ToCharArray();
                    string[] mangchuanhiphan = new string[textnhapvao.Length];
                    StringBuilder strb = new StringBuilder();

                    #endregion
                    for (int i = 0; i < mangchuatextnhapvao.Length; i++)
                    {
                        mangchuanhiphan[i] = ChuyenKiTuThanhNhiPhan(mangchuatextnhapvao[i]);
                    }
                    for (int i = 0; i < mangchuanhiphan.Length; i++)
                    {
                        string Xtam = new string(mangthanhghiX);
                        char[] mangthanhghiXtam = Xtam.ToCharArray();
                        string Ytam = new string(mangthanhghiY);
                        char[] mangthanhghiYtam = Ytam.ToCharArray();
                        string Ztam = new string(mangthanhghiZ);
                        char[] mangthanhghiZtam = Ztam.ToCharArray();
                        char[] mangnhiphandaidienkitu = mangchuanhiphan[i].ToCharArray();
                        for (int j = 0; j < 16; j++)
                        {
                            char s = mangnhiphandaidienkitu[j];
                            char m = Major(mangthanhghiXtam[8], mangthanhghiYtam[10], mangthanhghiZtam[10]);
                            if (mangthanhghiXtam[8] == m)
                            {
                                QuayX(ref mangthanhghiXtam);
                            }
                            if (mangthanhghiYtam[10] == m)
                            {
                                QuayY(ref mangthanhghiYtam);
                            }
                            if (mangthanhghiZtam[10] == m)
                            {
                                QuayZ(ref mangthanhghiZtam);
                            }
                            //char si = Major(mangthanhghiX[18], mangthanhghiY[21], mangthanhghiZ[22]);
                            char si = SoSanh(mangthanhghiXtam[18], mangthanhghiYtam[21]);
                            si = SoSanh(si, mangthanhghiZtam[22]);
                            key = key + si;
                            mangnhiphandaidienkitu[j] = SoSanh(s, si);
                        }
                        dskey.Add(key);
                        key = "";
                        string ketqua = new string(mangnhiphandaidienkitu);
                        mangchuanhiphan[i] = ketqua;
                    }
                    List<string> kitu = new List<string>();

                    foreach (string s in mangchuanhiphan)
                    {
                        stringketqua = stringketqua + ChuyenNhiPhanThanhKiTu(s);
                        kitu.Add(ChuyenNhiPhanThanhKiTu(s));
                    }
                    txtXuat.Text = stringketqua;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void txtNhap_TextChanged(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        string duongdanfile;
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult result = openFileDialog1.ShowDialog();
                if (result == DialogResult.OK) // Test result.
                {
                    duongdanfile = openFileDialog1.FileName;
                    txtNhap.Text = duongdanfile;
                }
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void openFileDialog2_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void btnTestMHGM_Click(object sender, EventArgs e)
        {
            try
            {
                string stringketqua = "";
                string thanhghixyz = txtXYZ.Text;
                string thanhghiX = thanhghixyz.Substring(0, 19);
                string thanhghiY = thanhghixyz.Substring(19, 22);
                string thanhghiZ = thanhghixyz.Substring(41, 23);
                char[] mangthanhghiX = thanhghiX.ToCharArray();
                char[] mangthanhghiY = thanhghiY.ToCharArray();
                char[] mangthanhghiZ = thanhghiZ.ToCharArray();

                string Xtam = new string(mangthanhghiX);
                char[] mangthanhghiXtam = Xtam.ToCharArray();
                string Ytam = new string(mangthanhghiY);
                char[] mangthanhghiYtam = Ytam.ToCharArray();
                string Ztam = new string(mangthanhghiZ);
                char[] mangthanhghiZtam = Ztam.ToCharArray();
                labelTrack.Text = "X=" + Xtam + " Y=" + Ytam + " Z= " + Ztam + "\r\n";
                string textnhapvao = txtTestP.Text;
                char[] mangchartextnhapvao = textnhapvao.ToCharArray();
                for (int j = 0; j < mangchartextnhapvao.Length; j++)
                {
                    labelTrack.Text = labelTrack.Text + " Đang xử lý kí tự " + j + "\r\n";
                    char s = mangchartextnhapvao[j];
                    char m = Major(mangthanhghiXtam[8], mangthanhghiYtam[10], mangthanhghiZtam[10]);
                    labelTrack.Text = labelTrack.Text + "Major = " + m.ToString() + "\r\n";
                    if (mangthanhghiXtam[8] == m)
                    {
                        labelTrack.Text = labelTrack.Text + "X8 = " + mangthanhghiXtam[8] + " = Major " + m + "=> Quay X" + "\r\n";
                        QuayX(ref mangthanhghiXtam);
                    }
                    if (mangthanhghiYtam[10] == m)
                    {
                        labelTrack.Text = labelTrack.Text + "Y10 = " + mangthanhghiYtam[10] + " = Major " + m + "=> Quay Y" + "\r\n";
                        QuayY(ref mangthanhghiYtam);
                    }
                    if (mangthanhghiZtam[10] == m)
                    {
                        labelTrack.Text = labelTrack.Text + "Z10 = " + mangthanhghiZtam[10] + " = Major " + m + "=> Quay Z" + "\r\n";
                        QuayZ(ref mangthanhghiZtam);
                    }
                    //char si = Major(mangthanhghiX[18], mangthanhghiY[21], mangthanhghiZ[22]);
                    char si = SoSanh(mangthanhghiXtam[18], mangthanhghiYtam[21]);
                    si = SoSanh(si, mangthanhghiZtam[22]);
                    labelTrack.Text = labelTrack.Text + mangthanhghiXtam[18] + " xor " + mangthanhghiYtam[21] + " xor " + mangthanhghiZtam[22] + " = " + si + "\r\n";
                    key = key + si;
                    mangchartextnhapvao[j] = SoSanh(s, si);
                    labelTrack.Text = labelTrack.Text + " xor với kí tự " + j + " của chuỗi là " + s + " = " + mangchartextnhapvao[j] + "\r\n";
                    string Xhientai = new string(mangthanhghiXtam);
                    string Yhientai = new string(mangthanhghiYtam);
                    string Zhientai = new string(mangthanhghiZtam);
                    labelTrack.Text = labelTrack.Text + "thanh ghi X hiện tại là: " + Xhientai + " thanh ghi Y hiện tại là: " + Yhientai + " thanh ghi Z hiện tại = " + Zhientai + "\r\n \r\n";
                }

                foreach (char s in mangchartextnhapvao)
                {
                    stringketqua = stringketqua + s;
                }
                txtTestC.Text = stringketqua;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }
    }
}
