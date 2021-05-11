using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComGrafLab2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Pen Pen1 = new Pen(Color.Black,trackBar1.Value);
            int rect1_x = 200;
            int rect1_y = 200;
            Rectangle rect1 = new Rectangle(rect1_x, rect1_y, trackBar1.Value, trackBar1.Value);

            e.Graphics.DrawRectangle(Pen1, rect1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            pictureBox1.Refresh();
        }

        private void eventLog1_EntryWritten(object sender, System.Diagnostics.EntryWrittenEventArgs e)
        {

        }
    }
    void Form1_KeyPress(object sender, KeyPressEventArgs e)
    {
        if (e.KeyChar >= 48 && e.KeyChar <= 57)
        {
            MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' pressed.");

            switch (e.KeyChar)
            {
                case (char)49:
                case (char)52:
                case (char)55:
                    MessageBox.Show($"Form.KeyPress: '{e.KeyChar}' consumed.");
                    e.Handled = true;
                    break;
            }
        }
    }
}
