using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Forms
{
    public partial class FormCoffee : Form
    {
        public FormCoffee()
        {
            InitializeComponent();
          
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        

        private void americanoC_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnordercoffee_Click(object sender, EventArgs e)
        {
            int es, ca, la, am, esc, cac, lac, amc;
            if (espresso.Checked)
            {
                Program.orcoffee += "\r\nEspresso hot \t\t" + esphnum.Value + " x 45";
                es = int.Parse(esphnum.Value.ToString()) * 45;
            }
            else
            {
                es = 0;
            }
            if (cappuccino.Checked)
            {
                Program.orcoffee += "\r\nCappuccino hot \t\t" + caphnum.Value + " x 50";
                ca = int.Parse(caphnum.Value.ToString()) * 50;
            }
            else
            {
                ca = 0;
            }
            if (latte.Checked)
            {
                Program.orcoffee += "\r\nLatte hot \t\t" + lathnum.Value + " x 50";
                la = int.Parse(lathnum.Value.ToString()) * 50;
            }
            else
            {
                la = 0;
            }
            if (americano.Checked)
            {
                Program.orcoffee += "\r\nAmericano hot \t\t" + amehnum.Value + " x 55";
                am = int.Parse(amehnum.Value.ToString()) * 55;
            }
            else
            {
                am = 0;
            }
            //////////////////////////
            if (espressoC.Checked)
            {
                Program.orcoffee += "\r\nEspresso cold \t\t" + espcnum.Value + " x 65";
                esc = int.Parse(espcnum.Value.ToString()) * 65;
            }
            else
            {
                esc = 0;
            }
            if (cappuccinoC.Checked)
            {
                Program.orcoffee += "\r\nCappuccino cold \t\t" + capcnum.Value + " x 70";
                cac = int.Parse(capcnum.Value.ToString()) * 70;
            }
            else
            {
                cac = 0;
            }
            if (latteC.Checked)
            {
                Program.orcoffee += "\r\nLatte cold \t\t" + latcnum.Value + " x 70";
                lac = int.Parse(latcnum.Value.ToString()) * 70;
            }
            else
            {
                lac = 0;
            }
            if (americanoC.Checked)
            {
                Program.orcoffee += "\r\nAmericano cold \t\t" + amecnum.Value + " x 75";
                amc = int.Parse(amecnum.Value.ToString()) * 75;
            }
            else
            {
                amc = 0;
            }
            Program.scoffee = es + ca + la + am + esc + cac + lac + amc;
        }
    }
}
