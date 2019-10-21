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
        private void doors_close()
        {
            while (panel1.Location.X != 45)
            {
                System.Threading.Thread.Sleep(50);
                panel1.Location = new Point(panel1.Location.X - 1, panel1.Location.Y);
                panel3.Location = new Point(panel3.Location.X + 1, panel3.Location.Y);
            }
        } //закрытие дверей

        private void doors_open()
        {
            while (panel1.Location.X != 85)
            {
                System.Threading.Thread.Sleep(50);
                panel1.Location = new Point(panel1.Location.X + 1, panel1.Location.Y);
                panel3.Location = new Point(panel3.Location.X - 1, panel3.Location.Y);
            }
        } //открытие дверей

        private void button1_Click(object sender, EventArgs e)
        {

            level_dest = 1;
            moving_elevator(level_dest, level_now);
            level_now = 1;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            level_dest = 2;
            moving_elevator(level_dest, level_now);
            level_now = 2;
        }


        private void button3_Click(object sender, EventArgs e)
        {
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
            doors_close();
            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y + 1); // поменять на 1
            i = i + 1;
            if (i == 112) //поменять на ==
            {
                i = 0;
                doors_open();
                timer1.Enabled = false;
            }
         }

        private void timer2_Tick(object sender, EventArgs e) // повышение этажа на +1 уровень
        {
            doors_close();
            panel2.Location = new Point(panel2.Location.X, panel2.Location.Y - 1); // поменять на 1
            i = i + 1;
            if (i == 112)
            {
                i = 0;
                doors_open();
                   
                timer2.Enabled = false;
            }
           
        }

        private void timer3_Tick(object sender, EventArgs e) // +2 уровня
        {
            doors_close();
            panel2.Location = new System.Drawing.Point(panel2.Location.X, panel2.Location.Y - 1); // поменять на 1
            i = i + 1;
            if (i == 224)
            {
                i = 0;
                doors_open();
                timer3.Enabled = false;

            }
        }

        private void timer4_Tick(object sender, EventArgs e)  //-2 уровня
        {
            doors_close();
            panel2.Location = new System.Drawing.Point(panel2.Location.X, panel2.Location.Y + 1); // поменять на 1
            i = i + 1;
            if (i == 224)
            {
                i = 0;
                doors_open();
                timer4.Enabled = false;
            }
        }

    }
}
