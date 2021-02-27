using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Time_table_Management_System
{

    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn
        (
            int nLeftRect,     // x-coordinate of upper-left corner
            int nTopRect,      // y-coordinate of upper-left corner
            int nRightRect,    // x-coordinate of lower-right corner
            int nBottomRect,   // y-coordinate of lower-right corner
            int nWidthEllipse, // height of ellipse
            int nHeightEllipse // width of ellipse
        );


        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            panel1.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(10, 10, Width, Height, 40, 40));
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            //dashboard panel main
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //label home
        }




        

       

        private void Form1_Load(object sender, EventArgs e)
        {
            //form
        }

       // private void button2_Click(object sender, EventArgs e)
       // {

       // }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //picturebox panel
        }

       // private void button1_Click_1(object sender, EventArgs e)
       // {

        //}








        //Header icons
        private void button2_Click_1(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
        }

        private void button8_Click(object sender, EventArgs e)
        {
            
        }


        private void button1_Click_2(object sender, EventArgs e)
        {
            
        }







        //Slide navbar icons

        private void button9_Click(object sender, EventArgs e)
        {
            //nav
        }

        private void button10_Click(object sender, EventArgs e)
        {
            //nav
        }

        private void button11_Click(object sender, EventArgs e)
        {
            //nav
        }

       

        private void button7_Click(object sender, EventArgs e)
        {
            //nav
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //nav
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //nav
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //nav
        }













        // private void button12_Click(object sender, EventArgs e)
        // {

        // }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            //panel dashboard
        }

        private void button14_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
