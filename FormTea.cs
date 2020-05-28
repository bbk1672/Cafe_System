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
    public partial class FormTea : Form
    {
        public FormTea()
        {
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnordertea_Click(object sender, EventArgs e)
        {
            int bt, mat, matl, tt, btc, matc, matlc, ttc;
            if(blackt.Checked)
            { 
                Program.ortea += "\r\nBlack tea hot \t\t" + blathnum.Value + " x 45";
                bt = int.Parse(blathnum.Value.ToString())*45;
            }
            else
            {
                bt = 0;
            }
            if(matcha.Checked)
            {
                Program.ortea += "\r\nMatcha hot \t\t" + mathnum.Value + " x 50";
                mat = int.Parse(mathnum.Value.ToString()) * 50;
            }
            else
            {
                mat = 0;
            }
            if (matchal.Checked)
            {
                Program.ortea += "\r\nMatcha latte hot \t\t" + matlhnum.Value + " x 50";
                matl = int.Parse(matlhnum.Value.ToString()) * 50;
            }
            else
            {
                matl = 0;
            }
            if (thait.Checked)
            {
                Program.ortea += "\r\nThai Tea hot \t\t" + thaithnum.Value + " x 35";
                tt = int.Parse(thaithnum.Value.ToString()) * 35;
            }
            else
            {
                tt = 0;
            }
            ////////////////////////////
            if (blacktc.Checked)
            {
                Program.ortea += "\r\nBlack tea cold \t\t" + blatcnum.Value + " x 55";
                btc = int.Parse(blatcnum.Value.ToString()) * 55;
            }
            else
            {
                btc = 0;
            }
            if (matchac.Checked)
            {
                Program.ortea += "\r\nMatcha cold \t\t" + matcnum.Value + " x 60";
                matc = int.Parse(matcnum.Value.ToString()) * 60;
            }
            else
            {
                matc = 0;
            }
            if (matchalc.Checked)
            {
                Program.ortea += "\r\nMatcha latte cold \t" + matlcnum.Value + " x 60";
                matlc = int.Parse(matlcnum.Value.ToString()) * 60;
            }
            else
            {
                matlc = 0;
            }
            if (thaitc.Checked)
            {
                Program.ortea += "\r\nThai Tea cold \t\t" + thaitcnum.Value + " x 45";
                ttc = int.Parse(thaitcnum.Value.ToString()) * 45;
            }
            else
            {
                ttc = 0;
            }
            Program.stea = bt + mat + matl + tt + btc + matc + matlc + ttc;
        }
    }
}
