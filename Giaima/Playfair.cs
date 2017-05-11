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
    public partial class Playfair : Form
    {
        public Playfair()
        {
            InitializeComponent();
        }
        public bool timtrongmang5x5(char[,] mang5x5, char kitumuontimkiem)
        {
            bool ketqua = false;
            for(int i=0; i<5; i++)
            {
                for (int j =0; j<5; j++)
                {
                    if (mang5x5[i,j] == kitumuontimkiem)
                    {
                        ketqua = true;
                    }
                }
            }
            return ketqua;
        }

        public string themx(string chuoi)
        {
            string ketqua = chuoi;
            if (ketqua.Length % 2 == 0)
            {
                for (int i = 0; i < chuoi.Length; i = i + 2)
                {
                    if (ketqua.Substring(i, 1) == ketqua.Substring(i + 1, 1))
                    {
                        ketqua = ketqua.Insert(i + 1, "X");
                    }
                }
            }
            else
            {
                ketqua = ketqua +"Z";
                for (int i = 0; i < chuoi.Length; i = i + 2)
                {
                    if (ketqua.Substring(i, 1) == ketqua.Substring(i + 1, 1))
                    {
                        ketqua = ketqua.Insert(i + 1, "X");
                    }
                }
                ketqua = ketqua.Substring(0, ketqua.Length - 1);
            }
            
            
            return ketqua;
        }

        //Function lấy số dòng
        public int laysodongtrongmang5x5(char[,] mang5x5, char kitumuontimkiem)
        {
            int ketqua = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mang5x5[i, j] == kitumuontimkiem)
                    {
                        ketqua = i;
                        break;
                    }
                }
            }
            return ketqua;
        }

        //Function lấy số cột
        public int laysocottrongmang5x5(char[,] mang5x5, char kitumuontimkiem)
        {
            int ketqua = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (mang5x5[i, j] == kitumuontimkiem)
                    {
                        ketqua = j;
                        break;
                    }
                }
            }
            return ketqua;
        }

        private void btnEncode_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder strb = new StringBuilder();
                string chuoivuanhapvvao = txtChuoiNhapVao.Text;
                int demmangspacebar = 0;
                int[] mangluuvitrispacebar = new int[100];
                for(int i=0; i<chuoivuanhapvvao.Length; i++)
                {
                    if(chuoivuanhapvvao.Substring(i,1) == " ")
                    {
                        mangluuvitrispacebar[demmangspacebar] = i;
                        demmangspacebar = demmangspacebar + 1;
                    }
                }
                chuoivuanhapvvao = chuoivuanhapvvao.Replace(" ", "");
                chuoivuanhapvvao = chuoivuanhapvvao.ToUpper();
                chuoivuanhapvvao= chuoivuanhapvvao.Replace("J", "I");
                chuoivuanhapvvao = themx(chuoivuanhapvvao);
                if (chuoivuanhapvvao.Length % 2 != 0)
                {
                    chuoivuanhapvvao = chuoivuanhapvvao + "Z";
                }
                string key = txtKey.Text;
                key = key.ToUpper();
                char[] arr;
                arr = key.ToCharArray();
                //Duyệt thử mảng array chứa key mới nhập vào
                //foreach (char s in arr)
                //{
                //    strb.Append(s);
                //    strb.Append(" ");
                //}
                //textBox1.Text = strb.ToString();
                char[,] mang5x5 = new char[5, 5];
                int dem = 0;
                for(int i = 0; i<5; i++)
                {
                    for(int j = 0; j<5; j++)
                    {
                        if(dem<arr.Length)
                        {
                            mang5x5[i, j] = arr[dem];
                            dem = dem + 1;
                        }
                        else
                        {
                            mang5x5[i, j] = '?';
                        }
                    }
                }
                string bangchucai = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
                //char[] arrBangChucai;
                //arrBangChucai = bangchucai.ToCharArray();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if( bangchucai.IndexOf(mang5x5[i,j]) != -1)
                        {
                            bangchucai = bangchucai.Replace(mang5x5[i, j], ' ');
                        }
                    }
                }
                bangchucai = bangchucai.Replace(" ", "");
                dem = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (mang5x5[i,j] == '?')
                        {
                            mang5x5[i, j] = Convert.ToChar(bangchucai.Substring(dem,1));
                            dem = dem + 1;
                        }
                    }
                }
                strb.Clear();
                for (int i =0; i<chuoivuanhapvvao.Length; i = i+2)
                {
                    int dongcuaso1 = laysodongtrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i, 1)));
                    int cotcuaso1 = laysocottrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i, 1)));
                    int dongcuaso2 = laysodongtrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i+1, 1)));
                    int cotcuaso2 = laysocottrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i + 1, 1)));
                    if (dongcuaso1 == dongcuaso2)
                    {
                        cotcuaso1 = cotcuaso1 + 1;
                        if (cotcuaso1 > 4)
                            cotcuaso1 = 0;
                        cotcuaso2 = cotcuaso2 + 1;
                        if (cotcuaso2 > 4)
                            cotcuaso2 = 0;
                    }
                    else if (cotcuaso1 == cotcuaso2)
                    {
                        dongcuaso1 = dongcuaso1 + 1;
                        if (dongcuaso1 > 4)
                            dongcuaso1 = 0;
                        dongcuaso2 = dongcuaso2 + 1;
                        if (dongcuaso2 > 4)
                            dongcuaso2 = 0;
                    }
                    else
                    {

                        int tam = cotcuaso1;
                        cotcuaso1 = cotcuaso2;
                        cotcuaso2 = tam;
                    }
                    strb.Append(mang5x5[dongcuaso1,cotcuaso1]);
                    strb.Append(mang5x5[dongcuaso2,cotcuaso2]);
                }
                string ketquamahoa = strb.ToString();
                for(int i = 0; i<100; i++)
                {
                    if(mangluuvitrispacebar[i] !=0)
                    {
                        ketquamahoa =  ketquamahoa.Insert(mangluuvitrispacebar[i], " ");
                    }
                }
                
                textBox1.Text = ketquamahoa;
                //Duyệt mảng 5x5
                //for (int i =0; i<5; i++)
                //{
                //    for (int j=0; j<5; j++)
                //    {
                //        strb.Append(mang5x5[i,j]);
                //        strb.Append(" ");
                //    }
                //    strb.AppendLine();
                ////}
                //string x = laysodongtrongmang5x5(mang5x5,'Y').ToString();
                //x = x + laysocottrongmang5x5(mang5x5, 'Y').ToString();
                //textBox1.Text =x;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi \r\n" + ex);
            }
        }

        private void btnDecode_Click(object sender, EventArgs e)
        {
            try
            {
                StringBuilder strb = new StringBuilder();
                string chuoivuanhapvvao = txtChuoiNhapVao.Text;
                int demmangspacebar = 0;
                int[] mangluuvitrispacebar = new int[100];
                for (int i = 0; i < chuoivuanhapvvao.Length; i++)
                {
                    if (chuoivuanhapvvao.Substring(i, 1) == " ")
                    {
                        mangluuvitrispacebar[demmangspacebar] = i;
                        demmangspacebar = demmangspacebar + 1;
                    }
                }
                chuoivuanhapvvao = chuoivuanhapvvao.Replace(" ","");
                chuoivuanhapvvao = chuoivuanhapvvao.ToUpper();
                chuoivuanhapvvao = chuoivuanhapvvao.Replace("J", "I");
                //chuoivuanhapvvao = themx(chuoivuanhapvvao);
                if (chuoivuanhapvvao.Length % 2 != 0)
                {
                    chuoivuanhapvvao = chuoivuanhapvvao + "Z";
                }
                string key = txtKey.Text;
                key = key.ToUpper();
                char[] arr;
                arr = key.ToCharArray();
                //Duyệt thử mảng array chứa key mới nhập vào
                //foreach (char s in arr)
                //{
                //    strb.Append(s);
                //    strb.Append(" ");
                //}
                //textBox1.Text = strb.ToString();
                char[,] mang5x5 = new char[5, 5];
                int dem = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (dem < arr.Length)
                        {
                            mang5x5[i, j] = arr[dem];
                            dem = dem + 1;
                        }
                        else
                        {
                            mang5x5[i, j] = '?';
                        }
                    }
                }
                string bangchucai = "ABCDEFGHIKLMNOPQRSTUVWXYZ";
                //char[] arrBangChucai;
                //arrBangChucai = bangchucai.ToCharArray();
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (bangchucai.IndexOf(mang5x5[i, j]) != -1)
                        {
                            bangchucai = bangchucai.Replace(mang5x5[i, j], ' ');
                        }
                    }
                }
                bangchucai = bangchucai.Replace(" ", "");
                dem = 0;
                for (int i = 0; i < 5; i++)
                {
                    for (int j = 0; j < 5; j++)
                    {
                        if (mang5x5[i, j] == '?')
                        {
                            mang5x5[i, j] = Convert.ToChar(bangchucai.Substring(dem, 1));
                            dem = dem + 1;
                        }
                    }
                }
                strb.Clear();
                for (int i = 0; i < chuoivuanhapvvao.Length; i = i + 2)
                {
                    int dongcuaso1 = laysodongtrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i, 1)));
                    int cotcuaso1 = laysocottrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i, 1)));
                    int dongcuaso2 = laysodongtrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i + 1, 1)));
                    int cotcuaso2 = laysocottrongmang5x5(mang5x5, Convert.ToChar(chuoivuanhapvvao.Substring(i + 1, 1)));
                    if (dongcuaso1 == dongcuaso2)
                    {
                        cotcuaso1 = cotcuaso1 - 1;
                        if (cotcuaso1 < 0)
                            cotcuaso1 = 4;
                        cotcuaso2 = cotcuaso2 - 1;
                        if (cotcuaso2 < 0)
                            cotcuaso2 = 4;
                    }
                    else if (cotcuaso1 == cotcuaso2)
                    {
                        dongcuaso1 = dongcuaso1 - 1;
                        if (dongcuaso1 < 0)
                            dongcuaso1 = 4;
                        dongcuaso2 = dongcuaso2 - 1;
                        if (dongcuaso2 < 0)
                            dongcuaso2 = 4;
                    }
                    else
                    {

                        int tam = cotcuaso1;
                        cotcuaso1 = cotcuaso2;
                        cotcuaso2 = tam;
                    }
                    strb.Append(mang5x5[dongcuaso1, cotcuaso1]);
                    strb.Append(mang5x5[dongcuaso2, cotcuaso2]);
                }
                string ketqua = strb.ToString();
                char[] mangcharchuaketqua;
                mangcharchuaketqua = ketqua.ToCharArray();
                for(int i =0; i<mangcharchuaketqua.Length; i++)
                {
                    if ( mangcharchuaketqua [i] == 'X' && mangcharchuaketqua[i-1] == mangcharchuaketqua [i+1])
                    {
                        mangcharchuaketqua[i] = '?';
                        //for(int j = mangcharchuaketqua.Length-1; j>i; j--)
                        //{
                        //    mangcharchuaketqua[j] = mangcharchuaketqua[j - 1];
                        //    Array.Resize<char>(ref mangcharchuaketqua, mangcharchuaketqua.Length - 1); 
                        //}
                    }
                }

                strb.Clear();
                foreach (char s in mangcharchuaketqua)
                {
                    strb.Append(s);
                }

                string ketquagiaima = strb.ToString();
                ketquagiaima = ketquagiaima.Replace("?","");
                if (ketquagiaima.Substring(ketquagiaima.Length - 1) == "Z")
                {
                    ketquagiaima = ketquagiaima.Substring(0, ketquagiaima.Length - 1);
                }
                if (ketquagiaima.Substring(ketquagiaima.Length - 1) == "Z")
                {
                    ketquagiaima = ketquagiaima.Substring(0, ketquagiaima.Length - 1);
                }
                for (int i = 0; i < 100; i++)
                {
                    if (mangluuvitrispacebar[i] != 0)
                    {
                        ketquagiaima = ketquagiaima.Insert(mangluuvitrispacebar[i], " ");
                    }
                }
                textBox1.Text = ketquagiaima;

            //int dodaichuoiketqua = ketqua.Length;
            //string ketquagiaima = "";
            //dem = 0;
            //while(dem <dodaichuoiketqua-1)
            //{
            //    if (ketqua.Substring(dem + 1, 1) == "X")
            //    {
            //        if (ketqua.Substring(dem + 2, 1) == ketqua.Substring(dem, 1))
            //        {
            //            ketquagiaima = ketquagiaima + ketqua.Substring(dem, 1) + ketqua.Substring(dem + 2, 1);
            //            dem = dem + 3;
            //        }
            //    }
            //    else
            //    {
            //        ketquagiaima = ketquagiaima + ketqua.Substring(dem, 1) + ketqua.Substring(dem + 1, 1);
            //        dem = dem + 2;
            //    }
            //}
            //textBox1.Text = ketquagiaima;
            //Duyệt mảng 5x5
            //for (int i =0; i<5; i++)
            //{
            //    for (int j=0; j<5; j++)
            //    {
            //        strb.Append(mang5x5[i,j]);
            //        strb.Append(" ");
            //    }
            //    strb.AppendLine();
            ////}
            //string x = laysodongtrongmang5x5(mang5x5,'Y').ToString();
            //x = x + laysocottrongmang5x5(mang5x5, 'Y').ToString();
            //textBox1.Text =x;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi \r\n" + ex);
            }
}
    }
}
