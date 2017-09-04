using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kursova_rabota___Stoyan_Stoyanov
{
    public partial class Начало : Form
    {
        public Начало()
        {
            InitializeComponent();
        }

        private void началоToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Начало().Show();
        }

        private void въвежданеНаДанниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Data().Show();
        }

        private void извежданеНаВсичкиДанниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowAllData().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Data().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new ShowAllData().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new SpravkaSumi().Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            new NumberOfClients().Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new MostMinutes().Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new MobileOperatorsRevenue().Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте ?", "Излизане", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте ?", "Излизане", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            new MoreThanOneRecord().Show();
        }

        private void таксиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SpravkaSumi().Show();
        }

        private void бройКлиентиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NumberOfClients().Show();
        }

        private void найдългиРазговориToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MostMinutes().Show();
        }

        private void приходиНаОператорToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MobileOperatorsRevenue().Show();
        }

        private void няколкоВъведениДанниToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new MoreThanOneRecord().Show();
        }
    }
}
