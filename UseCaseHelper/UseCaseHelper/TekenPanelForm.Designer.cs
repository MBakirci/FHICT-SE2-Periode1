namespace UseCaseHelper
{
    partial class TekenPanelForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TekenPanelForm));
            this.TekenBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.radioButtonCirkel = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.radioButtonLijn = new System.Windows.Forms.RadioButton();
            this.radioButtonActor = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.buttonOpslaan = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.TekenBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TekenBox
            // 
            this.TekenBox.Controls.Add(this.label1);
            this.TekenBox.Controls.Add(this.radioButtonCirkel);
            this.TekenBox.Controls.Add(this.textBox1);
            this.TekenBox.Controls.Add(this.radioButtonLijn);
            this.TekenBox.Controls.Add(this.radioButtonActor);
            this.TekenBox.Location = new System.Drawing.Point(12, 12);
            this.TekenBox.Name = "TekenBox";
            this.TekenBox.Size = new System.Drawing.Size(304, 78);
            this.TekenBox.TabIndex = 0;
            this.TekenBox.TabStop = false;
            this.TekenBox.Text = "Tekentool";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Titel:";
            // 
            // radioButtonCirkel
            // 
            this.radioButtonCirkel.AutoSize = true;
            this.radioButtonCirkel.Location = new System.Drawing.Point(6, 54);
            this.radioButtonCirkel.Name = "radioButtonCirkel";
            this.radioButtonCirkel.Size = new System.Drawing.Size(51, 17);
            this.radioButtonCirkel.TabIndex = 2;
            this.radioButtonCirkel.Text = "Cirkel";
            this.radioButtonCirkel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(62, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // radioButtonLijn
            // 
            this.radioButtonLijn.AutoSize = true;
            this.radioButtonLijn.Location = new System.Drawing.Point(63, 55);
            this.radioButtonLijn.Name = "radioButtonLijn";
            this.radioButtonLijn.Size = new System.Drawing.Size(41, 17);
            this.radioButtonLijn.TabIndex = 3;
            this.radioButtonLijn.Text = "Lijn";
            this.radioButtonLijn.UseVisualStyleBackColor = true;
            // 
            // radioButtonActor
            // 
            this.radioButtonActor.AutoSize = true;
            this.radioButtonActor.Location = new System.Drawing.Point(110, 55);
            this.radioButtonActor.Name = "radioButtonActor";
            this.radioButtonActor.Size = new System.Drawing.Size(50, 17);
            this.radioButtonActor.TabIndex = 1;
            this.radioButtonActor.Text = "Actor";
            this.radioButtonActor.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Window;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 107);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 550);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            this.panel1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseClick);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "stick.png");
            // 
            // buttonOpslaan
            // 
            this.buttonOpslaan.Location = new System.Drawing.Point(335, 68);
            this.buttonOpslaan.Name = "buttonOpslaan";
            this.buttonOpslaan.Size = new System.Drawing.Size(129, 23);
            this.buttonOpslaan.TabIndex = 9;
            this.buttonOpslaan.Text = "Opslaan als afbeelding";
            this.buttonOpslaan.UseVisualStyleBackColor = true;
            this.buttonOpslaan.Click += new System.EventHandler(this.buttonOpslaan_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 68);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TekenPanelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonOpslaan);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TekenBox);
            this.Name = "TekenPanelForm";
            this.Text = "Use Case Helper";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.TekenBox.ResumeLayout(false);
            this.TekenBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox TekenBox;
        private System.Windows.Forms.RadioButton radioButtonCirkel;
        private System.Windows.Forms.RadioButton radioButtonLijn;
        private System.Windows.Forms.RadioButton radioButtonActor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button buttonOpslaan;
        private System.Windows.Forms.Button button1;
    }
}