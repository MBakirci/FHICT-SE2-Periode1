using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class UseCaseForm : Form
    {
        public TekenPanelForm frm2;
        public UseCaseForm(string tbtext)
        {
            InitializeComponent();
            tbNaam.Text = tbtext;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName != "")
            {
                Bitmap printImage = new Bitmap(tplUseCase.Width, tplUseCase.Height);
                tplUseCase.DrawToBitmap(printImage, new Rectangle(0, 0, printImage.Width, printImage.Height));
                printImage.Save(saveFileDialog1.FileName);
            }              
            this.Close();
        }

    }
}
