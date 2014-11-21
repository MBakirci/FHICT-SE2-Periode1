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

namespace _9._2Exist
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            string filePath = @"c:\test.txt";
            if(File.Exists(filePath))
            {
                MessageBox.Show("Bestand test.txt gevonden");
                label1.Text = filePath;
            }
            else
            {

                MessageBox.Show("Bestand test.txt niet gevonden");
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string filePath = @"c:\test.txt";
            File.Delete(filePath);
            MessageBox.Show("Bestand verwijderd :)");
        }
    }
}
