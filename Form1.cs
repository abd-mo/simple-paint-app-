using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        int startx, starty;
        Color PenColor=Color.Black;
        bool click=false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i = 1; i < 10; i++)
            {
                toolStripComboBox1.Items.Add(i);
            }
            toolStripComboBox1.SelectedIndex = 2;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            startx = e.X;
            starty = e.Y;
            click = true;

        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(click == true)
            {
                Pen p = new Pen(PenColor, float.Parse(toolStripComboBox1.Text));
                Graphics MyPanel1 = panel1.CreateGraphics();
                MyPanel1.DrawLine(p, startx, starty, e.X, e.Y);
                startx = e.X;
                starty = e.Y;
            }
        }

        

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            PenColor = Color.Blue;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PenColor = Color.Black;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            PenColor = Color.Red;
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            PenColor = Color.Green;
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            PenColor = Color.Yellow;
        }

        private void toolStripButton6_Click(object sender, EventArgs e)
        {
            PenColor = Color.RosyBrown;
        }

        private void toolStripComboBox2_Click(object sender, EventArgs e)
        {
         

    


        }

        private void toolStripContainer1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void toolStripContainer1_MouseUp(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void toolStripContainer1_MouseDown(object sender, MouseEventArgs e)
        {
            click = true;
        }

        private void panel1_MouseUp_1(object sender, MouseEventArgs e)
        {
            click = false;
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            PenColor = Color.White;
        }

        private void toolStripButton8_Click(object sender, EventArgs e)
        {
            panel1.BackColor = Color.White;
            
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
