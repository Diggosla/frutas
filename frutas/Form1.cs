using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frutas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close(); ;
        }

        private void bntfruta_Click(object sender, EventArgs e)
        {
            string txt = "";
            if (boxmaca.Checked)
            {
                txt += boxmaca.Text + ",";
            }
            if (Boxpera.Checked)
            {
                txt += Boxpera.Text + ",";
            }
            if (Boxabacaxi.Checked)
            {
                txt += Boxabacaxi + ",";
            }
            if (Boxbanana.Checked)
            {
                txt += Boxbanana + ",";
            }
            if (Boxmamao.Checked)
            {
                txt += Boxmorango + ",";
            }
            if (Boxmorango.Checked)
            {
                txt += Boxmorango + ",";
            }
            if (Boxuva.Checked)
            {
                txt += Boxuva + ",";
            }
            if (Boxmamao.Checked)
            {
                txt += Boxmamao + ",";
            }
            MessageBox.Show(" A fruta escolhida foi: " + txt, "A fruta ecolhida foi...");

        }
    }
}

            
        