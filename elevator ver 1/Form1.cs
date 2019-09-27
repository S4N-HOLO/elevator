using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;

namespace elevator_ver_1
{
    public partial class Form1 : Form
    {
        private int i = 0;
        public Form1()
        {
    

            InitializeComponent();
            //pictureBox1.Visible = false;
           //this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator_1stfloor.jpg");
        }

            
        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Visible = true;
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator_1stfloor.jpg");
           // changing_pos(404, 209, 1);
            pictureBox1.Location = new System.Drawing.Point(404, 321);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator_2ndfloor.jpg");
            //pictureBox1.Visible = true;
            timer2.Enabled = true;
            //pictureBox1.Location = new System.Drawing.Point(404, 209);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator_3rdfloor.jpg");
           // pictureBox1.Visible = true;
            timer1.Enabled = true;
            
           // pictureBox1.Location = new System.Drawing.Point(404, 98);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            //int pos = (pictureBox1.Location.Y + 112);
            
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1);
            i = i + 1;
            if (i == 112)
            {
                i = 0;
                timer1.Enabled = false;
            }
        
            }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1);
            i = i + 1;
            if (i == 112)
            {
                i = 0;
                timer2.Enabled = false;
                
            }
        }

    
    }
}
