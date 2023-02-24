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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public Color str_Color
        {
            set
            {
                colorDialog1.Color = value;
            }
            get { return colorDialog1.Color; }
        }
        public int fontsize
        {
            get
            {
                int tempsize = 1;
                foreach (RadioButton radiobutton in Thickness.Controls)
                {
                    if (radiobutton.Checked)
                    {
                        tempsize = int.Parse(radiobutton.Text);
                    }
                }
                return tempsize;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            colorDialog1.ShowDialog();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
