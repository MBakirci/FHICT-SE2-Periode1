using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace mssgBuilder_10._5._3
{
    public partial class Form1 : Form
    {
        private MessageBuilder Builder = new MessageBuilder("#","%");

        public Form1()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            String tekst = textBox1.Text;
            Builder.Append(tekst);
            Builder.BufferEvent += Builder_BufferEvent;
            Builder.GetMessage(tekst);
            Builder.BufferEvent -= Builder_BufferEvent;
            Builder.Clear();
        }
        private string Builder_BufferEvent(string buffer)
        {
            MessageBox.Show("hé ik krijg iets binen! :|");
            listBox1.Items.Add(buffer);

            return buffer;
        }

       
    }
}
