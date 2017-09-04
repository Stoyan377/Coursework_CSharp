using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Kursova_rabota___Stoyan_Stoyanov
{
    public partial class NumberOfClients : Form
    {
        public NumberOfClients()
        {
            InitializeComponent();
        }



        private void Покажи_Click(object sender, EventArgs e)
        {
            string[] mobOperator = { "Mtel", "Telenor", "Vivacom" };
            int[] tax = { 5, 7, 10, 12 };

            if (File.Exists("Danni.dat"))
            {
                FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(f);
                dataGridView1.Rows.Clear();
                int n = 0;
                string nula = "0";



                while (f.Position < f.Length)
                {
                    string number = nula + br.ReadInt32();
                    string name = br.ReadString();
                    int o = br.ReadInt32();
                    int t = br.ReadInt32();
                    double price = br.ReadDouble();
                    int minutes = br.ReadInt32();


                    dataGridView1.EndEdit();
                    this.dataGridView1.Sort(this.dataGridView1.Columns[4], ListSortDirection.Descending);

                    dataGridView1.Rows.Add(++n, number, name, mobOperator[o], tax[t]);
                    label2.Text = "Общ брой клиенти: " + dataGridView1.Rows.Count.ToString();
                    dataGridView1.Refresh();
                    dataGridView1.NotifyCurrentCellDirty(true);


                }
                f.Close();
            }
            else MessageBox.Show("Файл Danni.dat не съществува");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gr = comboBox1.SelectedIndex;
            int[] tax1 = { 5, 7, 10, 12 };
            string[] mobOperator = { "Mtel", "Telenor", "Vivacom" };

            FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);
            dataGridView1.Rows.Clear();
            int n = 0;
            string nula = "0";



            while (f.Position < f.Length)
            {
                string number = nula + br.ReadInt32();
                string name = br.ReadString();
                int o = br.ReadInt32();
                int t = br.ReadInt32();
                double price = br.ReadDouble();
                int minutes = br.ReadInt32();
                if(t == gr)
                {
                    dataGridView1.Rows.Add(++n, number, name, mobOperator[o], tax1[t]);
                    label2.Text = "Брой клиенти според месечната такса: " + dataGridView1.Rows.Count.ToString();
                }

            }
        }

        private void Изход_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

