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

        private int level_dest = 1;
        private int level_now = 1;

        private int i = 0;

        public Form1()
        {

            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //    нажали кнопку этажа и показали картинку этажа, затем указакли в level_dest данный этаж из кнопки, запустили
            //        функцию с значением переменной конкретного этажа из предыдущего нажатия( по умолч. 1) и текущего level_dest

          //  this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator-master\\elevator ver 1\\elevator_1stfloor.jpg");

            level_dest = 1;
            moving_elevator(level_dest, level_now);
            level_now = 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            //    нажали кнопку этажа и показали картинку этажа, затем указакли в level_dest данный этаж из кнопки, запустили
            //        функцию с значением переменной конкретного этажа из предыдущего нажатия( по умолч. 1) и текущего level_dest

            //this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator-master\\elevator ver 1\\elevator_2ndfloor.jpg");

            level_dest = 2;
            moving_elevator(level_dest, level_now);
            level_now = 2;
        }


        private void button3_Click(object sender, EventArgs e)
        {
        //    нажали кнопку этажа и показали картинку этажа, затем указакли в level_dest данный этаж из кнопки, запустили
        //        функцию с значением переменной конкретного этажа из предыдущего нажатия( по умолч. 1) и текущего level_dest
            
          //  this.pictureBox1.Image = Image.FromFile("C:\\Users\\asherbakov\\Desktop\\elevator-master\\elevator ver 1\\elevator_3rdfloor.jpg");
           
            level_dest = 3;
            moving_elevator(level_dest, level_now);
            level_now = 3;
        }


        private void moving_elevator(int level_dest, int level_current) //проверка текущего этажа и этажа куда направаляемся
        {
            if (level_current == 1) //первый этаж СЕЙЧАС
            {
                switch (level_dest)
                {
                    case 2: //направляемся на 2
                        {
                            timer2.Enabled = true;
                            break;
                        }
                    case 3: //напряавляемся на 3
                        {
                                timer3.Enabled = true;
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (level_current == 2) // второй этаж СЕЙЧАС
            {
                switch (level_dest)
                {
                    case 3: //направляемся на 3
                        {
                            timer2.Enabled = true;
                            break;
                        }
                    case 1: // направляемся на 1
                        {
                            timer1.Enabled = true;
                            break;
                        }
                    default:
                        break;
                }
            }
            else if (level_current == 3) //третий этаж СЕЙЧАС
            {
                switch (level_dest)
                {
                    case 2: //направляемся на 2
                        {
                            timer1.Enabled = true;
                            break;
                        }
                    case 1: //направляемся на 1
                        {
                                timer4.Enabled = true;
   
                            break;
                        }
                    default:
                        break;
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e) // понижение этажа на -1 уровень
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1); // поменять на 1
            i = i + 1;
            if (i == 112) //поменять на ==
            {
                i = 0;
                timer1.Enabled = false;
            }
         }


        private void timer2_Tick(object sender, EventArgs e) // повышение этажа на +1 уровень
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1); // поменять на 1
            i = i + 1;
            if (i == 112) //поменять на ==
            {
                i = 0;
                timer2.Enabled = false;
                
            }
        }

        private void timer3_Tick(object sender, EventArgs e) // +2 уровня
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y - 1); // поменять на 1
            i = i + 1;
            if (i == 224) //поменять на ==
            {
                i = 0;
                timer3.Enabled = false;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)
        {
            pictureBox1.Location = new System.Drawing.Point(pictureBox1.Location.X, pictureBox1.Location.Y + 1); // поменять на 1
            i = i + 1;
            if (i == 224) //поменять на ==
            {
                i = 0;
                timer4.Enabled = false;
            }
        }
    }
}
