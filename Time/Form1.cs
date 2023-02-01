using System;

namespace Time
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current time is: " + DateTime.Now.ToString("h:mm tt"));
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("The current time is: " + DateTime.Now.ToString("HH:mm"));
        }
    }
}