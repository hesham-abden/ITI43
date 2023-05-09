using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.IO;
using System.Threading;
using System.Runtime.Serialization.Formatters.Binary;

namespace ChatServer
{

    public partial class Form1 : Form
    {
        static int port = 9999;
        static IPAddress address = IPAddress.Parse("127.0.0.1");
        Socket socket;
        TcpListener server = new TcpListener(address, port);
        NetworkStream stream;
        BinaryWriter bWrite;
        BinaryReader bRead;
        [ThreadStatic]
        string m;
        string n;
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
                            richTextBox1.AppendText("Client :" + m + "\n");
                        }));


                        stream.Flush();

                    }
                }
            });
            reading.Start();


        }

        protected override void OnPaint(PaintEventArgs e)
        {
            //write(m);
        }
        private void button2_Click(object sender, EventArgs e)
        {

            server.Start();
            //Thread thread = new Thread(() =>
            //{   
            //    socket = server.AcceptSocket();
            //    stream = new NetworkStream(socket);
            //});
            //thread.Start();
            backgroundWorker1.RunWorkerAsync();



        }

        private void button4_Click(object sender, EventArgs e)
        {

            server.Stop();
            if (stream != null)
            {
                stream.Close();
                socket.Shutdown(SocketShutdown.Both);
                socket.Close();
            }


        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            Class1 obj = new Class1();
            obj.Name = "hello";
            binaryFormatter.Serialize(stream, obj);
            stream.Flush();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (socket != null)
            {
                bWrite = new BinaryWriter(stream);
                bWrite.Write(textBox1.Text);
                richTextBox1.AppendText("Server :" + textBox1.Text + "\n");
            }

        }
        public void write(string m)
        {
            if (m != n)
                richTextBox1.AppendText("Client :" + m + "\n");
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                socket = server.AcceptSocket();
                stream = new NetworkStream(socket);
                if (socket != null) { break; }
            }
        }
    }
}
