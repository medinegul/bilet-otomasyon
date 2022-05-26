using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class anaForm : Form
    {
        public anaForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            firmaBilgi bilgiFormu = new firmaBilgi();
            bilgiFormu.Show();
        }

        private void btnYolcuBilgi_Click(object sender, EventArgs e)
        {
            YolcuBilgi yolcuFormu = new YolcuBilgi();
            yolcuFormu.Show();
        }

        private void btnSeferBilgi_Click(object sender, EventArgs e)
        {
            SeferBilgi seferFormu = new SeferBilgi();
            seferFormu.Show();
        }

        private void btnKoltukSeç_Click(object sender, EventArgs e)
        {
            KoltukSeç koltukFormu = new KoltukSeç();
            koltukFormu.Show();
        }

        private void btnTarihSeç_Click(object sender, EventArgs e)
        {
            TarihSeç tarihFormu = new TarihSeç();
            tarihFormu.Show();
        }
    }
}
