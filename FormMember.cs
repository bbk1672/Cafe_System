using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace WindowsFormsApp1.Forms
{
    public partial class FormMember : Form
    {
        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "wOyFEQFpcE8KQ0DfnZJrSei0U1XPGMu7IG8MgOMa",
            BasePath = "https://jbcafe-2e371.firebaseio.com/"
        };
        IFirebaseClient client;

        public FormMember()
        {
            InitializeComponent();
          
        }

        private async void btnLog_Click(object sender, EventArgs e)
        {
            string pn;
            int i = 0;
            if (string.IsNullOrWhiteSpace(Lgph.Text))
            {
                MessageBox.Show("Worng!,Please input Phone No.");
                return;
            }
            pn = Lgph.Text;
            FirebaseResponse res = await client.GetTaskAsync("auto/id");
            auto at = res.ResultAs<auto>();
            int cnt = Convert.ToInt32(at.cnt);
            while (true)
            {
                if(i==cnt)
                {
                    break;
                }
                
                i++;
                FirebaseResponse response = await client.GetTaskAsync("memberreg/" + i.ToString());
                Memberreg mem = response.ResultAs<Memberreg>();

                if(mem.phoneno==pn)
                {
                    Lgn.Text = mem.Name;
                    Program.logs = 1;
                    Lgph.Text = "";
                    MessageBox.Show("Login complete.");
                    break;
                }

            }
            if (Program.logs==0)
            {
                Lgph.Text = "";
                MessageBox.Show("Phone No. does exist!");
            }

        }

        private void FormMember_Load(object sender, EventArgs e)
        {
            try
            {
                client = new FireSharp.FirebaseClient(config);
            }
            catch
            {
                MessageBox.Show("No internet or Connectoin Problem.");
            }
        }

        private async void btnReg_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrWhiteSpace(Rgp.Text) || string.IsNullOrWhiteSpace(Rgn.Text))
            {
                MessageBox.Show("Worng!,Please input data in Text box.");
                cleartext();
                return;               
            }
            FirebaseResponse res = await client.GetTaskAsync("auto/id");
            auto get = res.ResultAs<auto>();
            var memberreg = new Memberreg
            {
                id = (Convert.ToInt32(get.cnt)+1).ToString(),
                phoneno = Rgp.Text,
                Name = Rgn.Text
            };
            SetResponse response = await client.SetTaskAsync("memberreg/" +memberreg.id,memberreg);
            var obj = new auto
            {
                cnt = memberreg.id
            };
            SetResponse response1 = await client.SetTaskAsync("auto/id" ,obj);
            MessageBox.Show("SUCCESS.");
            cleartext();
        }
        void cleartext()
        {
            Rgp.Text = "";
            Rgn.Text = "";
        }

        private void btnout_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(Lgn.Text)&&Program.logs==0)
            {
                MessageBox.Show("NOT LOGIN.");
                return;
            }
            Program.logs = 0;
            Lgn.Text = "";
            MessageBox.Show("Logout complete.");
        }
    }
}
