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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string chuoinhapvao;
        string chuoiketqua = "";
        private void button1_Click(object sender, EventArgs e)
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

            for (int i =0; i<100; i++)
            {
                chuoiketqua = chuoiketqua + vitrispacebar[i] + @"-";
            }
            //textBox1.Text = chuoinhapvao;
            //for (int i = 0; i < chuoinhapvao.Length; i++)
            //{
            //    chuoiketqua = chuoiketqua + vitrispacebar;
            //}
            //chuoiketqua = chuoinhapvao.IndexOf(" ").ToString();
            //textBox1.Text = chuoiketqua;
            //chuoinhapvao =  chuoinhapvao.Remove(3, 1);
            textBox2.Text =chuoiketqua;
            
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
