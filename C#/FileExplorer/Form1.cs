using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileExplorer
{
    public partial class Form1 : Form
    {
        DirectoryInfo CurrentDirectory1;
        string[] drives = Directory.GetLogicalDrives();
        DirectoryInfo CurrentDirectory2;

        public Form1()
        {
            InitializeComponent();

            
            foreach (var item in drives)
            {
                listBox1.Items.Add(item);
                listBox2.Items.Add(item);
               
            }
            
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var SelectedList = sender as ListBox;

            string Fullpath = "";
            string tempPath = "";
            DirectoryInfo CurrentDirectory=CurrentDirectory1;
            if(SelectedList.SelectedItem != null)
            { 
            if(SelectedList==listBox2)
            {
                CurrentDirectory = CurrentDirectory2;
            }

            if (CurrentDirectory == null)     //First Partitions
            {
                Fullpath = SelectedList.SelectedItem.ToString();
            }
            else
            {
                tempPath = Path.Combine(CurrentDirectory.FullName, SelectedList.SelectedItem.ToString());
                if (CurrentDirectory != null && File.GetAttributes(tempPath).HasFlag(FileAttributes.Directory))
                {


                    Fullpath = Path.Combine(CurrentDirectory.FullName, SelectedList.SelectedItem.ToString());

                }
                else
                {
                    Fullpath = CurrentDirectory.FullName;
                    MessageBox.Show("Selected Path :" + Fullpath + " is a file");
                    //Process.Start(tempPath);
                }
                CurrentDirectory = new DirectoryInfo(Fullpath);
            }


                if (SelectedList.SelectedItem != null)  //Clicking on Item list
                {

                    if (SelectedList.SelectedItem.ToString() == ".")   //Parent Folder
                    {
                        if (CurrentDirectory.Parent != null)
                        {
                            CurrentDirectory = CurrentDirectory.Parent;
                            UpdateList(CurrentDirectory, SelectedList);


                        }
                        else
                        {
                            CurrentDirectory = null;
                            UpdateList(drives, SelectedList);

                        }
                    }
                    else if (SelectedList.SelectedItem.ToString() == "..")   //Root Drive
                    {
                        CurrentDirectory = CurrentDirectory.Root;
                        UpdateList(CurrentDirectory, SelectedList);
                    }
                    else   //Normal Item
                    {
                        if (File.GetAttributes(Fullpath).HasFlag(FileAttributes.Directory))
                        {

                            CurrentDirectory = new DirectoryInfo(Fullpath);
                            UpdateList(CurrentDirectory, SelectedList);
                        }

                    }
                    if (SelectedList == listBox1)
                    {
                        CurrentDirectory1 = CurrentDirectory;
                        if (CurrentDirectory1 != null)
                        {

                            textBox1.Text = CurrentDirectory1.FullName;
                        }
                    }
                    else
                    {
                        CurrentDirectory2 = CurrentDirectory;
                        if (CurrentDirectory2 != null)
                        {
                            textBox2.Text = CurrentDirectory2.FullName;
                        }
                    }
                }

                    
                
               

            }
        }

        

        private void button5_Click(object sender, EventArgs e)
        {
            if(CurrentDirectory1!=null&&
                CurrentDirectory1.Parent!=null&&
                listBox1.SelectedItem != null)
            {
                CurrentDirectory1 = CurrentDirectory1.Parent;
                UpdateList(CurrentDirectory1, listBox1);
            }
            if (CurrentDirectory2 != null &&
                CurrentDirectory2.Parent != null &&
                listBox2.SelectedItem != null)
            {
                CurrentDirectory2 = CurrentDirectory2.Parent;
                UpdateList(CurrentDirectory2, listBox2);
            }

        }
        public void UpdateList(DirectoryInfo destination,ListBox SelectedList)
        {
            DirectoryInfo[] dires = destination.GetDirectories();
            FileInfo[] files = destination.GetFiles();

            SelectedList.Items.Clear();
            foreach (var item in dires)
            {
                SelectedList.Items.Add(item);
            }
            foreach (var item in files)
            {
                SelectedList.Items.Add(item);
            }
            if (CurrentDirectory1 != null)
            {

                textBox1.Text = CurrentDirectory1.FullName;
            }
            if (CurrentDirectory2 != null)
            {

                textBox2.Text = CurrentDirectory2.FullName;
            }
            SelectedList.Items.Add(".");
            SelectedList.Items.Add("..");
            
        }
        public void UpdateList(string[] destination, ListBox SelectedList)
        {
            

            SelectedList.Items.Clear();
            
            foreach (var item in destination)
            {
                SelectedList.Items.Add(item);
            }
            if (CurrentDirectory1 != null)
            {

                textBox1.Text = CurrentDirectory1.FullName;
            }
            if (CurrentDirectory2 != null)
            {

                textBox2.Text = CurrentDirectory2.FullName;
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            
            
            if (listBox1.SelectedItem != null
                && CurrentDirectory2!=null 
                &&CurrentDirectory1!=null
                && File.GetAttributes(CurrentDirectory1.FullName).HasFlag(FileAttributes.Directory))   
            {
                try
                {
                  string  path1 = Path.Combine(CurrentDirectory1.FullName, listBox1.SelectedItem.ToString());
                  string  path2 = Path.Combine(CurrentDirectory2.FullName, listBox1.SelectedItem.ToString());
                    File.Copy(path1, path2);
                    UpdateList(CurrentDirectory2, listBox2);
                    UpdateList(CurrentDirectory1, listBox1);
                }
                catch(System.IO.IOException)
                {
                    MessageBox.Show("The file already exists");
                }
                
            }
            else
            {
                MessageBox.Show("The selected item is not compatible");
            }
            

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (CurrentDirectory1 != null &&
                CurrentDirectory1.Parent != null &&
                listBox1.SelectedItem != null&&
                File.GetAttributes(CurrentDirectory1.FullName).HasFlag(FileAttributes.Directory))
            {

                string path1 = Path.Combine(CurrentDirectory1.FullName, listBox1.SelectedItem.ToString());
                File.Delete(path1);
                UpdateList(CurrentDirectory1, listBox1);
            }
            if (CurrentDirectory2 != null &&
                CurrentDirectory2.Parent != null &&
                listBox2.SelectedItem != null &&
                File.GetAttributes(CurrentDirectory2.FullName).HasFlag(FileAttributes.Directory))
            {

                string path2 = Path.Combine(CurrentDirectory2.FullName, listBox2.SelectedItem.ToString());
                File.Delete(path2);
                UpdateList(CurrentDirectory2, listBox2);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (CurrentDirectory1 != null &&
                listBox1.SelectedItem != null&&
                CurrentDirectory2 != null
                
                )
            {
                
                string path1 = Path.Combine(CurrentDirectory1.FullName, listBox1.SelectedItem.ToString());
                
                
                if (File.GetAttributes(path1).HasFlag(FileAttributes.Directory))
                {
                    string path2 = Path.Combine(CurrentDirectory2.FullName,listBox1.SelectedItem.ToString());
                    try
                    {
                        Directory.Move(path1, path2);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The folder name already exists");
                    }
                    
                    
                }
                else 
                {
                    string path2 = Path.Combine(CurrentDirectory2.FullName, listBox1.SelectedItem.ToString());
                    try
                    {
                        File.Move(path1, path2);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The file name already exists");
                    }
                    
                }
                UpdateList(CurrentDirectory1,listBox1);
                UpdateList(CurrentDirectory2, listBox2);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (CurrentDirectory2 != null &&
                listBox2.SelectedItem != null &&
                CurrentDirectory1 != null

                )
            {

                string path1 = Path.Combine(CurrentDirectory2.FullName, listBox2.SelectedItem.ToString());

                
                if (File.GetAttributes(path1).HasFlag(FileAttributes.Directory))
                {
                    string path2 = Path.Combine(CurrentDirectory1.FullName, listBox2.SelectedItem.ToString());

                    try
                    {
                        Directory.Move(path1, path2);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The folder name already exists");
                    }

                }
                else 
                {
                    string path2 = Path.Combine(CurrentDirectory1.FullName, listBox2.SelectedItem.ToString());
                    try
                    {
                        File.Move(path1, path2);
                    }
                    catch (Exception)
                    {

                        MessageBox.Show("The file name already exists");
                    }
                    
                }
                UpdateList(CurrentDirectory1, listBox1);
                UpdateList(CurrentDirectory2, listBox2);

            }
        }
    }
   
}
