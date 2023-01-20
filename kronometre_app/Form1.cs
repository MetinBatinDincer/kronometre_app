using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kronometre_app
{
    public partial class Form1 : Form
    {
        int dk = 0;
        int saniye;
        int saat = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye = int.Parse(label1.Text);
            saniye++;

            label1.Text = saniye.ToString();
            label2.Text = dk.ToString();
            label3.Text = saat.ToString();
            if (saniye == 60)
            {
                label1.Text = "00";
                dk++;

            }
            if (dk == 60)
            {
                label2.Text = "00";
                dk = 0;
                saat++;

            }

            if (saniye < 10) label1.Text = "0" + saniye.ToString();
            if (dk < 10) label2.Text = "0" + dk.ToString();
            if (saat < 10) label3.Text = "0" + saat.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }
    }
}
