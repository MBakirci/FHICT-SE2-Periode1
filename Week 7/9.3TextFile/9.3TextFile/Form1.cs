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

namespace _9._3TextFile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog loadaccounts = new OpenFileDialog();
            loadaccounts.Filter = "Text Files (*.txt)|*.txt";
            DialogResult dr = loadaccounts.ShowDialog();
            if (dr == DialogResult.OK)
            {
                string filePath = loadaccounts.FileName;
                string[] lines = System.IO.File.ReadAllLines(filePath);
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                if (lines.Length >= 1) textBox1.Text = lines[0];
                if (lines.Length >= 2) textBox2.Text = lines[1];
                if (lines.Length >= 3) textBox3.Text = lines[2];
                if (lines.Length >= 4) textBox4.Text = lines[3];
                if (lines.Length >= 5) textBox5.Text = lines[4];
                if (lines.Length >= 6) textBox6.Text = lines[5];
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter writeFile = new StreamWriter(@"C:\Users\Gebruiker\Documents\Visual Studio 2013\Projects\9.3TextFile\9.3TextFile\bin\Debug\voornaam achternaam.txt");
            writeFile.WriteLine(textBox1.Text);
            writeFile.WriteLine(textBox2.Text);
            writeFile.WriteLine(textBox3.Text);
            writeFile.WriteLine(textBox4.Text);
            writeFile.WriteLine(textBox5.Text);
            writeFile.WriteLine(textBox6.Text);
            

            writeFile.Close();

        }
    }
}
