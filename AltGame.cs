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
    public partial class AltGame : Form
    {
        public AltGame()
        {
            InitializeComponent();
        }

        private void AltGame_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Igra". При необходимости она может быть перемещена или удалена.
            this.igraTableAdapter.Fill(this.computerGamesDataSet.Igra);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Game spr = new Game();
            spr.Show();
            this.Close();
        }
    }
}
