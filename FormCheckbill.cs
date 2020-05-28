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
    public partial class FormCheckbill : Form
    {
        public FormCheckbill()
        {
            InitializeComponent();
        }

        private void orderbutton_Click(object sender, EventArgs e)
        {
            float sum, lastsum;
            string section,memb,allbill,jb,date,endding;
            date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss");
            sum = Program.sfood + Program.stea + Program.scoffee + Program.sdessert;
            Program.allorder = Program.orfood + Program.orcoffee + Program.ortea + Program.ordessert;
            jb = "                    JB CAFE";
            section = "\r\n--------------------------------------------------";
            endding = "\r\n====================================";
            if (Program.logs == 0)
            {
                lastsum = sum;
                memb = "\r\nYou are not member. \r\nTotal.\t\t" + "\t" + lastsum.ToString() + " THB.";

                allbill = jb + "\r\n \t" + date + section + Program.allorder + section + memb + section + "\r\n                  THANK YOU."+endding;
                ordertxt.Text = allbill;
            }
            else if(Program.logs==1)
            {
                lastsum = sum - ((sum / 100) * 10);
                memb = "\r\nYou are member.\r\nGet a discount 10%. \r\nTotal.\t\t" + "\t"+ lastsum.ToString() + " THB.";

                allbill = jb + "\r\n \t" + date + section + Program.allorder + section + memb + section +  "\r\n                  THANK YOU."+endding;
                ordertxt.Text = allbill;
            }
        }

        private void clearbutton_Click(object sender, EventArgs e)
        {
            ordertxt.Clear();
            Program.orfood = "";
            Program.ortea = "";
            Program.orcoffee = "";
            Program.ordessert = "";
            Program.allorder = "";
            //////////////////////////
            Program.stea = 0;
            Program.scoffee = 0;
            Program.sdessert = 0;
            Program.sfood = 0;
            Program.logs = 0;
            
        }

        private void checkbillb_Click(object sender, EventArgs e)
        {
            if(printPreviewDialog1.ShowDialog()==DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.Graphics.DrawString(ordertxt.Text,new Font("Prompt",16,FontStyle.Regular),Brushes.Black,new PointF(100,100));
        }
    }
}
