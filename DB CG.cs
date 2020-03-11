using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerGames
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game spr = new Game();
            spr.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Janr spr = new Janr();
            spr.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Razrab spr = new Razrab();
            spr.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Izdatel spr = new Izdatel();
            spr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
