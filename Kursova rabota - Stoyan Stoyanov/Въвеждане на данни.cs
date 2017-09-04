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
    public partial class Data : Form
    {
        public Data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox3.Text != "" && textBox4.Text != "")
            {
                FileStream f = new FileStream("Danni.dat", FileMode.OpenOrCreate);
                BinaryWriter bw = new BinaryWriter(f);

                int number = int.Parse(textBox1.Text);
                string name = textBox2.Text;
                int mobOperator = comboBox1.SelectedIndex;
                int tax = comboBox2.SelectedIndex;
                double price = double.Parse(textBox3.Text);
                int minutes = int.Parse(textBox4.Text);
                f.Seek(0, SeekOrigin.End);

                bw.Write(number);
                bw.Write(name);
                bw.Write(mobOperator);
                bw.Write(tax);
                bw.Write(price);
                bw.Write(minutes);
                MessageBox.Show("Данните са записани!");
                
                f.Close();
                Close();

            }
            else MessageBox.Show("Въведете всички данни!");
        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Сигурни ли сте ?", "Излизане", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Close();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }
    }
}
