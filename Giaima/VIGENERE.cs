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
    public partial class VIGENERE : Form
    {
        public VIGENERE()
        {
            InitializeComponent();
        }

        private void VIGENERE_Load(object sender, EventArgs e)
        {

        }
        public int DoiChuThanhSo(string chu)
        {
            if (chu == "A")
                return 0;
            if (chu == "B")
                return 1;
            if (chu == "C")
                return 2;
            if (chu == "D")
                return 3;
            if (chu == "E")
                return 4;
            if (chu == "F")
                return 5;
            if (chu == "G")
                return 6;
            if (chu == "H")
                return 7;
            if (chu == "I")
                return 8;
            if (chu == "J")
                return 9;
            if (chu == "K")
                return 10;
            if (chu == "L")
                return 11;
            if (chu == "M")
                return 12;
            if (chu == "N")
                return 13;
            if (chu == "O")
                return 14;
            if (chu == "P")
                return 15;
            if (chu == "Q")
                return 16;
            if (chu == "R")
                return 17;
            if (chu == "S")
                return 18;
            if (chu == "T")
                return 19;
            if (chu == "U")
                return 20;
            if (chu == "V")
                return 21;
            if (chu == "W")
                return 22;
            if (chu == "X")
                return 23;
            if (chu == "Y")
                return 24;
            if (chu == "Z")
                return 25;
            else
                return 0;
        }

        public String DoiSoThanhChu(int so)
        {
            if (so == -1)
                return "Z";
            if (so == -2)
                return "Y";
            if (so == -3)
                return "X";
            if (so == -4)
                return "W";
            if (so == -5)
                return "V";
            if (so == -6)
                return "U";
            if (so == -7)
                return "T";
            if (so == -8)
                return "S";
            if (so == -9)
                return "R";
            if (so == -10)
                return "Q";
            if (so == -11)
                return "P";
            if (so == -12)
                return "O";
            if (so == -13)
                return "N";
            if (so == -14)
                return "M";
            if (so == -15)
                return "L";
            if (so == -16)
                return "K";
            if (so == -17)
                return "J";
            if (so == -18)
                return "I";
            if (so == -19)
                return "H";
            if (so == -20)
                return "G";
            if (so == -21)
                return "F";
            if (so == -22)
                return "E";
            if (so == -23)
                return "D";
            if (so == -24)
                return "C";
            if (so == -25)
                return "B";
            if (so == -26)
                return "A";
            if (so == 0)
                return "A";
            if (so == 1)
                return "B";
            if (so == 2)
                return "C";
            if (so == 3)
                return "D";
            if (so == 4)
                return "E";
            if (so == 5)
                return "F";
            if (so == 6)
                return "G";
            if (so == 7)
                return "H";
            if (so == 8)
                return "I";
            if (so == 9)
                return "J";
            if (so == 10)
                return "K";
            if (so == 11)
                return "L";
            if (so == 12)
                return "M";
            if (so == 13)
                return "N";
            if (so == 14)
                return "O";
            if (so == 15)
                return "P";
            if (so == 16)
                return "Q";
            if (so == 17)
                return "R";
            if (so == 18)
                return "S";
            if (so == 19)
                return "T";
            if (so == 20)
                return "U";
            if (so == 21)
                return "V";
            if (so == 22)
                return "W";
            if (so == 23)
                return "X";
            if (so == 24)
                return "Y";
            if (so == 25)
                return "Z";
            else
                return "?";

        }
        static string[] mangnhapvao = new string[100];
        static string[] mangchuakey = new string[100];
        static string[] mangchuaketqua = new string[100];
        static string chuoinhapvao;
        static string chuoiketqua;
        static string key;
        static string chuoikey;
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                chuoinhapvao = textBox1.Text;
                chuoinhapvao = chuoinhapvao.ToUpper();
                int[] vitrispacebar = new int[100];

                for (int i = 0; i < chuoinhapvao.Length; i++)
                {
                    if (chuoinhapvao.IndexOf(" ") != -1)
                    {
                        int tam = chuoinhapvao.IndexOf(" ");
                        vitrispacebar[i] = tam;
                        chuoinhapvao = chuoinhapvao.Remove(tam, 1);
                        chuoinhapvao = chuoinhapvao.Insert(tam, "-");
                    }

                }
                string chuoivitrispace = "";
                for (int i = 0; i < 100; i++)
                {
                    chuoivitrispace = chuoivitrispace + vitrispacebar[i];
                }

                chuoivitrispace = "";
                chuoinhapvao = chuoinhapvao.Replace("-", "");
                chuoikey = "";
                chuoiketqua = "";
                key = textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text;
                key = key.ToUpper();
                int dodaichuoinhapvao = chuoinhapvao.Length;
                int dodaichuoikey = key.Length;
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangnhapvao[i] = chuoinhapvao.Substring(i, 1);
                }
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangchuakey[i] = key.Substring(i, 1);
                }
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangchuaketqua[i] = DoiSoThanhChu((DoiChuThanhSo(mangnhapvao[i]) - DoiChuThanhSo(mangchuakey[i])) % 26);
                }
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    chuoiketqua = chuoiketqua + mangchuaketqua[i];
                }
                for (int i = 0; i < 100; i++)
                {
                    if (vitrispacebar[i] != 0)
                    {
                        chuoiketqua = chuoiketqua.Insert(vitrispacebar[i], " ");
                    }
                }
                textBox3.Text = chuoiketqua;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                chuoinhapvao = textBox1.Text;
                chuoinhapvao = chuoinhapvao.ToUpper();
                int[] vitrispacebar = new int[100];

                for (int i = 0; i < chuoinhapvao.Length; i++)
                {
                    if (chuoinhapvao.IndexOf(" ") != -1)
                    {
                        int tam = chuoinhapvao.IndexOf(" ");
                        vitrispacebar[i] = tam;
                        chuoinhapvao = chuoinhapvao.Remove(tam, 1);
                        chuoinhapvao = chuoinhapvao.Insert(tam, "-");
                    }

                }
                string chuoivitrispace = "";
                for (int i = 0; i < 100; i++)
                {
                    chuoivitrispace = chuoivitrispace + vitrispacebar[i];
                }

                chuoivitrispace = "";
                chuoinhapvao = chuoinhapvao.Replace("-", "");
                chuoikey = "";
                chuoiketqua = "";
                key = textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text + textBox2.Text;
                key = key.ToUpper();
                int dodaichuoinhapvao = chuoinhapvao.Length;
                int dodaichuoikey = key.Length;
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangnhapvao[i] = chuoinhapvao.Substring(i, 1);
                }
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangchuakey[i] = key.Substring(i, 1);
                }

                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    mangchuaketqua[i] = DoiSoThanhChu((DoiChuThanhSo(mangnhapvao[i]) + DoiChuThanhSo(mangchuakey[i])) % 26);
                }
                for (int i = 0; i < dodaichuoinhapvao; i = i + 1)
                {
                    chuoiketqua = chuoiketqua + mangchuaketqua[i];
                }
                for (int i = 0; i < 100; i++)
                {
                    if (vitrispacebar[i] != 0)
                    {
                        chuoiketqua = chuoiketqua.Insert(vitrispacebar[i], " ");
                    }
                }
                textBox3.Text = chuoiketqua;
            }
            catch
            {
                MessageBox.Show("Có lỗi xảy ra");
            }
        }
    }
}
