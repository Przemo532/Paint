using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public partial class Form1 : Form
    {
        //private Point start;
        //private Point end;
        Graphics g;
        char currentShape;
        List<Point> points;
        ColorDialog cd;
        List<Image> history = new List<Image>();

        public Form1()
        {
            InitializeComponent();
            nowyToolStripMenuItem_Click(null,null);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            //BackColor = Color.Aqua;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Text = e.Location.ToString() + e.Button;
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void draw(char currentShape, List<Point> points) //Point start, Point end,
        {
            Pen myPen = new Pen(penColorButton.BackColor,(int)penThickness.Value);
            Brush myBrush = new SolidBrush(brushColorButton.BackColor);

            switch (currentShape)
            {
                case 'l':
                    g.DrawLine(myPen, points.First(), points.Last());
                    break;
                case 's':
                    if (fillCheck.Checked)
                    {
                        g.FillRectangle(myBrush,
                            Math.Min(points.First().X, points.Last().X),
                            Math.Min(points.First().Y, points.Last().Y),
                            Math.Abs(points.First().X - points.Last().X),
                            Math.Abs(points.First().Y - points.Last().Y));
                    }
                    g.DrawRectangle(myPen, 
                        Math.Min(points.First().X, points.Last().X),
                        Math.Min(points.First().Y, points.Last().Y),
                        Math.Abs(points.First().X - points.Last().X),
                        Math.Abs(points.First().Y - points.Last().Y));
                    break;
                case 'e':
                    if (fillCheck.Checked)
                    {
                        g.FillEllipse(myBrush,
                            Math.Min(points.First().X, points.Last().X),
                            Math.Min(points.First().Y, points.Last().Y),
                            Math.Abs(points.First().X - points.Last().X),
                            Math.Abs(points.First().Y - points.Last().Y));
                    }
                    g.DrawEllipse(myPen,
                        Math.Min(points.First().X, points.Last().X),
                        Math.Min(points.First().Y, points.Last().Y),
                        Math.Abs(points.First().X - points.Last().X),
                        Math.Abs(points.First().Y - points.Last().Y));
                    break;
                case 'c':
                    g.DrawCurve(myPen, points.ToArray());
                    break;
            }

            while (undoCount > 0)
            {
                history.Remove(history.Last());
                undoCount--;
            }

            Refresh();
        }

        private void drawingSpace_MouseUp(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);
                //end = e.Location;
                draw(currentShape, points);
                history.Add(new Bitmap(drawingSpace.Image));
                drawingSpace.Refresh();
            }
        }


        private void drawingSpace_MouseDown(object sender, MouseEventArgs e)
        {
            points = new List<Point>();
            points.Add(e.Location);

            while (undoCount > 0)
            {
                history.Remove(history.Last());
                undoCount--;
            }
        }

        private void drawingSpace_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void line_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = 'l';
        }

        private void square_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = 's';
        }

        private void elypse_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = 'e';
        }

        private void curve_CheckedChanged(object sender, EventArgs e)
        {
            currentShape = 'c';
        }

        private void drawingSpace_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                points.Add(e.Location);

                drawingSpace.Image = new Bitmap(history.Last());
                g = Graphics.FromImage(drawingSpace.Image);

                //Pen myPen = new Pen(Color.Black, (int)numericUpDownWidthPen.Value);
                //Brush myBrush = new SolidBrush(Color.LightGray);
                draw(currentShape, points);

                drawingSpace.Refresh();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void penColorButton_Click(object sender, EventArgs e)
        {
            cd = new ColorDialog();
            cd.Color = penColorButton.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = cd.Color;
            }
        }

        private void brushColor_Click(object sender, EventArgs e)
        {
            cd = new ColorDialog();
            cd.Color = brushColorButton.BackColor;
            if (cd.ShowDialog() == DialogResult.OK)
            {
                (sender as Button).BackColor = cd.Color;
            }
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            drawingSpace.Image = new Bitmap(drawingSpace.Width, drawingSpace.Height);
            g = Graphics.FromImage(drawingSpace.Image);
            g.Clear(Color.Gray);
            history = new List<Image>();
            undoCount = 0;
            history.Add(new Bitmap(drawingSpace.Image));
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Bitmapa|*.bmp";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                drawingSpace.Image = new Bitmap(ofd.FileName);
                g = Graphics.FromImage(drawingSpace.Image);
                history = new List<Image>();
                undoCount = 0;
                history.Add(new Bitmap(drawingSpace.Image));
            }
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Bitmapa|*.bmp";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                string extension = Path.GetExtension(sfd.FileName);
                switch (extension)
                {
                    case ".bmp":
                        drawingSpace.Image.Save(sfd.FileName, ImageFormat.Bmp);
                        break;
                    case ".jpg":
                        drawingSpace.Image.Save(sfd.FileName, ImageFormat.Jpeg);
                        break;
                }
            }
        }

        int undoCount = 0;
        private void cofnijToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (undoCount < history.Count - 1)
            {
                undoCount++;
                drawingSpace.Image = new Bitmap(history[history.Count-1-undoCount]);
                g = Graphics.FromImage(drawingSpace.Image);
            }
            else
            {
                MessageBox.Show("Nie ma nic do usunięcia");
            }
        }

        private void ponówToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (undoCount > 0) {
                undoCount--;
                drawingSpace.Image = new Bitmap(history[history.Count-1-undoCount]);
                g = Graphics.FromImage(drawingSpace.Image);
            }
        }
    }
}
