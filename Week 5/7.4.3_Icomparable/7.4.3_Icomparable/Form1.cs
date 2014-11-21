using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _7._4._3_Icomparable
{
    public partial class Form1 : Form
    {
        private List<Student> students = new List<Student>();
        public Form1()
        {
            InitializeComponent();
            Student b = new Student("b", "straatq", 10021);
            students.Add(b);
            Student a = new Student("a", "straatw", 10045);
            students.Add(a);
            Student c = new Student("c", "straate", 10098);
            students.Add(c);
            Student g = new Student("g", "straatr", 10056);
            students.Add(g);
            Student d = new Student("d", "straatt", 10088);
            students.Add(d);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            
            students.Sort();

            foreach(Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SortByNumber sbn = new SortByNumber();
            students.Sort(sbn);

            foreach(Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            SortByAddress sba = new SortByAddress();
            students.Sort(sba);

            foreach(Student s in students)
            {
                listBox1.Items.Add(s);
            }
        }
    }
}
