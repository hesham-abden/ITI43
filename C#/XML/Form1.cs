using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XmlDocument xml=new XmlDocument();
            xml.Load(@"C:\Users\Dell\Desktop\Untitled1.xml");
            name.Text = xml.GetElementsByTagName("name")[0].InnerText;
           phone.Text=  xml.GetElementsByTagName("phone")[0].InnerText;
            address.Text= xml.GetElementsByTagName("address")[0].InnerText;
            email.Text=xml.GetElementsByTagName("email")[0].InnerText;  
            
            
           
        }
    }
}
