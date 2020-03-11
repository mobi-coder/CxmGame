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
    public partial class Razrab : Form
    {
        public Razrab()
        {
            InitializeComponent();
        }

        private void Razrab_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Razrab". При необходимости она может быть перемещена или удалена.
            this.razrabTableAdapter.Fill(this.computerGamesDataSet.Razrab);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
