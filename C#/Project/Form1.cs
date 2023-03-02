using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        Graphics g;
        Brush Brush;
        Brush player1;
        Brush player2;
        int Board_length;
        int Board_Width;
        int Board_rows;
        int Board_columns;
        int Circle_Size;
        int[,] Board;
        int row_num;
        int col_num;
        Point[,] points;
        int turn = 1;
        Boolean game_mode = false;
        public Form1()
        {
            InitializeComponent();
            g = panel1.CreateGraphics();
            player1 = new SolidBrush(Color.Red);
            player2 = new SolidBrush(Color.Blue);
            Board_Width = panel1.Width = 400;
            Board_length = panel1.Height = 400;
            Circle_Size = 50;
            panel1.BackColor = Color.Beige;
            Board_rows = Board_length / Circle_Size;
            Board_columns = Board_length / Circle_Size;
            Board = new int[Board_rows, Board_columns];
            points = new Point[Board_rows, Board_columns];
            col_num = Board_columns;
            game_mode = true;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Brush = new SolidBrush(Color.White);
            g = panel1.CreateGraphics();

            for (int i = 0, x = 0; i < Board_Width; i += Circle_Size, x++)
            {
                for (int j = 0, y = 0; j < Board_length; j += Circle_Size, y++)
                {

                    g.FillEllipse(Brush, j, i, Circle_Size, Circle_Size);
                    points[x, y] = new Point(j, i);
                }

            }

        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            row_num = Board_rows - 1;
            col_num = (e.X / Circle_Size);

            while (row_num >= 0 && Board[row_num, col_num] > 0)
            {
                row_num--;
            }

            if (Board[row_num, col_num] == 0)
            {
                switch (turn)
                {


                    case 1:    //switch

                        g.FillEllipse(player1, points[row_num, col_num].X, points[row_num, col_num].Y, Circle_Size, Circle_Size);
                        Board[row_num, col_num] = 1;
                        turn = 2;
                        break;
                    case 2:

                        g.FillEllipse(player2, points[row_num, col_num].X, points[row_num, col_num].Y, Circle_Size, Circle_Size);
                        Board[row_num, col_num] = 2;
                        turn = 1;
                        break;
                }
                Hori_Verti_Checker(row_num, col_num);
                Diagonal_Checker(row_num, col_num);

            }


        }

        private void panel1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

            for (int i = 0; i < Board_columns; i++)
            {


                for (int j = 0; j < Board_rows; j++)
                {
                    richTextBox1.AppendText(Board[i, j].ToString() + "\t");

                }
                richTextBox1.AppendText("\n");
            }
        }
        private void Hori_Verti_Checker(int row, int col)
        {



            //horizontal checker                 
            for (int i = 0; i < Board_columns - 3; i++)
            {
                if (Board[row, i] == 1 &&
                    Board[row, i + 1] == 1 &&
                    Board[row, i + 2] == 1 &&
                    Board[row, i + 3] == 1)
                {

                    MessageBox.Show("winner");
                }

            }
            //vertical checker
            for (int i = 0; i < Board_rows - 3; i++)
            {
                if (Board[i, col] == 1 &&
                    Board[i + 1, col] == 1 &&
                    Board[i + 2, col] == 1 &&
                    Board[i + 3, col] == 1)
                {

                    MessageBox.Show("winner");
                }

            }


        }
        private void Diagonal_Checker(int row, int col)
        {
            int r_row = row, l_row = row;
            int r_col = col, l_col = col;
            ////////////////////////right diagonal check///////////////
            while (r_row > 0 && r_col < Board_columns - 1)
            {
                r_row--;
                r_col++;
            }
            //MessageBox.Show(row.ToString() + "," + col.ToString());
            for (int i = r_row, j = r_col; i < Board_columns - 3 && (j > 3); i++, j--)
            {
                if (Board[i, j] == 1 &&
                    Board[i + 1, j - 1] == 1 &&
                    Board[i + 2, j - 2] == 1 &&
                    Board[i + 3, j - 3] == 1)
                {

                    MessageBox.Show("winner");
                }

            }

            ////////////////////left diagonal check///////////////////
            while (l_col > 0 && l_row > 0)
            {
                l_row--;
                l_col--;
            }
            //MessageBox.Show(l_row.ToString()+","+l_col.ToString());
            for (int i = l_row, j = l_col; i < Board_columns - 3 && (j < Board_rows - 3); i++, j++)
            {
                if (Board[i, j] == 1 &&
                    Board[i + 1, j + 1] == 1 &&
                    Board[i + 2, j + 2] == 1 &&
                    Board[i + 3, j + 3] == 1)
                {

                    MessageBox.Show("winner");
                }

            }


        }
    }
}
