using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Sidepanel.Height = bunifuFlatButton12.Height;
            Sidepanel.Top = bunifuFlatButton12.Top;
            firstControl1.BringToFront();

        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton12_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(firstControl1);
            bunifuTransition4.ShowSync(firstControl1);

            Sidepanel.Height = bunifuFlatButton12.Height;
            Sidepanel.Top = bunifuFlatButton12.Top;
            firstControl1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(secondControl1);
            bunifuTransition4.ShowSync(secondControl1);

            Sidepanel.Height = bunifuFlatButton2.Height;
            Sidepanel.Top = bunifuFlatButton2.Top;
            secondControl1.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(fifthControl1);
            bunifuTransition4.ShowSync(fifthControl1);

            Sidepanel.Height = bunifuFlatButton8.Height;
            Sidepanel.Top = bunifuFlatButton8.Top;
            fifthControl1.BringToFront();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(sixthControl1);
            bunifuTransition4.ShowSync(sixthControl1);

            Sidepanel.Height = bunifuFlatButton9.Height;
            Sidepanel.Top = bunifuFlatButton9.Top;
            sixthControl1.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(thirdControl1);
            bunifuTransition4.ShowSync(thirdControl1);

            Sidepanel.Height = bunifuFlatButton10.Height;
            Sidepanel.Top = bunifuFlatButton10.Top;
            thirdControl1.BringToFront();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
            bunifuTransition5.HideSync(forthControl1);
            bunifuTransition4.ShowSync(forthControl1);

            Sidepanel.Height = bunifuFlatButton11.Height;
            Sidepanel.Top = bunifuFlatButton11.Top;
            forthControl1.BringToFront();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnMnu_Click(object sender, EventArgs e)
        {
            if (panel1.Width == 212)
            {
                panel1.Visible = false;
                btnMnu.Visible = true;
                panel1.Width = 50;
                bunifuTransition1.ShowSync(panel1);
            }
            else
            {
                panel1.Visible = false;
                panel1.Width = 212;
                btnMnu.Visible = true;
                bunifuTransition1.ShowSync(panel1);
            }

        }

        private void logo_Click(object sender, EventArgs e)
        {

        }
        1 verwels
        private void firstControl1_Load(object sender, EventArgs e)
        {
            String html="";
            String url = @"www.facebook.com" + Value;
            HttpWebRequest request = HttpWebRequest)WebRequest.Create(url);
            using(WebRequest)  
        }

        private void sixthControl1_Load(object sender, EventArgs e)
        {

        }
    }










