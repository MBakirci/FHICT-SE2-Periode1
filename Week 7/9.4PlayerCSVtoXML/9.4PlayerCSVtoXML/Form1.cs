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
using System.Xml.Linq;

namespace _9._4PlayerCSVtoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string filePath = Application.StartupPath + @"\Playersweek7.csv";
                string[] lines = File.ReadAllLines(filePath);

                XElement xml = new XElement
                    ("Players",
                    from str in lines
                    let columns = str.Split(',')
                    select new XElement
                        ("Player",
                        new XElement("Player_Name", columns[0]),
                        new XElement("DollarBankroll", columns[1]),
                        new XElement("EuroBankroll", columns[2])
                        // new XElement("DollarMakeup", columns[3]),
                        //new XElement("EuroMakeup", columns[4])
                    )
                );
                xml.Save(AppDomain.CurrentDomain.BaseDirectory + @"\Playersweek7.xml");
                MessageBox.Show("Bestand opgeslagen ;)");
            }
            catch(Exception)
            {
                MessageBox.Show("Foutje");
            }
        }
    }
}
