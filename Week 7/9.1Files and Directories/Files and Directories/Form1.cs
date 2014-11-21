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

namespace Files_and_Directories
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = textBox1.Text;

            string fullpath = Path.GetFullPath(path);
            label1.Text = fullpath;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            DriveInfo[] drives = DriveInfo.GetDrives();

            foreach (DriveInfo d in drives)
            {
                string name = d.Name;
                long totalsize = d.TotalSize / 1048576;
                string GetString = name + " " + totalsize + " Megabytes";
                listBox1.Items.Add(GetString);
            }
        }

        private void CopyCat()
        {
            string source = @textBox2.Text;
            string backup = @textBox3.Text;

            try
            {
                string[] picList = Directory.GetFiles(source, "*.jpg");
                string[] txtList = Directory.GetFiles(source, "*.txt");

                if (comboBox1.Text == ".jpg")
                {
                    // Copy picture files. 
                    foreach (string f in picList)
                    {
                        // Remove path from the file name. 
                        try
                        {


                            string fName = f.Substring(source.Length + 1);

                            // Use the Path.Combine method to safely append the file name to the path. 
                            // Will overwrite if the destination file already exists.
                            File.Copy(Path.Combine(source, fName), Path.Combine(backup, fName), false);
                        }

                        // Catch exception if the file was already copied. 
                        catch (IOException copyError)
                        {
                            MessageBox.Show(copyError.Message);
                        }
                    }
                }
                else if (comboBox1.Text == ".txt")
                {
                    foreach (string f in txtList)
                    {

                        // Remove path from the file name. 
                        string fName = f.Substring(source.Length + 1);

                        try
                        {
                            // Will not overwrite if the destination file already exists.
                            File.Copy(Path.Combine(source, fName), Path.Combine(backup, fName));
                        }

                        // Catch exception if the file was already copied. 
                        catch (IOException copyError)
                        {
                            MessageBox.Show(copyError.Message);
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException dirNotFound)
            {
                MessageBox.Show(dirNotFound.Message);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            CopyCat();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowserDialog1 = new FolderBrowserDialog();
            textBox4.Text = "";
            string standaardMap = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            folderBrowserDialog1.SelectedPath = standaardMap;
            DialogResult result = folderBrowserDialog1.ShowDialog();
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                string selectedfolder = folderBrowserDialog1.SelectedPath;
                textBox4.Text = selectedfolder;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            string startPath = AppDomain.CurrentDomain.BaseDirectory;
            textBox5.Text = startPath;
        }


    }
}
