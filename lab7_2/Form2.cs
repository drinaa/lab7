using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab7_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.pictureBox1.Width = this.Width / 3;
            this.pictureBox1.Height = this.Width / 3;
            this.trackBar1.Width = this.Width / 5*2;
            this.trackBar2.Width = this.Width / 5*2;
            this.trackBar3.Width = this.Width / 5*2;
            this.trackBar1.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 6);
            this.label1.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 6);
            this.label4.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 6 + 20);
            this.label7.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 6 + 20);
            this.trackBar2.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 2);
            this.label2.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 2);
            this.label5.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 2 + 20);
            this.label8.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 2 + 20);
            this.trackBar3.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 3);
            this.label3.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 3);
            this.label6.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 3 + 20);
            this.label9.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 3 + 20);
            Clipboard.SetText("#7D7D7D");
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Clipboard.SetText("#" + Convert.ToString(trackBar1.Value, 16).ToUpper() + Convert.ToString(trackBar2.Value, 16).ToUpper() + Convert.ToString(trackBar3.Value, 16).ToUpper());
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Clipboard.SetText("#" + Convert.ToString(trackBar1.Value, 16).ToUpper() + Convert.ToString(trackBar2.Value, 16).ToUpper() + Convert.ToString(trackBar3.Value, 16).ToUpper());
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            pictureBox1.BackColor = Color.FromArgb(trackBar1.Value, trackBar2.Value, trackBar3.Value);
            Clipboard.SetText("#" + Convert.ToString(trackBar1.Value, 16).ToUpper() + Convert.ToString(trackBar2.Value, 16).ToUpper() + Convert.ToString(trackBar3.Value, 16).ToUpper());
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            label10.Text = "";
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            label10.Text = "#" + Convert.ToString(trackBar1.Value, 16).ToUpper() + Convert.ToString(trackBar2.Value, 16).ToUpper() + Convert.ToString(trackBar3.Value, 16).ToUpper();
        }

        private void Form2_Resize(object sender, EventArgs e)
        {
            if (this.pictureBox1.Height != this.pictureBox1.Width)
            {
                this.pictureBox1.Width = this.pictureBox1.Height;
            }
            this.trackBar1.Width = this.Width / 3;
            this.trackBar2.Width = this.Width / 3;
            this.trackBar3.Width = this.Width / 3;
            this.trackBar1.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 6);
            this.label1.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 6);
            this.label4.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 6 + 20);
            this.label7.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 6 + 20);
            this.trackBar2.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 2);
            this.label2.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 2);
            this.label5.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 2 + 20);
            this.label8.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 2 + 20);
            this.trackBar3.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 3);
            this.label3.Location = new Point(this.Width - this.trackBar1.Width - 80, this.Height / 3);
            this.label6.Location = new Point(this.Width - this.trackBar1.Width - 40, this.Height / 3 + 20);
            this.label9.Location = new Point(this.Width - this.trackBar1.Width - 40 + this.trackBar1.Width, this.Height / 3 + 20);
        }
    }
}
