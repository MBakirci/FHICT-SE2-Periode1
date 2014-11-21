using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Sort
{
    public partial class Form1 : Form
    {
        int[] number;
        Random g = new Random();
        Stopwatch stopwatch = new Stopwatch();
        public Form1()
        {
            InitializeComponent();
            
            
        }

        public void Unsort()
        {
            number = new int[Convert.ToInt32(textBox1.Text)];
            int next = Convert.ToInt32(textBox2.Text);
            for (int i = 0; i < number.Length; i++ )
            {
                number[i] = g.Next(next);
            }
            foreach(int j in number)
            {
                listBox1.Items.Add(j);
            }
        }

        public int[] Bubblesort(int[] a)
        {
            
            int temp;

            for (int i = 1; i <= a.Length; i++)
                for (int j = 0; j < a.Length - i; j++)
                    if (a[j] > a[j + 1])
                    {
                        temp = a[j];
                        a[j] = a[j + 1];
                        a[j + 1] = temp;
                    }
            return a;
            

            
        }

        public int[] SelectionSort(int[] a)
        {
            int i;
            int j;
            int min;
            int temp;
            for (i = 0; i < a.Length - 1; i++)
            {
                min = i;
                for (j = i + 1; j < a.Length; j++)
                {
                    if (a[j] < a[min])
                    {
                        min = j;
                    }
                }
                temp = a[i];
                a[i] = a[min];
                a[min] = temp;
            }
            return a;
        }

        public int[] InsertionSort(int[] a)
        {
            int index;
            int i;
            int j;
            for (i = 1; i < a.Length; i++)
            {
                index = a[i];
                j = i;
                while ((j > 0) && (a[j - 1] > index))
                {
                    a[j] = a[j - 1];
                    j = j - 1;
                }
                a[j] = index;
            }
            return a;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            if(comboBox1.Text == "Bubble")
            {
                stopwatch.Reset();
                stopwatch.Start();
                int[] result = (Bubblesort(number));
                foreach (int i in result)
                {                    
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    string ed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    label1.Text = ed;
                    listBox2.Items.Add(i);
                }
                
            }
            if(comboBox1.Text == "Selection")
            {
                stopwatch.Reset();
                stopwatch.Start();
                int[] result =(SelectionSort(number));
                foreach(int i in result)
                {
                    stopwatch.Stop();
                    TimeSpan ts = stopwatch.Elapsed;
                    string ed = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    label1.Text = ed;
                    listBox2.Items.Add(i);
                }
            }
            if(comboBox1.Text == "Insertion")
            {
                stopwatch.Reset();
                stopwatch.Start();
                int[] result = (InsertionSort(number));
                foreach (int i in result)
                {
                    stopwatch.Stop();
                    label1.Text = stopwatch.Elapsed.ToString();
                    listBox2.Items.Add(i);
                }
            }
            if(comboBox1.Text == "Merge")
            {
                stopwatch.Reset();
                stopwatch.Start();
                int[] result = (mergesort(number, 0, number.Length - 1));
                foreach(int i in result)
                {
                    stopwatch.Stop();
                    label1.Text = stopwatch.Elapsed.ToString();
                    listBox2.Items.Add(i);
                }
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            Unsort();
        }
        public int[] mergeArray(int[] a, int start, int mid, int end)
        {
            
            int[] temp = new int[end - start + 1];

            int i = start;
            int j = mid + 1;
            int k = 0;
            while (i <= mid && j <= end)
            {
                if (a[i] < a[j])
                {
                    temp[k] = a[i];
                    k++;
                    i++;
                }
                else
                {
                    temp[k] = a[j];
                    k++;
                    j++;
                }
            }
            while (i <= mid)
            {
                temp[k] = a[i];
                k++;
                i++;
            }
            while (j <= end)
            {
                temp[k] = a[j];
                k++;
                j++;
            }
            k = 0;
            i = start;
            while (k < temp.Length && i <= end)
            {
                a[i] = temp[k];
                i++;
                k++;
            }
            return a;
        }
        public int[] mergesort(int[] a, int start, int end)
        {
            if (start < end)
            {
                int mid = (end + start) / 2;
                mergesort(a, start, mid);
                mergesort(a, mid + 1, end);
                mergeArray(a, start, mid, end);
            }
            return a;
        }

    }
}
