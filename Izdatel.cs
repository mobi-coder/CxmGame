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
    public partial class Izdatel : Form
    {
        public Izdatel()
        {
            InitializeComponent();
        }

        private void Izdatel_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Izdatel". При необходимости она может быть перемещена или удалена.
            this.izdatelTableAdapter.Fill(this.computerGamesDataSet.Izdatel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "computerGamesDataSet.Izdatel". При необходимости она может быть перемещена или удалена.
            this.izdatelTableAdapter.Fill(this.computerGamesDataSet.Izdatel);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
