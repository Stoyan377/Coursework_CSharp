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
    public partial class MobileOperatorsRevenue : Form
    {
        public MobileOperatorsRevenue()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.AddRange(System.IO.File.ReadAllLines(@"Mtel.txt"));
            listBox1.Items.Add("*****************************************************************");
            listBox1.Items.AddRange(System.IO.File.ReadAllLines(@"Telenor.txt"));
            listBox1.Items.Add("*****************************************************************");
            listBox1.Items.AddRange(System.IO.File.ReadAllLines(@"Vivacom.txt"));
            listBox1.Items.Add("*****************************************************************");
            listBox1.Items.AddRange(System.IO.File.ReadAllLines(@"All.txt"));
            listBox1.Items.Add("*****************************************************************");
            DateTime Today = DateTime.Now;
            listBox1.Items.Add(Today);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }


    }
    



