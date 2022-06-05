using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BunifuAnimatorNS;
namespace DoAnCuoiKi
{
    public partial class Form1 : Form
    {
        //private string username;
        //private string password;
        private string _LoginedUsername;
        public Form1()
        {
            InitializeComponent();
            if (String.IsNullOrEmpty(_LoginedUsername))
            {
                LoginControl loginControl = new LoginControl(setUsername);
                MAINRENDERPANEL.Controls.Add(loginControl);
                MAINRENDERPANEL.BringToFront();
            }    
        }
        public string LoginedUsername
        {
            get { return _LoginedUsername; }
            set
            {
                _LoginedUsername = value;
                if (!string.IsNullOrEmpty(_LoginedUsername))
                {
                    MAINRENDERPANEL.Controls.Clear();
                    MAINRENDERPANEL.SendToBack();
                    MAINPANEL.BringToFront();
                    render();
                }
            }
        }

        
        private void setUsername(string value)
        {
            LoginedUsername = value;
        }
        private async void Form1_Load(object sender, EventArgs e)
        {
            //await Task.Delay(10);
            //bunifuTransition1.ShowSync(bunifuCards1, false, Animation.Mosaic);
            //bunifuTransition1.ShowSync(bunifuCards4, false, Animation.ScaleAndHorizSlide);
            //bunifuTransition1.ShowSync(bunifuCards3, false, Animation.Mosaic);
            //bunifuTransition1.ShowSync(bunifuCards2, false, Animation.ScaleAndHorizSlide);
            //bunifuTransition1.ShowSync(bunifuCards6, false, Animation.Mosaic);
            //bunifuTransition1.ShowSync(bunifuCards5, false, Animation.Mosaic);
        }

        private async void render()
        {
            await Task.Delay(10);
            bunifuTransition1.ShowSync(bunifuCards1, false, Animation.Mosaic);
            bunifuTransition1.ShowSync(bunifuCards4, false, Animation.ScaleAndHorizSlide);
            bunifuTransition1.ShowSync(bunifuCards3, false, Animation.Mosaic);
            bunifuTransition1.ShowSync(bunifuCards2, false, Animation.ScaleAndHorizSlide);
            bunifuTransition1.ShowSync(bunifuCards6, false, Animation.Mosaic);
            bunifuTransition1.ShowSync(bunifuCards5, false, Animation.Mosaic);
        }


        private void MAINPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel10_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel13_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCards1_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards1.Size.Width <= 205 && bunifuCards1.Size.Height <= 225)
            {
                bunifuCards1.Size = new Size(215, 235);
                bunifuCards1.Location = new Point(63, 33);
            }
        }

        private void bunifuCards1_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards1.Size.Width >= 205 && bunifuCards1.Size.Height >= 225)
            {
                bunifuCards1.Size = new Size(205, 225);
                bunifuCards1.Location = new Point(68, 38);
            }
        }
        private void bunifuCards4_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards4.Size.Width <= 205 && bunifuCards4.Size.Height <= 225)
            {
                bunifuCards4.Size = new Size(215, 235);
                bunifuCards4.Location = new Point(297, 33);
            }
        }

        private void bunifuCards4_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards4.Size.Width >= 205 && bunifuCards4.Size.Height >= 225)
            {
                bunifuCards4.Size = new Size(205, 225);
                bunifuCards4.Location = new Point(302, 38);
            }
        }

        private void bunifuCards3_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards3.Size.Width <= 205 && bunifuCards3.Size.Height <= 225)
            {
                bunifuCards3.Size = new Size(215, 235);
                bunifuCards3.Location = new Point(541, 33);
            }
        }

        private void bunifuCards3_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards3.Size.Width >= 205 && bunifuCards3.Size.Height >= 225)
            {
                bunifuCards3.Size = new Size(205, 225);
                bunifuCards3.Location = new Point(546, 38);
            }
        }
        private void bunifuCards2_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards2.Size.Width <= 205 && bunifuCards2.Size.Height <= 225)
            {
                bunifuCards2.Size = new Size(215, 235);
                bunifuCards2.Location = new Point(63, 333);
            }
        }
        private void bunifuCards2_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards2.Size.Width >= 205 && bunifuCards2.Size.Height >= 225)
            {
                bunifuCards2.Size = new Size(205, 225);
                bunifuCards2.Location = new Point(68, 338);
            }
        }
        private void bunifuCards6_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards6.Size.Width <= 205 && bunifuCards6.Size.Height <= 225)
            {
                bunifuCards6.Size = new Size(215, 235);
                bunifuCards6.Location = new Point(297, 333);
            }
        }
        private void bunifuCards6_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards6.Size.Width >= 205 && bunifuCards6.Size.Height >= 225)
            {
                bunifuCards6.Size = new Size(205, 225);
                bunifuCards6.Location = new Point(302, 338);
            }
        }
        private void bunifuCards5_MouseHover(object sender, EventArgs e)
        {
            if (bunifuCards5.Size.Width <= 205 && bunifuCards5.Size.Height <= 225)
            {
                bunifuCards5.Size = new Size(215, 235);
                bunifuCards5.Location = new Point(541, 333);
            }
        }
        private void bunifuCards5_MouseLeave(object sender, EventArgs e)
        {
            if (bunifuCards5.Size.Width >= 205 && bunifuCards5.Size.Height >= 225)
            {
                bunifuCards5.Size = new Size(205, 225);
                bunifuCards5.Location = new Point(546, 338);
            }
        }

        private void TOPPANEL_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MAINRENDERPANEL_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
