using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task
{
    public partial class Form1 : Form
    {
        Pen pen;
        
        Color color;
        Font font;
        int size;
        Graphics g;
        Boolean Drawing=false;
        enum Shape
        {
            Line,
            Circle,
            Rectangle,
            FreeHand,
            
        }
        Shape shape;
        Form2 dlg = new Form2();
        float x1, y1, x2, y2;
        public Form1()
        {
            InitializeComponent();
            color = Color.Black; 
            size = 1;
            font =new Font("Times New Roman",size);
            g = this.CreateGraphics();
            pen = new Pen(color,size);
            shape = Shape.Line;
            ColorStatus.Text = "" + color;
            ThicknessStatus.Text = "Size :" + size.ToString();
            ShapeStatus.Text = shape.ToString();
            


        }
        protected override void OnPaint(PaintEventArgs e)
        {

            

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pic = new PictureBox();
            
            pic.Image.Save(@"F:\pic.iti", System.Drawing.Imaging.ImageFormat.Png);
            this.Close();
        }

       
        private void lineToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape=Shape.Line;
            ShapeStatus.Text = shape.ToString();

        }

        private void circleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Circle;
            ShapeStatus.Text = shape.ToString();

        }

        private void rectangleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.Rectangle;
            ShapeStatus.Text = shape.ToString();

        }





        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            x2 = e.X;
            y2 = e.Y;
            Graphics t = this.CreateGraphics();
            Brush brush= new SolidBrush(color);
            if (Drawing&&shape==Shape.FreeHand)
            {
                t.DrawString("*", font, brush, x2, y2);

            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            Drawing = true;
            x1 = e.X;
            y1 = e.Y;
            pen = new Pen(color, size);
            font = new Font("New Times Roman", size);
            switch (shape)
            {
                case Shape.Line:
                    g.DrawLine(pen, x1, y1, x1+100, y1+100);
                    break;
                case Shape.Circle:
                    g.DrawEllipse(pen,x1,y1,50,50);
                    break;
                case Shape.Rectangle:
                    g.DrawRectangle(pen, x1, y1, 50,50);
                    break;
                case Shape.FreeHand:
                    
                    break;
                default:
                    break;
            }
            
        }

     

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Drawing = false;
        }

        private void freeHandToolStripMenuItem_Click(object sender, EventArgs e)
        {
            shape = Shape.FreeHand;
            ShapeStatus.Text = shape.ToString();
        }

        private void styleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult=dlg.ShowDialog();
            
            if (DialogResult == DialogResult.OK)
            {
                color = dlg.str_Color;
                size = dlg.fontsize;
                ColorStatus.Text = "" + color;
                ThicknessStatus.Text ="Size :" +size.ToString();
            }
        }

        
    }
}
