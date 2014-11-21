using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4._2_Shapes
{
    public partial class Form1 : Form
    {
        private List<Shape> figuurtjes;
        public Form1()
        {
            InitializeComponent();
            //kleurtjes
            foreach (System.Reflection.PropertyInfo prop in typeof(Color).GetProperties())
            {
                if (prop.PropertyType.FullName == "System.Drawing.Color")
                    ColorComboBox.Items.Add(prop.Name);
            }
            figuurtjes = new List<Shape>();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            Point point = new Point(Convert.ToInt32(textBoxPositionX.Text), Convert.ToInt32(textBoxPositionY.Text));
            Color color = Color.FromName(ColorComboBox.Text);
            Circle rondje = new Circle(point, color,double.Parse(textBoxsizerad.Text));
            figuurtjes.Add(rondje);
            listBox1.Items.Add(rondje.ToString());
        }

        private void buttonSquare_Click(object sender, EventArgs e)
        {
            Point point = new Point(Convert.ToInt32(textBoxPositionX.Text), Convert.ToInt32(textBoxPositionY.Text));
            Color color = Color.FromName(ColorComboBox.Text);
            Square spongebob = new Square(point, color, double.Parse(textBoxsizerad.Text));
            figuurtjes.Add(spongebob);
            listBox1.Items.Add(spongebob.ToString());
        }
    }
}
