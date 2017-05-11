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
    public partial class FairPlay : Form
    {
        public FairPlay()
        {
            InitializeComponent();
        }

        private void FairPlay_Load(object sender, EventArgs e)
        {

        }

        private void XoaViTriMang(string []Mang, int vitri)
        {
            for (int i = vitri; i<Mang.Length-1; i++)
            {
                Mang[i] = Mang[i + 1];
            }
            //Array.Resize<string>(ref Mang, Mang.Length - 1);
        }
        
        //private int TimXemChuOCotNao(string Chu)
        //{
        //    int vitri;
        //    for (int i = 0; i < 5; i++)
        //    {
        //        vitri = Array.IndexOf("dong"+i,Chu);
        //    }
        //    return vitri;
        //}
        
        private void button1_Click(object sender, EventArgs e)
        {
            int vitridongcuaso1=0;
            int vitridongcuaso2 =0;
            int vitricotcuaso1 = 0;
            int vitricotcuaso2 = 0;
            string[,] mang2chieu = new string[5, 5];
            string chuoinhapvao;
            string chuoiketqua;
            string key;
            string[] mangchuakey = new string[100];
            int soluongkitumangchu = 25;
            string[] mangchu = new string[25] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int dem = 0;
            int demmangchu = 0;
            chuoinhapvao = textBox1.Text;
            key = textBox2.Text;
            chuoinhapvao = chuoinhapvao.ToUpper();
            chuoiketqua = "";
            int dodaichuoikey = key.Length;
            for (int i = 0; i < dodaichuoikey; i = i + 1)
            {
                mangchuakey[i] = key.Substring(i, 1);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j =0; j<5; j++)
                {
                    if (dem < dodaichuoikey)
                    {
                        mang2chieu[i, j] = mangchuakey[dem];
                        int a;
                        a = Array.IndexOf(mangchu, mangchuakey[dem]);
                        if (a != -1)
                        {
                            XoaViTriMang(mangchu, a);
                        }
                        dem = dem + 1;
                    }
                    else
                    {
                        mang2chieu[i, j] = mangchu[demmangchu];
                        demmangchu = demmangchu + 1;
                    }
                }
            }
            demmangchu = 0;
            dem = 0;
            
            string chuoimangchu = "";
            for (int i = 0; i < mangchu.Length; i++)
            {
                chuoimangchu = chuoimangchu + "[" + i + "]"+ mangchu[i];
            }

            string[,] mangtach = new string[100, 2];
            chuoinhapvao = textBox1.Text;
            int demkituchuoinhapvao = 0;
            for (int i =0; i<100;i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (demkituchuoinhapvao < chuoinhapvao.Length)
                    {
                        mangtach[i, j] = chuoinhapvao.Substring(demkituchuoinhapvao, 1);
                        demkituchuoinhapvao = demkituchuoinhapvao + 1;
                    }
                }
            }
            

            string[] dong1 = new string[5] { mang2chieu[0,0], mang2chieu[0, 1], mang2chieu[0, 2], mang2chieu[0, 3], mang2chieu[0, 4]};
            string[] dong2 = new string[5] { mang2chieu[1, 0], mang2chieu[1, 1], mang2chieu[1, 2], mang2chieu[1, 3], mang2chieu[1, 4] };
            string[] dong3 = new string[5] { mang2chieu[2, 0], mang2chieu[2, 1], mang2chieu[2, 2], mang2chieu[2, 3], mang2chieu[2, 4] };
            string[] dong4 = new string[5] { mang2chieu[3, 0], mang2chieu[3, 1], mang2chieu[3, 2], mang2chieu[3, 3], mang2chieu[3, 4] };
            string[] dong5 = new string[5] { mang2chieu[4, 0], mang2chieu[4, 1], mang2chieu[4, 2], mang2chieu[4, 3], mang2chieu[4, 4] };
            string[] cot1 = new string[5] { mang2chieu[0, 0], mang2chieu[1, 0], mang2chieu[2, 0], mang2chieu[3, 0], mang2chieu[4, 0] };
            string[] cot2 = new string[5] { mang2chieu[0, 1], mang2chieu[1, 1], mang2chieu[2, 1], mang2chieu[3, 1], mang2chieu[4, 1] };
            string[] cot3 = new string[5] { mang2chieu[0, 2], mang2chieu[1, 2], mang2chieu[2, 2], mang2chieu[3, 2], mang2chieu[4, 2] };
            string[] cot4 = new string[5] { mang2chieu[0, 3], mang2chieu[1, 3], mang2chieu[2, 3], mang2chieu[3, 3], mang2chieu[4, 3] };
            string[] cot5 = new string[5] { mang2chieu[0, 4], mang2chieu[1, 4], mang2chieu[2, 4], mang2chieu[3, 4], mang2chieu[4, 4] };

            for (int i = 0; i < chuoinhapvao.Length / 2; i++)
            {
                //Lay vi tri cua so 1

                if (Array.IndexOf(dong1, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 0;
                }
                if (Array.IndexOf(dong2, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 1;
                }
                if (Array.IndexOf(dong3, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 2;
                }
                if (Array.IndexOf(dong4, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 3;
                }
                if (Array.IndexOf(dong5, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 4;
                }


                if (Array.IndexOf(cot1, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 0;
                }
                if (Array.IndexOf(cot2, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 1;
                }
                if (Array.IndexOf(cot3, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 2;
                }
                if (Array.IndexOf(cot4, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 3;
                }
                if (Array.IndexOf(cot5, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 4;
                }
                //END
                //Lay vi tri cua so 2

                if (Array.IndexOf(dong1, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 0;
                }
                if (Array.IndexOf(dong2, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 1;
                }
                if (Array.IndexOf(dong3, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 2;
                }
                if (Array.IndexOf(dong4, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 3;
                }
                if (Array.IndexOf(dong5, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 4;
                }


                if (Array.IndexOf(cot1, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 0;
                }
                if (Array.IndexOf(cot2, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 1;
                }
                if (Array.IndexOf(cot3, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 2;
                }
                if (Array.IndexOf(cot4, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 3;
                }
                if (Array.IndexOf(cot5, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 4;
                }

                //END


                if ((vitridongcuaso1 == vitridongcuaso2) && (vitricotcuaso1 == vitricotcuaso2))
                {
                    mangtach[i, 0] = mangtach[i, 0];
                    mangtach[i, 1] = "X"+ mangtach[i, 0];
                }

                

                if ((vitridongcuaso1 == vitridongcuaso2) && (vitricotcuaso1 != vitricotcuaso2))
                {
                    int vitricot1moi = vitricotcuaso1 + 1;
                    int vitricot2moi = vitricotcuaso2 + 1;
                    if (vitricot1moi > 4)
                    {
                        vitricot1moi = 0;
                    }
                    if (vitricot2moi > 4)
                    { 
                    vitricot2moi = 0;
                    }
                    mangtach[i, 0] = mang2chieu[vitridongcuaso1, vitricot1moi];
                    mangtach[i, 1] = mang2chieu[vitridongcuaso2, vitricot2moi];
                }

                if ((vitridongcuaso1 != vitridongcuaso2) && (vitricotcuaso1 == vitricotcuaso2))
                {
                    int vitridong1moi = vitridongcuaso1 + 1;
                    int vitridong2moi = vitridongcuaso2 + 1;
                    if (vitridong1moi > 4)
                        vitridong1moi = 0;
                    if (vitridong2moi > 4)
                        vitridong2moi = 0;
                    mangtach[i, 0] = mang2chieu[vitridong1moi, vitricotcuaso1];
                    mangtach[i, 1] = mang2chieu[vitridong2moi, vitricotcuaso2];
                }

                else
                {

                    if (vitridongcuaso1 < vitridongcuaso2)
                    {
                        mangtach[i, 0] = mang2chieu[vitridongcuaso1, vitricotcuaso2];
                        mangtach[i, 1] = mang2chieu[vitridongcuaso2, vitricotcuaso1];
                    }
                    if (vitridongcuaso1 > vitridongcuaso2)
                    {
                        mangtach[i, 0] = mang2chieu[vitridongcuaso1, vitricotcuaso2];
                        mangtach[i, 1] = mang2chieu[vitridongcuaso2, vitricotcuaso1];
                    }
                }


            }





            for (int i = 0; i < chuoinhapvao.Length/2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    chuoiketqua = chuoiketqua + mangtach[i, j];
                    
                }
                
            }


            textBox3.Text = chuoiketqua;
            

            textBox4.Text = Convert.ToString(vitridongcuaso1)+ "" + Convert.ToString(vitricotcuaso1) + "||" +Convert.ToString(vitridongcuaso2) + Convert.ToString(vitricotcuaso2);
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int vitridongcuaso1 = 0;
            int vitridongcuaso2 = 0;
            int vitricotcuaso1 = 0;
            int vitricotcuaso2 = 0;
            string[,] mang2chieu = new string[5, 5];
            string chuoinhapvao;
            string chuoiketqua;
            string key;
            string[] mangchuakey = new string[100];
            int soluongkitumangchu = 25;
            string[] mangchu = new string[25] { "A", "B", "C", "D", "E", "F", "G", "H", "I", "K", "L", "M", "N", "O", "P", "Q", "R", "S", "T", "U", "V", "W", "X", "Y", "Z" };
            int dem = 0;
            int demmangchu = 0;
            chuoinhapvao = textBox1.Text;
            key = textBox2.Text;
            chuoinhapvao = chuoinhapvao.ToUpper();
            chuoiketqua = "";
            int dodaichuoikey = key.Length;
            for (int i = 0; i < dodaichuoikey; i = i + 1)
            {
                mangchuakey[i] = key.Substring(i, 1);
            }
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (dem < dodaichuoikey)
                    {
                        mang2chieu[i, j] = mangchuakey[dem];
                        int a;
                        a = Array.IndexOf(mangchu, mangchuakey[dem]);
                        if (a != -1)
                        {
                            XoaViTriMang(mangchu, a);
                        }
                        dem = dem + 1;
                    }
                    else
                    {
                        mang2chieu[i, j] = mangchu[demmangchu];
                        demmangchu = demmangchu + 1;
                    }
                }
            }
            demmangchu = 0;
            dem = 0;

            string chuoimangchu = "";
            for (int i = 0; i < mangchu.Length; i++)
            {
                chuoimangchu = chuoimangchu + "[" + i + "]" + mangchu[i];
            }

            string[,] mangtach = new string[100, 2];
            chuoinhapvao = textBox1.Text;
            int demkituchuoinhapvao = 0;
            for (int i = 0; i < 100; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    if (demkituchuoinhapvao < chuoinhapvao.Length)
                    {
                        mangtach[i, j] = chuoinhapvao.Substring(demkituchuoinhapvao, 1);
                        demkituchuoinhapvao = demkituchuoinhapvao + 1;
                    }
                }
            }


            string[] dong1 = new string[5] { mang2chieu[0, 0], mang2chieu[0, 1], mang2chieu[0, 2], mang2chieu[0, 3], mang2chieu[0, 4] };
            string[] dong2 = new string[5] { mang2chieu[1, 0], mang2chieu[1, 1], mang2chieu[1, 2], mang2chieu[1, 3], mang2chieu[1, 4] };
            string[] dong3 = new string[5] { mang2chieu[2, 0], mang2chieu[2, 1], mang2chieu[2, 2], mang2chieu[2, 3], mang2chieu[2, 4] };
            string[] dong4 = new string[5] { mang2chieu[3, 0], mang2chieu[3, 1], mang2chieu[3, 2], mang2chieu[3, 3], mang2chieu[3, 4] };
            string[] dong5 = new string[5] { mang2chieu[4, 0], mang2chieu[4, 1], mang2chieu[4, 2], mang2chieu[4, 3], mang2chieu[4, 4] };
            string[] cot1 = new string[5] { mang2chieu[0, 0], mang2chieu[1, 0], mang2chieu[2, 0], mang2chieu[3, 0], mang2chieu[4, 0] };
            string[] cot2 = new string[5] { mang2chieu[0, 1], mang2chieu[1, 1], mang2chieu[2, 1], mang2chieu[3, 1], mang2chieu[4, 1] };
            string[] cot3 = new string[5] { mang2chieu[0, 2], mang2chieu[1, 2], mang2chieu[2, 2], mang2chieu[3, 2], mang2chieu[4, 2] };
            string[] cot4 = new string[5] { mang2chieu[0, 3], mang2chieu[1, 3], mang2chieu[2, 3], mang2chieu[3, 3], mang2chieu[4, 3] };
            string[] cot5 = new string[5] { mang2chieu[0, 4], mang2chieu[1, 4], mang2chieu[2, 4], mang2chieu[3, 4], mang2chieu[4, 4] };

            for (int i = 0; i < chuoinhapvao.Length / 2; i++)
            {
                //Lay vi tri cua so 1

                if (Array.IndexOf(dong1, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 0;
                }
                if (Array.IndexOf(dong2, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 1;
                }
                if (Array.IndexOf(dong3, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 2;
                }
                if (Array.IndexOf(dong4, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 3;
                }
                if (Array.IndexOf(dong5, mangtach[i, 0]) != -1)
                {
                    vitridongcuaso1 = 4;
                }


                if (Array.IndexOf(cot1, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 0;
                }
                if (Array.IndexOf(cot2, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 1;
                }
                if (Array.IndexOf(cot3, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 2;
                }
                if (Array.IndexOf(cot4, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 3;
                }
                if (Array.IndexOf(cot5, mangtach[i, 0]) != -1)
                {
                    vitricotcuaso1 = 4;
                }
                //END
                //Lay vi tri cua so 2

                if (Array.IndexOf(dong1, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 0;
                }
                if (Array.IndexOf(dong2, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 1;
                }
                if (Array.IndexOf(dong3, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 2;
                }
                if (Array.IndexOf(dong4, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 3;
                }
                if (Array.IndexOf(dong5, mangtach[i, 1]) != -1)
                {
                    vitridongcuaso2 = 4;
                }


                if (Array.IndexOf(cot1, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 0;
                }
                if (Array.IndexOf(cot2, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 1;
                }
                if (Array.IndexOf(cot3, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 2;
                }
                if (Array.IndexOf(cot4, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 3;
                }
                if (Array.IndexOf(cot5, mangtach[i, 1]) != -1)
                {
                    vitricotcuaso2 = 4;
                }

                //END


                


                if ((vitridongcuaso1 == vitridongcuaso2) && (vitricotcuaso1 != vitricotcuaso2))
                {
                    int vitricot1moi = vitricotcuaso1 - 1;
                    int vitricot2moi = vitricotcuaso2 - 1;
                    if (vitricot1moi <0)
                    {
                        vitricot1moi = 4;
                    }
                    if (vitricot2moi < 0)
                    {
                        vitricot2moi = 4;
                    }
                    mangtach[i, 0] = mang2chieu[vitridongcuaso1, vitricot1moi];
                    mangtach[i, 1] = mang2chieu[vitridongcuaso2, vitricot2moi];
                }

                if ((vitridongcuaso1 != vitridongcuaso2) && (vitricotcuaso1 == vitricotcuaso2))
                {
                    int vitridong1moi = vitridongcuaso1 - 1;
                    int vitridong2moi = vitridongcuaso2 - 1;
                    if (vitridong1moi < 0)
                        vitridong1moi = 4;
                    if (vitridong2moi <0)
                        vitridong2moi = 4;
                    mangtach[i, 0] = mang2chieu[vitridong1moi, vitricotcuaso1];
                    mangtach[i, 1] = mang2chieu[vitridong2moi, vitricotcuaso2];
                }

                else
                {

                    if (vitridongcuaso1 < vitridongcuaso2)
                    {
                        mangtach[i, 0] = mang2chieu[vitridongcuaso1, vitricotcuaso2];
                        mangtach[i, 1] = mang2chieu[vitridongcuaso2, vitricotcuaso1];
                    }
                    if (vitridongcuaso1 > vitridongcuaso2)
                    {
                        mangtach[i, 0] = mang2chieu[vitridongcuaso2, vitricotcuaso1];
                        mangtach[i, 1] = mang2chieu[vitricotcuaso2, vitridongcuaso1];
                    }
                }


            }





            for (int i = 0; i < chuoinhapvao.Length / 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    chuoiketqua = chuoiketqua + mangtach[i, j];
                    
                }
                
            }


            textBox3.Text = chuoiketqua;


            textBox4.Text = Convert.ToString(vitridongcuaso1) + "" + Convert.ToString(vitricotcuaso1) + "||" + Convert.ToString(vitridongcuaso2) + Convert.ToString(vitricotcuaso2);
        }
    
    }
}
