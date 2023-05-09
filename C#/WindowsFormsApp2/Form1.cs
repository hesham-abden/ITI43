using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        TcpClient client;
        NetworkStream stream;
        public Form1()
        {
            InitializeComponent();
            client = new TcpClient();
            client.Connect("127.0.0.1", 4574);

            stream = client.GetStream();

            // Create a buffer to read the data

        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] buffer = new byte[1024];

            // Read the data from the stream into the buffer
            int bytes = stream.Read(buffer, 0, buffer.Length);

            // Deserialize the received data into an object
            BinaryFormatter formatter = new BinaryFormatter();
            MemoryStream memoryStream = new MemoryStream(buffer);
            object receivedObject = formatter.Deserialize(memoryStream);

            // Cast the object to the expected type
            Person person = (Person)receivedObject;
            MessageBox.Show(person.Name);
            MessageBox.Show(person.Age.ToString());

            stream.Close();
            client.Close();
        }
    }

    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}



