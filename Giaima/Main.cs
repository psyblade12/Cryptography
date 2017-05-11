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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Caesar formCaesar = new Caesar();
            formCaesar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            VIGENERE formVIGENERE = new VIGENERE();
            formVIGENERE.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Playfair formPlayfair = new Playfair();
            formPlayfair.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            A51 form = new A51();
            form.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Euclid form = new Euclid();
            form.ShowDialog();
        }

        private void Main_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            BinhPhuongLienTiep form = new BinhPhuongLienTiep();
            form.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            RSA form = new RSA();
            form.ShowDialog();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            TinyDES form = new TinyDES();
            form.ShowDialog();
        }
    }
}
