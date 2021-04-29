using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Net.Http;
using System.Diagnostics;

namespace hashFivem
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void b_convert_Click(object sender, EventArgs e)
        {
            System.Net.ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            string codigo = tb_text.Text.ToLower();

            string URI = "https://cxde.es/hash/hash.php";
            string myParameters = "prop=" + codigo;

            using (WebClient wc = new WebClient())
            {
                wc.Headers[HttpRequestHeader.ContentType] = "application/x-www-form-urlencoded";
                string HtmlResult = wc.UploadString(URI, myParameters);
                tb_text.Text = HtmlResult;
            }
        }


        private void label1_Click(object sender, EventArgs e)
        {
            Process.Start("https://discord.cxde.es");
        }



        public int xClick = 0, yClick = 0;

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }

        private void pic_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pic_min_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
            {
                xClick = e.X; yClick = e.Y;
            }
            else
            {
                this.Left = this.Left + (e.X - xClick); this.Top = this.Top + (e.Y - yClick);
            }
        }


    }

}