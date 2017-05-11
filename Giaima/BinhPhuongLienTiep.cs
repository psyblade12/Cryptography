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
    public partial class BinhPhuongLienTiep : Form
    {
        public BinhPhuongLienTiep()
        {
            InitializeComponent();
        }
        public static int binhphuonglientiep(int a, int k, int m)
        {
            int p;
            if (k == 0)
            {
                return 1;
            }
            else
            {
                p = binhphuonglientiep(a, k / 2, m);
                if (k % 2 == 0)
                    return (p * p) % m;
                else
                    return (p * p * a) % m;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int a = Convert.ToInt32(txta.Text);
                int k = Convert.ToInt32(txtk.Text);
                int m = Convert.ToInt32(txtm.Text);
                int ketqua = binhphuonglientiep(a, k, m);
                textBox2.Text = ketqua.ToString();
            }
            catch
            {
                MessageBox.Show("Có lỗi ");
            }
        }
    }
}
