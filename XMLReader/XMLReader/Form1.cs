using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace XMLReader
{
    public partial class Form1 : Form
    {
        FileStream fs;
        BinaryFormatter bfor;
        //XmlSerializer xml;
        string fname = @"C:\Users\test.PRAGMASYSLLP\Documents\Visual Studio 2015\Projects\TextFiles\xMLRead2.bin";
        //string fname = @"C:\Users\test.PRAGMASYSLLP\Documents\Visual Studio 2015\Projects\TextFiles\xMLRead.xml";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee obj = new Employee();
            obj.empID = Convert.ToInt32(textBox1.Text);
            obj.empName = textBox2.Text;
            obj.salary = textBox3.Text;

            fs = new FileStream(fname, FileMode.Append, FileAccess.Write);
           // xml = new XmlSerializer(typeof(Employee));
            //xml.Serialize(fs, obj);
            bfor = new BinaryFormatter();
            bfor.Serialize(fs, obj);
            fs.Close();
            MessageBox.Show("Uploaded");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fs = new FileStream(fname, FileMode.Open, FileAccess.Read);
            bfor = new BinaryFormatter();
            //xml = new XmlSerializer(typeof(Employee));
            while (fs.Position!=fs.Length)
            {
                Employee st = (Employee)bfor.Deserialize(fs);
               // Employee st = (Employee)xml.Deserialize(fs);
                richTextBox1.AppendText(st.ToString());
            }
            fs.Close();
        }
    }
}
