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
    public partial class MostMinutes : Form
    {
        public MostMinutes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string[] mobOperator = { "Mtel", "Telenor", "Vivacom" };
            string[] tax = { "5", "7", "10", "12" };

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

                    dataGridView1.Rows.Add(++n, name, minutes);
                    dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Descending);
                    
                }
            }
            else MessageBox.Show("Файл Danni.dat не съществува");
        }

        private void button3_Click(object sender, EventArgs e)
        {

            {
                FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(f);
                dataGridView1.Rows.Clear();
                int n = 0;
                string nula = "0";
                int[] mas = new int[5];
                while (f.Position < f.Length)
                {
                    string number = nula + br.ReadInt32();
                    string name = br.ReadString();
                    int o = br.ReadInt32();
                    int t = br.ReadInt32();
                    double price = br.ReadDouble();
                    int minutes = br.ReadInt32();

                    dataGridView1.Rows.Add(++n, name, minutes);
                    dataGridView1.Sort(this.dataGridView1.Columns[2], ListSortDirection.Descending);
                    dataGridView1.MaximumSize = new System.Drawing.Size(614, 145);
                    dataGridView1.ScrollBars = ScrollBars.None;




                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);
            this.dataGridView1.Rows.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
