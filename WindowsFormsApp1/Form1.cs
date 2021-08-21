using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Modeo;
using Modeo.Request;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Person person = new Person();
            PersonRequest personRequest = new PersonRequest();
            PersonResponse personResponse = new PersonResponse();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola " + txtName.Text + ", cómo estás?");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Mi primer evento");
        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            MessageBox.Show("Double Click");
        }
    }
}
