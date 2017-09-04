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
    public partial class MoreThanOneRecord : Form
    {
        public MoreThanOneRecord()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (File.Exists("Danni.dat"))
            {
                FileStream f = new FileStream("Danni.dat", FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(f);
                string[] name1 = new string[500];
                int b = 0;
                string nula = "0";
                while (f.Position < f.Length)
                {
                    string number = nula + br.ReadInt32();
                    string name = br.ReadString();
                    int o = br.ReadInt32();
                    int t = br.ReadInt32();
                    double price = br.ReadDouble();
                    int minutes = br.ReadInt32();
                    name1[b++] = name;

                    for (int i = 0; i < b; i++)
                    {
                        int k = 0;
                        for (int z = i + 1; z < b; z++)
                        {
                            if (name1[i] == name1[z])
                            {
                                k++;
                            }
                            if (listBox1.Items.Contains(name1[i]))
                            {
                                k = 0;
                            }
                        }
                        if (k > 0)
                        {
                            listBox1.Items.Add(name1[i]);
                        }
                        label1.Text = "Хора с по няколко записа: " + listBox1.Items.Count.ToString();
                    }
                }
            }
        }
               


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
        }
 
        