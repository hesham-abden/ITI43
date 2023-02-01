using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_App_1
{
    public partial class Form1 : Form
    {
        //Company_Name
        string CName;
        Font CFont;
        Brush CBrush;
        Color CColor;
        PointF CPoint;
        //Underline
        Pen CLPen;
        PointF CLStartPoint;
        PointF CLEndPoint;
        DashStyle CLDashStyle;
        Color CLColor;
        //Title
        string TName;
        Font TFont;
        Brush TBrush;
        Color TColor;
        PointF TPoint;
        /// SecondLine
        Pen TLPen;
        PointF TLStartPoint;
        PointF TLEndPoint;
        DashStyle TLDashStyle;
        Color TLColor;
        /// Table
        Color RColor;
        Pen RPen;
        Rectangle Rec;
        //TableContent
        List<string> T_Year = new List<string> { "Year", "1988", "1989", "1990", "1991", "1992", "1993", "1994", "1995", "1996", "1997" };
        List<string> T_Revenue = new List<string> { "Revenue", "150", "170", "180", "175", "200", "250", "210", "240", "280", "140" };
        string Table_Content;
        Font TCFont;
        Brush TCBrush;
        Color TCColor;
        PointF TCPoint;
        //Plot
         int PlotX = 100;
         int PlotY = 600;
         int XAxis;
         int YAxis;
         int PlotLength;
         int Step;
        int YScale;
        int XScale;
        Pen PPen;
        PointF PStartPoint;
        PointF PEndPointX;
        PointF PEndPointY;
        DashStyle PDashStyle;
        Color PColor;
        Font PFont;
        Brush PBrush;
        Color LineColor;
        Pen LinePen;
        DashStyle LineDashStyle;
        Color BarColor;
        Brush BarBrush;
        Pen BarPen;
        HatchStyle BarStyle;










        public Form1()
        {
            InitializeComponent();
            
            WindowState = FormWindowState.Maximized;
            Graphics z = this.CreateGraphics();
            CName = "ABC Company";
            CColor = Color.Black;
            CFont = new Font("Times New Roman", 20);
            CBrush = new SolidBrush(CColor);
            SizeF Csize = z.MeasureString(CName, CFont);
            CPoint = new PointF((this.Width) / 2 - (Csize.Width) / 2, 50);
            //////////////////////////////////////////////////////
            CLColor = Color.Black;
            CLPen = new Pen(CLColor, 3);
            CLDashStyle = DashStyle.Solid;
            CLPen.DashStyle = CLDashStyle;
            CLStartPoint = new PointF((this.Width-Csize.Width)/2, Csize.Height+50);
            CLEndPoint = new PointF(this.Width/2+Csize.Width/2, Csize.Height+50);
            ///////////////////////////////////
            TName = "Annual Revenue";
            TColor = Color.Black;
            TFont = new Font("Times New Roman", 20);
            TBrush = new SolidBrush(TColor);
            SizeF titleSize = z.MeasureString(TName, TFont);
            TPoint = new PointF((this.Width) / 2 - (titleSize.Width) / 2, Csize.Height+80);
            /////////////////////////////////////
            TLColor = Color.Black;
            TLPen = new Pen(TLColor, 3);
            TLDashStyle = DashStyle.Solid;
            TLPen.DashStyle = TLDashStyle;
            TLStartPoint = new PointF((this.Width-titleSize.Width)/2, Csize.Height+titleSize.Height + 80);
            TLEndPoint = new PointF((this.Width+titleSize.Width)/2, Csize.Height+titleSize.Height + 80);
            ///////////////////////////////////
            ///Table
            RColor = Color.Black;
            RPen = new Pen(RColor, 1);
            ////////// Table Content
            Graphics a = this.CreateGraphics();
            TCColor = Color.Black;
            TCFont = new Font("Times New Roman", 20);
            TCBrush = new SolidBrush(TCColor);
            //////// Plot
            XAxis = 1987;
            YAxis = 100;
            PlotLength = 400;
            Step = PlotLength/11;
            YScale = 20;
            XScale = 1;
            PColor = Color.Black;
            PPen = new Pen(PColor, 2);
            PDashStyle = DashStyle.Solid;
            PPen.DashStyle = PDashStyle;
            PFont = new Font("Times New Roman", 10);
            PBrush= new SolidBrush(PColor);
            //LineChart
            LineColor = Color.Blue;
            LinePen=new Pen(LineColor, 3);
            //BarChart
            BarColor = Color.Red;
            BarStyle = HatchStyle.BackwardDiagonal;
            
            
            







        }
        protected override void OnPaint(PaintEventArgs e)
        {
            DisplayCompanyName();
            DrawLine();
            DisplayTitle();
            DisplayTable();
            DisplayPlot();
            DisplayBarChart();
            DisplayLineChart();
            DisplayChecker();
            
            

        }
        public void DisplayCompanyName()
        {
            Graphics g = this.CreateGraphics();
            g.DrawString(CName, CFont, CBrush,CPoint);
        }
        public void DrawLine()
        {
            Graphics g=this.CreateGraphics();
            g.DrawLine(CLPen, CLStartPoint, CLEndPoint);
            g.DrawLine(TLPen, TLStartPoint, TLEndPoint);
        }
        public void DisplayTitle()
        {
            Graphics g = this.CreateGraphics();
            g.DrawString(TName, TFont, TBrush, TPoint);
            
            

        }
        public void DisplayTable()
        {
            Graphics g = this.CreateGraphics();
            
            int TableY = 100;
            int width = 50;
            int height = 120;
            SizeF TCsize;
            
            for (int i=0;i<11;i++)
            {
                int TableX = 1100;
                for (int j = 0; j < 2; j++)
                {
                    if (j % 2 == 0)
                    {
                        Table_Content = T_Revenue[i].ToString();
                    }
                    else
                    {
                        Table_Content = T_Year[i];
                    }
                    Rec = new Rectangle(TableX, TableY, height, width);
                    g.DrawRectangle(RPen, Rec);
                    TCsize = g.MeasureString(Table_Content, TCFont);
                    g.DrawString(Table_Content, TCFont, TCBrush, TableX+55 - (TCsize.Width)/2, TableY+10);
                    TableX += height; 
                }
                TableY+=50;
                
            }

            

            
        }
        public void DisplayPlot()
        {
            Graphics g = this.CreateGraphics();
            
            PStartPoint = new PointF(PlotX, PlotY);
            PEndPointX = new PointF(PlotX + PlotLength, PlotY);
            PEndPointY = new PointF(PlotX, PlotY - PlotLength);
            g.DrawLine(PPen, PStartPoint, PEndPointX);
            g.DrawLine(PPen, PStartPoint, PEndPointY);
            ////Arrows
            g.DrawLine(PPen, PEndPointX,new Point(PlotX+PlotLength-5,PlotY-5));
            g.DrawLine(PPen, PEndPointX, new Point(PlotX + PlotLength - 5, PlotY + 5));
            g.DrawString(T_Year[0], PFont, PBrush, PEndPointX.X,PEndPointX.Y-5);
            g.DrawLine(PPen, PEndPointY, new Point(PlotX - 5, PlotY-PlotLength + 5));
            g.DrawLine(PPen, PEndPointY, new Point(PlotX + 5, PlotY-PlotLength + 5));
            g.DrawString(T_Revenue[0], PFont, PBrush, PEndPointY.X-25,PEndPointY.Y-15);



            for (int i = 1; i < 11; i++)
            {
                PointF IndicatorStart = new PointF(PlotX + Step * i, PlotY);
                PointF IndicatorEnd = new PointF(PlotX + Step * i, PlotY + 5);
                SizeF ElementSize = g.MeasureString(XAxis.ToString(), PFont);
                g.DrawString((XAxis + XScale * i).ToString(), PFont, PBrush, PlotX + Step * i - (ElementSize.Width / 2), PlotY + 5);
                g.DrawLine(PPen, IndicatorStart, IndicatorEnd);
                IndicatorStart = new PointF(PlotX, PlotY - Step * i);
                IndicatorEnd = new PointF(PlotX - 5, PlotY - Step * i);
                ElementSize = g.MeasureString(YAxis.ToString(), PFont);
                g.DrawString((YAxis + i *YScale).ToString(), PFont, PBrush, PlotX - 30, PlotY - Step * i - (ElementSize.Width / 2));
                g.DrawLine(PPen, IndicatorStart, IndicatorEnd);
            }
            
        }
        public void DisplayLineChart() {
            Graphics g = this.CreateGraphics();
            for (int i = 1; i < 10; i++)
            {

                Point PStart = new Point(PlotX + (int.Parse(T_Year[i]) - XAxis) * Step/XScale, PlotY - (int.Parse(T_Revenue[i]) - YAxis) * (Step)/YScale);
                Point PEnd = new Point(PlotX + (int.Parse(T_Year[i + 1]) - XAxis) * Step/XScale, PlotY - (int.Parse(T_Revenue[i + 1]) - YAxis) * (Step)/YScale);
                g.DrawLine(LinePen, PStart, PEnd);
                //MessageBox.Show((PlotX + (int.Parse(T_Year[i]) - XAxis) * Step / XScale).ToString());
            }
        }
        public void DisplayBarChart()
        {
            Graphics g = this.CreateGraphics();
            BarBrush = new HatchBrush(BarStyle, BarColor);
            BarPen = new Pen(BarBrush, 1);
            for (int i = 1; i < 11; i++)
            {
                Point PStarta = new Point(PlotX + (int.Parse(T_Year[i]) - XAxis) * Step / XScale, PlotY - (int.Parse(T_Revenue[i]) - YAxis) * (Step)/YScale);
                Rectangle BarChart = new Rectangle(PStarta.X, PStarta.Y, 20, PlotY - PStarta.Y);
                g.DrawRectangle(BarPen, BarChart);
                g.FillRectangle(BarBrush, BarChart);
            }
            

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys K_Control = e.Modifiers;
            if (K_Control == Keys.Control)
            {
                switch (e.KeyCode)
                {
                    case Keys.R:
                        LineColor = Color.Red;
                        break;
                    case Keys.G:
                        LineColor = Color.Green;
                        break;
                    case Keys.B:
                        LineColor = Color.Blue;
                        break;
                        
                }
                LinePen.Color=LineColor;
                Invalidate(new Rectangle(new Point(PlotX, PlotY), new Size(PlotLength,PlotLength)));
            }
            
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if(PlotX+PlotLength>e.X&&PlotX<e.X&&PlotY-PlotLength<e.Y&&PlotY>e.Y)
            {
                if (e.Button == MouseButtons.Left)
                {
                    float x = (float)Step / YScale;
                    int X_Coord = ((e.X - PlotX) / Step) * XScale + XAxis;
                    float Y_Coord = (((YAxis - (e.Y - PlotY) / x)));
                    MessageBox.Show("Year :" + X_Coord.ToString() + " ,  Revenue : " + Y_Coord.ToString("0.00"));
                }
                if(e.Button == MouseButtons.Right)
                {
                    contextMenuStrip2.Show(e.X, e.Y);
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(e.X, e.Y);
            }
            
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {

            LineColor = Color.Red;
            LinePen.Color = LineColor;
            Invalidate(new Rectangle(new Point(PlotX, PlotY), new Size(PlotLength, PlotLength)));

        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineColor = Color.Green;
            LinePen.Color = LineColor;
            Invalidate(new Rectangle(new Point(PlotX, PlotY), new Size(PlotLength, PlotLength)));
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineColor = Color.Blue;
            LinePen.Color = LineColor;
            Invalidate(new Rectangle(new Point(PlotX, PlotY), new Size(PlotLength, PlotLength)));
        }

        private void dashToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineDashStyle = DashStyle.Dash;
            LinePen.DashStyle = LineDashStyle;
            Invalidate();
        }

        private void dottedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineDashStyle = DashStyle.Dot;
            LinePen.DashStyle = LineDashStyle;
            
            Invalidate();

        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LineDashStyle = DashStyle.Solid;
            LinePen.DashStyle = LineDashStyle;
            Invalidate();
        }

        private void redToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarColor = Color.Red;
            Invalidate();
        }

        private void greenToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarColor = Color.Green;
            Invalidate();
        }

        private void blueToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarColor = Color.Blue;
            Invalidate();
        }

        private void rightToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarStyle = HatchStyle.BackwardDiagonal;
            Invalidate();
        }

        private void leftToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarStyle = HatchStyle.ForwardDiagonal;
            
            Invalidate();
        }

        private void crossToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            BarStyle = HatchStyle.Cross;
            Invalidate();
        }

        
        public void Checker(params ToolStripMenuItem[] item)
        {
            foreach(ToolStripMenuItem x in item)
            
                x.CheckState = CheckState.Indeterminate;
            

        }
        public void UnChecked (params ToolStripMenuItem[] item)
        {
            foreach (ToolStripMenuItem x in item)

                x.CheckState = CheckState.Unchecked;
        }
        public void DisplayChecker()
        {
            if (LineColor == Color.Red)
            {
                Checker(redToolStripMenuItem, redToolStripMenuItem2, redToolStripMenuItem4);
                UnChecked(greenToolStripMenuItem, greenToolStripMenuItem2, greenToolStripMenuItem4);
                UnChecked(blueToolStripMenuItem, blueToolStripMenuItem2, blueToolStripMenuItem4);
            }
            else if(LineColor == Color.Green)
            {
                UnChecked(redToolStripMenuItem, redToolStripMenuItem2, redToolStripMenuItem4);
                Checker(greenToolStripMenuItem, greenToolStripMenuItem2, greenToolStripMenuItem4);
                UnChecked(blueToolStripMenuItem, blueToolStripMenuItem2, blueToolStripMenuItem4);
            }
            else if(LineColor == Color.Blue)
            {
                UnChecked(redToolStripMenuItem, redToolStripMenuItem2, redToolStripMenuItem4);
                UnChecked(greenToolStripMenuItem, greenToolStripMenuItem2, greenToolStripMenuItem4);
                Checker(blueToolStripMenuItem, blueToolStripMenuItem2, blueToolStripMenuItem4);
            }
            if (BarColor == Color.Red)
            {
                Checker(redToolStripMenuItem1, redToolStripMenuItem3, redToolStripMenuItem5);
                UnChecked(greenToolStripMenuItem1, greenToolStripMenuItem3, greenToolStripMenuItem5);
                UnChecked(blueToolStripMenuItem1, blueToolStripMenuItem3, blueToolStripMenuItem5);
            }
            else if (BarColor == Color.Green)
            {
                UnChecked(redToolStripMenuItem1, redToolStripMenuItem3, redToolStripMenuItem5);
                Checker(greenToolStripMenuItem1, greenToolStripMenuItem3, greenToolStripMenuItem5);
                UnChecked(blueToolStripMenuItem1, blueToolStripMenuItem3, blueToolStripMenuItem5);
            }
            else if (BarColor == Color.Blue)
            {
                UnChecked(redToolStripMenuItem1, redToolStripMenuItem3, redToolStripMenuItem5);
                UnChecked(greenToolStripMenuItem1, greenToolStripMenuItem3, greenToolStripMenuItem5);
                Checker(blueToolStripMenuItem1, blueToolStripMenuItem3, blueToolStripMenuItem5);
            }
            if (LineDashStyle == DashStyle.Solid)
            {
                UnChecked(dashToolStripMenuItem, dashToolStripMenuItem2, dashToolStripMenuItem1);
                Checker(solidToolStripMenuItem, solidToolStripMenuItem2, solidToolStripMenuItem1);
                UnChecked(dottedToolStripMenuItem, dottedToolStripMenuItem2, dottedToolStripMenuItem1);
            }
             else if (LineDashStyle == DashStyle.Dash)
                {
                Checker(dashToolStripMenuItem, dashToolStripMenuItem2, dashToolStripMenuItem1);
                UnChecked(solidToolStripMenuItem, solidToolStripMenuItem2, solidToolStripMenuItem1);
                UnChecked(dottedToolStripMenuItem, dottedToolStripMenuItem2, dottedToolStripMenuItem1);
            }
            if (LineDashStyle == DashStyle.DashDot)
            {
                UnChecked(dashToolStripMenuItem, dashToolStripMenuItem2, dashToolStripMenuItem1);
                UnChecked(solidToolStripMenuItem, solidToolStripMenuItem2, solidToolStripMenuItem1);
                Checker(dottedToolStripMenuItem, dottedToolStripMenuItem2, dottedToolStripMenuItem1);
            }

            if (BarStyle == HatchStyle.BackwardDiagonal)
            {
                Checker(rightToolStripMenuItem, rightToolStripMenuItem2, rightToolStripMenuItem1);
                UnChecked(leftToolStripMenuItem, leftToolStripMenuItem2, leftToolStripMenuItem1);
                UnChecked(crossToolStripMenuItem, crossToolStripMenuItem2, crossToolStripMenuItem1);
            }
            else if (BarStyle == HatchStyle.ForwardDiagonal)
            {
                UnChecked(rightToolStripMenuItem, rightToolStripMenuItem2, rightToolStripMenuItem1);
                Checker(leftToolStripMenuItem, leftToolStripMenuItem2, leftToolStripMenuItem1);
                UnChecked(crossToolStripMenuItem, crossToolStripMenuItem2, crossToolStripMenuItem1);
            }
            if (BarStyle == HatchStyle.Cross)
            {
                UnChecked(rightToolStripMenuItem, rightToolStripMenuItem2, rightToolStripMenuItem1);
                UnChecked(leftToolStripMenuItem, leftToolStripMenuItem2, leftToolStripMenuItem1);
                Checker(crossToolStripMenuItem, crossToolStripMenuItem2, crossToolStripMenuItem1);
            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (PlotX + PlotLength > e.X && PlotX < e.X && PlotY - PlotLength < e.Y && PlotY > e.Y)
            {
                float x = (float)Step / YScale;
                int X_Coord = ((e.X - PlotX) / Step) * XScale + XAxis;
                float Y_Coord = (((YAxis - (e.Y - PlotY) / x)));
                toolStripStatusLabel1.Text ="Year :"+ X_Coord.ToString();
                toolStripStatusLabel2.Text = "Renvenue : " + Y_Coord.ToString();
            }
        }

        
    }

}

