using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            int curX = e.X;
            int curY = e.Y;
            if (button1.Left - curX < 30 && button1.Left - curX >= 0 && button1.Top < curY && curY < button1.Bottom)
            {
                if ((button1.Left + button1.Width) > this.ClientSize.Width)
                {
                    button1.Top = button1.Top + 27;
                    button1.Left = curX - 27;
                }
                else
                    button1.Left = curX + 30;
            }

            if (button1.Top - curY < 30 && button1.Top - curY >= 0 && button1.Left < curX && curX < button1.Right)
            {
                if ((button1.Top + button1.Height) > this.ClientSize.Height)
                {
                    button1.Top = button1.Top - 30;
                    button1.Left = curX - 80;
                }
                else
                    button1.Top = curY + 30;
            }

            if (curX - button1.Right < 30 && curX - button1.Right >= 0 && button1.Top < curY && curY < button1.Bottom)
            {
                if (button1.Left <= 0 && button1.Bottom+30 < this.ClientSize.Height)
                {
                    button1.Top = button1.Top + 30;
                    button1.Left = curX + 30;
                }
                else if (button1.Left <= 0 && button1.Bottom + 30 > this.ClientSize.Height)
                {
                    button1.Top = button1.Top - 30;
                    button1.Left = curX + 30;
                }
                else
                    button1.Left = curX - 30 - button1.Width;
            }

            if (curY - button1.Bottom < 30 && curY - button1.Bottom >= 0 && button1.Left < curX && curX < button1.Right)
            {
                if (button1.Top <= 0)
                {
                    button1.Top = button1.Top + 30;
                    button1.Left = curX + 30;
                }
                else
                    button1.Top = curY - 30 - button1.Height;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show ("Поздравляем! Вы смогли нажать на кнопку");
        }
    }
    }
