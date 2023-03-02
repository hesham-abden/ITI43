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
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testing_server
{
    public partial class Server : Form
    {
        IPAddress ip = IPAddress.Parse("127.0.0.1");
        TcpListener server;
        TcpClient client;
        StreamReader sr;
        StreamWriter sw;
        StreamReader cs;
        StreamWriter cw;
        Socket socket;
        NetworkStream stream;

        public Server()
        {
            InitializeComponent();
            server = new TcpListener(ip, 5454);
            client = new TcpClient();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            server.Start();

            //backgroundWorker2.RunWorkerAsync();
            //socket = server.AcceptSocket();
            //stream = new NetworkStream(socket);
            //sr = new StreamReader(stream);
            //sw = new StreamWriter(stream);
            //sw.AutoFlush = true;
            //backgroundWorker1.RunWorkerAsync();
            //richTextBox1.AppendText("sucess");
            Thread thread = new Thread(() =>
            {
                socket = server.AcceptSocket();
                stream = new NetworkStream(socket);
                sr = new StreamReader(stream);
                sw = new StreamWriter(stream);
                sw.AutoFlush = true;
                //backgroundWorker1.RunWorkerAsync();
                
                MessageBox.Show("HEHE");
            });
            thread.Start();
            if(client.Connected)
            {
                richTextBox1.AppendText("sucess");
            }    

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                client.Connect(ip, 5454);
                cs = new StreamReader(client.GetStream());
                cw = new StreamWriter(client.GetStream());
                cw.AutoFlush = true;
                backgroundWorker1.RunWorkerAsync();
                richTextBox2.AppendText("sucess");
            }
            catch (Exception)
            {
                richTextBox2.AppendText("fail");

            }
            
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
           
            
                while (client.Connected)
                {
                    string msg = cs.ReadLine();
                    Invoke(new Action(() =>
                    {
                        richTextBox1.AppendText(msg);
                    }));

                }
            
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            sw.WriteLine("SENDING FROM CLIENT");
        }

        private void backgroundWorker2_DoWork(object sender, DoWorkEventArgs e)
        {

            
                
               
                
                    socket = server.AcceptSocket();
                    stream=new NetworkStream(socket);
                    sr = new StreamReader(stream);
                    sw = new StreamWriter(stream);
                    sw.AutoFlush = true;
                    backgroundWorker1.RunWorkerAsync();
                    richTextBox1.AppendText("sucess");
                    MessageBox.Show("HEHE");
                
            
         
                
            
        }
    }
}
