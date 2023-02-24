using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tester
{
    public partial class Form1 : Form
    {
        Boolean click;
        Graphics g;
       
        Pen pen;
        Brush brush;
        float x;
        float y;
        float mx;
        float my;
        public Form1()
        {
            InitializeComponent();
            click=false;
            g = this.CreateGraphics();
          
            Brush brush = new SolidBrush(Color.Red);
            pen = new Pen(brush);
            g.DrawEllipse(pen, 0, 5, 100, 50);
            


        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {   
                g.DrawRectangle(pen,mx,my,x,y);
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            click=true;
            mx = e.X;
            my = e.Y;
            

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            click =false;
            Graphics f = this.CreateGraphics();
            float []temp ={ mx, my, x, y };
            f.DrawRectangle(pen, temp[0], temp[1], temp[2], temp[3]);

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (click)
            {
                x = e.X - mx;
                y = e.Y - my ;
                this.Refresh();
               
            }
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if(e.KeyChar ==' ')
            {
                g.DrawRectangle(pen, mx, my, x, y);
            }
            
        }
    }
}
