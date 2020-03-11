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
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void Игры_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Igra". При необходимости она может быть перемещена или удалена.
            this.igraTableAdapter.Fill(this.computerGamesDataSet.Igra);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltGame spr = new AltGame();
            spr.Show();
            this.Hide();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC spr = new AC();
            spr.Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CV spr = new CV();
            spr.Show();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC2 spr = new AC2();
            spr.Show();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS spr = new DS();
            spr.Show();
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ACb spr = new ACb();
            spr.Show();
        }

        private void linkLabel6_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS2 spr = new DS2();
            spr.Show();
        }

        private void linkLabel7_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ACr spr = new ACr();
            spr.Show();
        }

        private void linkLabel8_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS3 spr = new DS3();
            spr.Show();
        }

        private void linkLabel9_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC3 spr = new AC3();
            spr.Show();
        }

        private void linkLabel10_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            D2 spr = new D2();
            spr.Show();
        }

        private void linkLabel11_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MLL spr = new MLL();
            spr.Show();
        }

        private void linkLabel12_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            M2 spr = new M2();
            spr.Show();
        }

        private void linkLabel13_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DO spr = new DO();
            spr.Show();
        }

        private void linkLabel14_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DO3 spr = new DO3();
            spr.Show();
        }

        private void linkLabel15_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            D3 spr = new D3();
            spr.Show();
        }

        private void linkLabel16_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ROE spr = new ROE();
            spr.Show();
        }

        private void linkLabel17_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NA spr = new NA();
            spr.Show();
        }

        private void linkLabel18_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MKII spr = new MKII();
            spr.Show();
        }

        private void linkLabel19_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MKX spr = new MKX();
            spr.Show();
        }

        private void linkLabel20_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ME spr = new ME();
            spr.Show();
        }

        private void linkLabel21_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC3 spr = new AC3();
            spr.Show();
        }

        private void linkLabel37_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ACr spr = new ACr();
            spr.Show();
        }

        private void linkLabel30_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ACb spr = new ACb();
            spr.Show();
        }

        private void linkLabel26_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC2 spr = new AC2();
            spr.Show();
        }

        private void linkLabel24_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AC spr = new AC();
            spr.Show();
        }

        private void linkLabel25_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CV spr = new CV();
            spr.Show();
        }

        private void linkLabel32_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS spr = new DS();
            spr.Show();
        }

        private void linkLabel38_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS2 spr = new DS2();
            spr.Show();
        }

        private void linkLabel45_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DS3 spr = new DS3();
            spr.Show();
        }

        private void linkLabel39_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            NA spr = new NA();
            spr.Show();
        }

        private void linkLabel46_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            D2 spr = new D2();
            spr.Show();
        }

        private void linkLabel23_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            D3 spr = new D3();
            spr.Show();
        }

        private void linkLabel31_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DO3 spr = new DO3();
            spr.Show();
        }

        private void linkLabel34_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DO spr = new DO();
            spr.Show();
        }

        private void linkLabel36_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            M2 spr = new M2();
            spr.Show();
        }

        private void linkLabel42_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MLL spr = new MLL();
            spr.Show();
        }

        private void linkLabel47_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ME spr = new ME();
            spr.Show();
        }

        private void linkLabel41_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ROE spr = new ROE();
            spr.Show();
        }

        private void linkLabel57_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MKX spr = new MKX();
            spr.Show();
        }

        private void linkLabel56_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MKII spr = new MKII();
            spr.Show();
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e) //All
        {
            if(radioButton6.Checked == true)
            {
                panel1.Visible = true;
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e) // Action, Stealth
        {
            if (radioButton1.Checked == true)
            {
                panel2.Visible = true;
            }
            else
            {
                panel2.Visible = false;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e) // Action, Role-Playing 
        {
            if (radioButton2.Checked == true)
            {
                panel3.Visible = true;
            }
            else
            {
                panel3.Visible = false;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e) // Action/RPG 
        {
            if (radioButton3.Checked == true)
            {
                panel4.Visible = true;
            }
            else
            {
                panel4.Visible = false;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e) // Action 
        {
            if (radioButton4.Checked == true)
            {
                panel5.Visible = true;
            }
            else
            {
                panel5.Visible = false;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e) // Action, Fighting 
        {
            if (radioButton5.Checked == true)
            {
                panel6.Visible = true;
            }
            else
            {
                panel6.Visible = false;
            }
        }
  
    }        
}
