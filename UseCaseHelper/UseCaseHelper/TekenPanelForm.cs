using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace UseCaseHelper
{
    public partial class TekenPanelForm : Form
    {
        
        public TekenPanelForm()
        {
            
            InitializeComponent();
        }
        List<Figuur> figuurlijst = new List<Figuur>();
        List< TextBox> txtboxUse = new List<TextBox>();
        List<TextBox> txtboxActor = new List<TextBox>();

        int c = 0;
        int c1 = 0;
        Point p1;
        Point p2;
        bool check = false;


        // Voeg een ellipse en een lege textbox toe voor de Use cases
        private void panel1_MouseClick(object sender, MouseEventArgs e) 
        {
            if (e.X > panel1.Width/3.25 && radioButtonCirkel.Checked)
            {
                //Cirkeltje toevoegen aan list
                Graphics g = this.panel1.CreateGraphics();
                g.DrawEllipse(Pens.Blue, e.X - 75, e.Y - 50, 150, 100);
                Figuur cirkel = new Figuur("Cirkel", e.X - 75, e.Y - 50, 100, 150);
                figuurlijst.Add(cirkel);


                //Textboxje toevoegen aan txtlist en openen invul form
                TextBox txtbox = new TextBox();
                txtbox.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(Press_Enter);
                txtbox.Name = "txtbox" + c++;
                txtbox.Location = new System.Drawing.Point(e.X - 50, e.Y);
                txtbox.Size = new System.Drawing.Size(100, 25);
                panel1.Controls.Add(txtbox);
                txtboxUse.Add(txtbox);
                
            }
            // alleen aan de linker kant mogen er Use Cases komen
            else if (e.X < panel1.Width/3.25 && radioButtonCirkel.Checked) 
            {
                MessageBox.Show("Use cases aan de linkerkant tekenen svp.");
            }
            // lege textbox en tekening toevoegen voor Actor
            if (radioButtonActor.Checked && c1<3) 
            {
                //tekstboxje
                TextBox txtbox = new TextBox();
                txtbox.Name = "txtbox" + c1++;
                txtbox.Location = new System.Drawing.Point(40, 145*c1 );
                txtbox.Size = new System.Drawing.Size(100, 25);
                panel1.Controls.Add(txtbox);
                txtboxActor.Add(txtbox);

               
                
                //Pictureboxje
                PictureBox picBox = new PictureBox();
                picBox.Location = new System.Drawing.Point(50, 140*c1 - 80);
                picBox.Size = new System.Drawing.Size(84, 120);
                picBox.Image = imageList1.Images[0];
                panel1.Controls.Add(picBox);

                
            }
            //lijn van p1 naar p2 trekken
            if(radioButtonLijn.Checked) 
            {
               
                if (!check)
                {
                    p1 = e.Location;
                    check = true;
                }

                else
                {
                    p2 = e.Location;
                    Graphics g = this.panel1.CreateGraphics();
                    g.DrawLine(Pens.Red, p1, p2);  
                    Figuur Lijn = new Figuur("Lijn", p1, p2);
                    figuurlijst.Add(Lijn);                    
                    check = false;

                }

            }

        }

        private void buttonOpslaan_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Bitmap Image|*.bmp";
            saveFileDialog1.Title = "Save an Image File";
            saveFileDialog1.ShowDialog();
            if(saveFileDialog1.FileName != "")
            {
                Bitmap bmp = new Bitmap(panel1.Size.Width, panel1.Size.Height);
                panel1.DrawToBitmap(bmp, new Rectangle(0,0,panel1.Size.Width, panel1.Size.Height));
                bmp.Save(saveFileDialog1.FileName);
            }
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;

            foreach (Figuur f in figuurlijst)
            {
                if (f.Soort == "Cirkel")
                {
                    graphics.DrawEllipse(Pens.Blue, f.X, f.Y, f.W, f.H);
                }
                if (f.Soort == "Lijn")
                {
                    graphics.DrawLine(Pens.Red, f.P1, f.P2);
                }
            }          
        }

        private TextBox FindFocused()
        {
            foreach(Control tb in panel1.Controls)
            {
                if(tb is TextBox && tb.Focused)
                {
                    return tb as TextBox;
                }
            }
            return null; 
        }

        private void Press_Enter(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                TextBox tb = FindFocused();
                UseCaseForm frm = new UseCaseForm(tb.Text);
                frm.Show();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.panel1.CreateGraphics();
            g.Clear(Color.White);
            txtboxActor.Clear();
            txtboxUse.Clear();
            figuurlijst.Clear();
            panel1.Controls.Clear();
            c = 0;
            c1 = 0;
        }
    }
}