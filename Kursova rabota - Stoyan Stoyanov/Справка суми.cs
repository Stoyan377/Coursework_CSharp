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
    public partial class SpravkaSumi : Form
    {
        public SpravkaSumi()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };






            FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f.Position < f.Length)
            {

                int number = br.ReadInt32();
                string name = br.ReadString();
                int o = br.ReadInt32();
                int t = br.ReadInt32();
                double price = br.ReadDouble();
                int minutes = br.ReadInt32();
                double sum = (price * minutes) + tax[t];
                if (o == op)
                {

                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    label2.Text = "Обща сума за плащане:  " + sum1.ToString() + " лв.";
                }
            }
            f.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };






            FileStream f1 = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br1 = new BinaryReader(f1);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f1.Position < f1.Length)
            {

                int number = br1.ReadInt32();
                string name = br1.ReadString();
                int o = br1.ReadInt32();
                int t = br1.ReadInt32();
                double price = br1.ReadDouble();
                int minutes = br1.ReadInt32();
                double sum = (price * minutes) + tax[t];
                if (o == op)
                {

                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        StreamWriter File = new StreamWriter("Mtel.txt");
                        File.WriteLine("Приходи за Mtel:                                  " + sum1 + " лв.");
                        File.Close();
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };

            FileStream f2 = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br2 = new BinaryReader(f2);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f2.Position < f2.Length)
            {

                int number = br2.ReadInt32();
                string name = br2.ReadString();
                int o = br2.ReadInt32();
                int t = br2.ReadInt32();
                double price = br2.ReadDouble();
                int minutes = br2.ReadInt32();
                double sum = (price * minutes) + tax[t];
                if (o == op)
                {

                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        StreamWriter File = new StreamWriter("Telenor.txt");
                        File.WriteLine("Приходи за Telenor:                               " + sum1 + " лв.");
                        File.Close();
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };

            FileStream f3 = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br3 = new BinaryReader(f3);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f3.Position < f3.Length)
            {

                int number = br3.ReadInt32();
                string name = br3.ReadString();
                int o = br3.ReadInt32();
                int t = br3.ReadInt32();
                double price = br3.ReadDouble();
                int minutes = br3.ReadInt32();
                double sum = (price * minutes) + tax[t];
                if (o == op)
                {

                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        StreamWriter File = new StreamWriter("Vivacom.txt");
                        File.WriteLine("Приходи за Vivacom:                               " + sum1 + " лв.");
                        File.Close();
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };






            FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f.Position < f.Length)
            {

                int number = br.ReadInt32();
                string name = br.ReadString();
                int o = br.ReadInt32();
                int t = br.ReadInt32();
                double price = br.ReadDouble();
                int minutes = br.ReadInt32();
                double sum = (price * minutes) + tax[t];
                {
                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
                    label2.Text = "Обща сума за плащане:  " + sum1.ToString() + " лв.";
                }
            }
            f.Close();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            int op = comboBox1.SelectedIndex;
            int[] tax = { 5, 7, 10, 12 };
            string[] operatori = { "Mtel", "Telenor", "Vivacom" };






            FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(f);

            int n = 0;
            dataGridView1.Rows.Clear();
            while (f.Position < f.Length)
            {

                int number = br.ReadInt32();
                string name = br.ReadString();
                int o = br.ReadInt32();
                int t = br.ReadInt32();
                double price = br.ReadDouble();
                int minutes = br.ReadInt32();
                double sum = (price * minutes) + tax[t];
                {
                    dataGridView1.Rows.Add(++n, name, tax[t], price.ToString() + " лв. ", minutes, sum);
                    double sum1 = 0;
                    for (int i = 0; i < dataGridView1.Rows.Count; ++i)
                    {
                        StreamWriter File = new StreamWriter("All.txt");
                        File.WriteLine("Общи приходи за трите оператора:                  " + sum1 + " лв.");
                        File.Close();
                        sum1 += Convert.ToDouble(dataGridView1.Rows[i].Cells[5].Value);
                    }
  
                }
            }
            f.Close();
        }
    }
    }

                        


            
