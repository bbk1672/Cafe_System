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
    public partial class FormFoods : Form
    {
        public FormFoods()
        {
            LoadTheme();
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void btnorderfoods_Click(object sender, EventArgs e)
        {
            int sa, st, pc, bu, pi, bq;
            if (salad.Checked)
            {
                Program.orfood += "\r\nSalad \t\t\t" + salnum.Value + " x 89";
                sa = int.Parse(salnum.Value.ToString()) * 89;
            }
            else
            {
                sa = 0;
            }
            if (steak.Checked)
            {
                Program.orfood += "\r\nSteak \t\t\t" + stanum.Value + " x 199";
                st = int.Parse(stanum.Value.ToString()) * 199;
            }
            else
            {
                st = 0;
            }
            if (porkchop.Checked)
            {
                Program.orfood += "\r\nPork chop \t\t" + pornum.Value + " x 159";
                pc = int.Parse(pornum.Value.ToString()) * 159;
            }
            else
            {
                pc = 0;
            }
            if (burgers.Checked)
            {
                Program.orfood += "\r\nBurgers \t\t\t" + burnum.Value + " x 69";
                bu = int.Parse(burnum.Value.ToString()) * 69;
            }
            else
            {
                bu = 0;
            }
            if (pizza.Checked)
            {
                Program.orfood += "\r\nPizza \t\t\t" + piznum.Value + " x 269";
                pi = int.Parse(piznum.Value.ToString()) * 269;
            }
            else
            {
                pi = 0;
            }
            if (bbq.Checked)
            {
                Program.orfood += "\r\nBBQ \t\t\t" + bbqnum.Value + " x 89";
                bq = int.Parse(bbqnum.Value.ToString()) * 89;
            }
            else
            {
                bq = 0;
            }
            Program.sfood = sa + st + pc + bu + pi + bq;
        }
    }
}
