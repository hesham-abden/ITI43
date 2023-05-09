using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;


namespace ChatClient
{
    public partial class Form1 : Form
    {
        static int port = 9999;
        static IPAddress address = IPAddress.Parse("127.0.0.1");
        NetworkStream stream;
        BinaryReader bRead;
        BinaryWriter bWrite;
        string m;



        TcpClient tcpClient = new TcpClient();

        public Form1()
        {
            InitializeComponent();
            richTextBox1.Text = "";
            Thread reading = new Thread(() =>
            {
                while (false)
                {
                    if (stream != null)
                    {
                        bRead = new BinaryReader(stream);
                        m = bRead.ReadString();

                        Invoke(new Action(() =>
                        {
                            richTextBox1.AppendText("Server :" + m + "\n");
                        }));


                        stream.Flush();

                    }
                }
            });
            reading.Start();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                tcpClient.Connect(address, port);
                stream = tcpClient.GetStream();


            }
            catch (Exception er)
            {

                MessageBox.Show("The Server is not established");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Class1 obj = new Class1();
            obj = (Class1)binaryFormatter.Deserialize(stream);
            MessageBox.Show(obj.Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bWrite = new BinaryWriter(stream);
            bWrite.Write(textBox1.Text);
            richTextBox1.AppendText("Client :" + textBox1.Text + "\n");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            bWrite.Close();
            bRead.Close();
            stream.Close();
            tcpClient.Close();

        }

    }
}
