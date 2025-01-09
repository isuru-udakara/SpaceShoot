using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SpaceShoot
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonPlay_Click(object sender, EventArgs e)
        {
            Form1 gameForm = new Form1();
            gameForm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 gameForm = new Form3();
            gameForm.Show();
            this.Hide();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(1);
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Station st = new Station(); 
            st.Show(); 
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Station st = new Station();
            st.Show();
            this.Hide();
        }
    }
}
