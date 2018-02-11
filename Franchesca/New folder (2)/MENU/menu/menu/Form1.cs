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
            Sidepanel.Height = bunifuFlatButton12.Height;

            Sidepanel.Top = bunifuFlatButton12.Top;
            firstControl1.BringToFront();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = bunifuFlatButton2.Height;

            Sidepanel.Top = bunifuFlatButton2.Top;
            secondControl1.BringToFront();
        }

        private void bunifuFlatButton8_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = bunifuFlatButton8.Height;

            Sidepanel.Top = bunifuFlatButton8.Top;
            fifthControl1.BringToFront();
        }

        private void bunifuFlatButton9_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = bunifuFlatButton9.Height;

            Sidepanel.Top = bunifuFlatButton9.Top;
            sixthControl1.BringToFront();
        }

        private void bunifuFlatButton10_Click(object sender, EventArgs e)
        {
            Sidepanel.Height = bunifuFlatButton10.Height;

            Sidepanel.Top = bunifuFlatButton10.Top;
            thirdControl1.BringToFront();
        }

        private void bunifuFlatButton11_Click(object sender, EventArgs e)
        {
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
                panel1.Visible = false  ;
                btnMnu.Visible = true;
                panel1.Width = 45;
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
    }
}


          
         
        
    

