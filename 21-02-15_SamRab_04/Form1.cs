using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21_02_15_SamRab_04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);
            g.Clear(pictureBox1.BackColor);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            g.DrawLine(new Pen(Color.Black, 3), 10, 20, 200, 10);
            g.DrawLine(new Pen(Color.Black, 3), 10, 20, 200, 10);
            g.DrawRectangle(System.Drawing.Pens.Black, 10, 30, 190, 20);
            g.FillRectangle(System.Drawing.Brushes.Blue, 10, 60, 190, 20);
            g.DrawEllipse(new Pen(Color.Red, 3), 10, 100, 190, 30);
            g.FillEllipse(System.Drawing.Brushes.Green, 10, 140, 190, 30);
            g.DrawArc(new Pen(Color.Red, 3), 10, 180, 190, 30, 0, 180);
            g.FillPie(System.Drawing.Brushes.Green, 10, 200, 190, 80, 0, 180);
            Font f = new System.Drawing.Font ( "Time New Roman", 12, System.Drawing.FontStyle.Bold );
            SolidBrush f1 = new SolidBrush(Color.Green);
            g.DrawString("Линия ", f, f1, 210, 10);
            g.DrawString("Прямоугольник ", f, f1, 210, 50);
            g.DrawString("Эллипс ", f, f1, 210, 130);
            g.DrawString("Дуга ", f, f1, 210, 190);
            g.DrawString("Сектор ", f, f1, 210, 240);
        }
     }
}
