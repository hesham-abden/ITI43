using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Windows_App_1
{
    public partial class DialogBox : Form
    {
        public DialogBox()
        {
            InitializeComponent();
        }
        //   public Boolean Times
        //{
        //    //get { return radioButton1.Checked; }
        //    set
        //    {
        //        radioButton1.Checked = value;
        //    }
        //}
        
        
        //public Boolean Arial
        //{
        //    set { radioButton2.Checked = value; }
        //    //get { return radioButton2.Checked; }
        //}
        ////    public Boolean Courier
        ////{
        ////    //set { radioButton3.Checked = value; }
        ////    //get { return radioButton3.Checked; }
        ////}
        public string fontname
        {
            set
            {
                
                foreach (RadioButton radiobutton in tabPage1.Controls)
                {
                    if(radiobutton.Text==value)
                    {
                        radiobutton.Checked = true;
                    }
                }
 
            }
            get
            {
                string tempname="";
                foreach  (RadioButton radioButton in tabPage1.Controls)
                {
                    if(radioButton.Checked)
                    {
                       tempname= radioButton.Text;
                    }
                }
                return tempname;
            }
          
        }
        public int fontsize
        {
            get
            {
                int tempsize =20;
                foreach (RadioButton radiobutton in tabPage2.Controls)
                {
                    if(radiobutton.Checked)
                    {
                        tempsize = int.Parse(radiobutton.Text);
                    }
                }
                return tempsize;
            }
            set
            {
                foreach (RadioButton radiobutton in tabPage2.Controls)
                {
                    if (int.Parse(radiobutton.Text) == value)
                    {
                        radiobutton.Checked = true;
                    }
                }
            }
        }
        
        public Color str_Color
        {
            set
            {
                colorDialog1.Color = value;
            }
            get { return colorDialog1.Color; }
        }
        public string TxtBox
        {
            set { textBox2.Text = value; }
            get
            {
                string str;
                if (textBox1.Text == "")
                {
                    str = textBox2.Text;
                }
                else
                {
                    str = textBox1.Text;
                }
                return str;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult=DialogResult.OK;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            colorDialog1.ShowDialog();

        }
        
       
    }

    

        
 }

