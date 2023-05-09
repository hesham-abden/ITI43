using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;

namespace XML
{
    public partial class Form1 : Form
    {
        int _count=0;
        int _emp_number;
        XmlDocument xml = new XmlDocument();
        public Form1()
        {
            InitializeComponent();

            xml.Load(@"C:\Users\Dell\Desktop\Untitled1.xml");
            name.Text = xml.GetElementsByTagName("name")[0].InnerText;
           phone.Text=  xml.GetElementsByTagName("phone")[0].InnerText;
            XmlNodeList add = xml.GetElementsByTagName("addresses")[0].ChildNodes;
            street.Text = add.Item(0).ChildNodes[0].InnerText;
            building.Text = add.Item(0).ChildNodes[1].InnerText;
            city.Text = add.Item(0).ChildNodes[4].InnerText;
            country.Text = add.Item(0).ChildNodes[5].InnerText;
            email.Text=xml.GetElementsByTagName("email")[0].InnerText;
            _emp_number = xml.GetElementsByTagName("employee").Count;
            
            if (_count == 0) { prev.Enabled = false; }
        }

        private void save_Click(object sender, EventArgs e)
        {
            xml.Save(@"C:\Users\Dell\Desktop\Untitled1.xml");
        }

        private void next_Click(object sender, EventArgs e)
        {
            if (_count < _emp_number - 1)
            {
                Update(++_count);
            }
        }
        

        private void prev_Click(object sender, EventArgs e)
        {
            if(_count>0)
            {
                Update(--_count);
            }
            
        }

        public void Update(int count)
        {



            if (count >= 0 && count < _emp_number)
            {
                next.Enabled = true;
                prev.Enabled = true;
                name.Text = xml.GetElementsByTagName("name")[count].InnerText;
                phone.Text = xml.GetElementsByTagName("phone")[count].InnerText;
                email.Text = xml.GetElementsByTagName("email")[count].InnerText;
                XmlNodeList add = xml.GetElementsByTagName("addresses")[count].ChildNodes;
                street.Text = add.Item(0).ChildNodes[0].InnerText;
                building.Text = add.Item(0).ChildNodes[1].InnerText;
                city.Text = add.Item(0).ChildNodes[4].InnerText;
                country.Text = add.Item(0).ChildNodes[5].InnerText;
            }

            if (_count >= _emp_number - 1) { next.Enabled = false; }
            if (_count == 0)
            {
                prev.Enabled = false;


            }
        }
            

        private void update_Click(object sender, EventArgs e)
        {
            xml.GetElementsByTagName("name")[_count].InnerText = name.Text;
            xml.GetElementsByTagName("phone")[_count].InnerText=phone.Text;
            XmlNodeList add = xml.GetElementsByTagName("addresses")[_count].ChildNodes;
            add.Item(0).ChildNodes[0].InnerText = street.Text;
            add.Item(0).ChildNodes[1].InnerText = building.Text;
            add.Item(0).ChildNodes[4].InnerText = city.Text;
            add.Item(0).ChildNodes[5].InnerText = country.Text;
            xml.GetElementsByTagName("email")[_count].InnerText = email.Text;
        }

        private void insert_Click(object sender, EventArgs e)
        {
            XmlNode temp = xml.GetElementsByTagName("employee")[0].Clone();
            temp.ChildNodes[0].InnerText = name.Text;
            XmlNodeList phones = temp.ChildNodes[1].ChildNodes;
            phones.Item(0).InnerText = phone.Text;
            XmlNodeList add = temp.ChildNodes[2].ChildNodes;
            add.Item(0).ChildNodes[0].InnerText = street.Text;
            add.Item(0).ChildNodes[1].InnerText = building.Text;
            add.Item(0).ChildNodes[4].InnerText = city.Text;
            add.Item(0).ChildNodes[5].InnerText = country.Text;
            temp.ChildNodes[3].InnerText = email.Text;
            xml.GetElementsByTagName("employees")[0].AppendChild(temp);
            _emp_number = xml.GetElementsByTagName("employee").Count;
            Update(0);
            _count = 0;
        }

        private void search_Click(object sender, EventArgs e)
        {
            string temp_name=name.Text;
            Boolean condition = false;
            XmlNodeList temp = xml.GetElementsByTagName("name");

            foreach (XmlNode item in temp)
            {


                if (item.InnerText == temp_name)
                {
                    condition = true;
                }   
            }
            if(condition)
            {
                MessageBox.Show("Found !");
            }
            else
            {
                MessageBox.Show("Not Found !");
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {

            xml.GetElementsByTagName("employees")[0].RemoveChild(xml.GetElementsByTagName("employees").Item(0).ChildNodes[_count]);
            _emp_number = xml.GetElementsByTagName("employee").Count;
            _count = 0;
            Update(0);
            

        }
    }
}
