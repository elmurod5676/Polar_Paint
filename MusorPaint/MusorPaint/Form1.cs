using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusorPaint
{
    public partial class Form1 : Form
    {
        Graphics graphics;
        bool cursorMoving = false;
        Pen cursorPen;
        int cursorX = -1;
        int cursorY = -1;

        public Form1()
        {
            InitializeComponent();
            graphics = canvas.CreateGraphics();
            cursorPen = new Pen(Color.Black, 5);
            graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            cursorPen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
            cursorPen.EndCap = System.Drawing.Drawing2D.LineCap.Round;
            mColorsPanel.Hide();
            PensPanel.Hide();
        }

        private void blackBox_Click(object sender, EventArgs e)
        {
            PictureBox color = (PictureBox)sender;
            cursorPen.Color = color.BackColor;
        }

        private void canvas_MouseDown(object sender, MouseEventArgs e)
        {
            cursorMoving = true;
            cursorX = e.X;
            cursorY = e.Y;

        }

        private void canvas_MouseUp(object sender, MouseEventArgs e)
        {
            cursorMoving = false;
            cursorX = -1;
            cursorY = -1;
        }

        private void canvas_MouseMove(object sender, MouseEventArgs e)
        {
            if (cursorX != -1 && cursorY != -1 && cursorMoving == true)
            {
                graphics.DrawLine(cursorPen, new Point(cursorX, cursorY), e.Location);
                cursorX = e.X;
                cursorY = e.Y;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            ClearCanvas();
        }
        private void ClearCanvas()
        {
            graphics.Clear(Color.White);
        }

        private void moreColors_Click(object sender, EventArgs e)
        {
            mColorsPanel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mColorsPanel.Hide();
        }
        private void morePen_Click(object sender, EventArgs e)
        {
            PensPanel.Show();
        }

        private void morePenoff_Click(object sender, EventArgs e)
        {
            PensPanel.Hide();
        }

        private void Pen2_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 2);
        }

        private void Pen4_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 4);
        }

        private void Pen6_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 6);
        }

        private void Pen8_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 8);
        }

        private void Pen10_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 10);
        }

        private void Pen12_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 12);
        }

        private void Pen14_Click(object sender, EventArgs e)
        {
            cursorPen = new Pen(cursorPen.Color, 14);
        }
    }
}
