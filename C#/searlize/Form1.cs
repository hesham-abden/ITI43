using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace searlize
{

    public partial class Form1 : Form
    {
        NetworkStream stream;
        TcpListener client;
        public Form1()
        {
            InitializeComponent();

            client = new TcpListener(IPAddress.Parse("127.0.0.1"), 4574);
            stream = client.AcceptTcpClient().GetStream();




            // Create the object to send

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = "John Doe";
            person.Age = 30;

            // Serialize the object and send it
            BinaryFormatter formatter = new BinaryFormatter();
            formatter.Serialize(stream, person);
            stream.Flush();

            stream.Close();


        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}



