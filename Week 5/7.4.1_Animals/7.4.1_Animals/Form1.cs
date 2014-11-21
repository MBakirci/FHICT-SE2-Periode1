using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4._1_Animals
{
    public partial class Form1 : Form
    {
        private List<Animal> beestjes;
        public Form1()
        {
            InitializeComponent();
            beestjes = new List<Animal>();
            Dog hondje = new Dog("hondje");
            hondje.MakeNoise();
            beestjes.Add(hondje);
            listBox1.Items.Add(hondje.ToString());
            Cat poesje = new Cat("poesje");
            poesje.MakeNoise();
            beestjes.Add(poesje);
            listBox1.Items.Add(poesje.ToString());
        }

        private void buttonDog_Click(object sender, EventArgs e)
        {
            Dog hondje = new Dog(textBoxDog.Text);
            hondje.MakeNoise();
            beestjes.Add(hondje);
            listBox1.Items.Add(hondje.ToString());
        }

        private void buttonCat_Click(object sender, EventArgs e)
        {
            Cat poesje = new Cat(textBoxCat.Text);
            poesje.MakeNoise();
            beestjes.Add(poesje);
            listBox1.Items.Add(poesje.ToString());
        }
    }
}
