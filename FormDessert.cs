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
    public partial class FormDessert : Form
    {
        public FormDessert()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnorderdessert_Click(object sender, EventArgs e)
        {
            int ht, mf, pc, wf, cc;
            if (honey.Checked)
            {
                Program.ordessert += "\r\nHoney Toast \t\t" + honnum.Value + " x 89";
                ht = int.Parse(honnum.Value.ToString()) * 89;
            }
            else
            {
                ht = 0;
            }
            if (muffin.Checked)
            {
                Program.ordessert += "\r\nMuffin \t\t\t" + mufnum.Value + " x 49";
                mf = int.Parse(mufnum.Value.ToString()) * 49;
            }
            else
            {
                mf = 0;
            }
            if (pancake.Checked)
            {
                Program.ordessert += "\r\nPan Cake \t\t" + pannum.Value + " x 49";
                pc = int.Parse(pannum.Value.ToString()) * 49;
            }
            else
            {
                pc = 0;
            }
            if (waffle.Checked)
            {
                Program.ordessert += "\r\nWaffle \t\t\t" + wafnum.Value + " x 59";
                wf = int.Parse(wafnum.Value.ToString()) * 59;
            }
            else
            {
                wf = 0;
            }
            if (cupcake.Checked)
            {
                Program.ordessert += "\r\nCup Cake \t\t" + cupnum.Value + " x 59";
                cc = int.Parse(cupnum.Value.ToString()) * 59;
            }
            else
            {
                cc = 0;
            }
            Program.sdessert = ht + mf + pc + cc + wf;
        }
    }
}
