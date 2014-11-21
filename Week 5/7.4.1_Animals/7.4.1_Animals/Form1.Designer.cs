namespace _7._4._1_Animals
{
    partial class Form1
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
            this.buttonDog = new System.Windows.Forms.Button();
            this.buttonCat = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.textBoxDog = new System.Windows.Forms.TextBox();
            this.textBoxCat = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonDog
            // 
            this.buttonDog.Location = new System.Drawing.Point(33, 38);
            this.buttonDog.Name = "buttonDog";
            this.buttonDog.Size = new System.Drawing.Size(75, 23);
            this.buttonDog.TabIndex = 0;
            this.buttonDog.Text = "Dog";
            this.buttonDog.UseVisualStyleBackColor = true;
            this.buttonDog.Click += new System.EventHandler(this.buttonDog_Click);
            // 
            // buttonCat
            // 
            this.buttonCat.Location = new System.Drawing.Point(33, 99);
            this.buttonCat.Name = "buttonCat";
            this.buttonCat.Size = new System.Drawing.Size(75, 23);
            this.buttonCat.TabIndex = 1;
            this.buttonCat.Text = "Cat";
            this.buttonCat.UseVisualStyleBackColor = true;
            this.buttonCat.Click += new System.EventHandler(this.buttonCat_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(167, 28);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(144, 134);
            this.listBox1.TabIndex = 2;
            // 
            // textBoxDog
            // 
            this.textBoxDog.Location = new System.Drawing.Point(34, 17);
            this.textBoxDog.Name = "textBoxDog";
            this.textBoxDog.Size = new System.Drawing.Size(100, 20);
            this.textBoxDog.TabIndex = 3;
            // 
            // textBoxCat
            // 
            this.textBoxCat.Location = new System.Drawing.Point(34, 78);
            this.textBoxCat.Name = "textBoxCat";
            this.textBoxCat.Size = new System.Drawing.Size(100, 20);
            this.textBoxCat.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(360, 261);
            this.Controls.Add(this.textBoxCat);
            this.Controls.Add(this.textBoxDog);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.buttonCat);
            this.Controls.Add(this.buttonDog);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonDog;
        private System.Windows.Forms.Button buttonCat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TextBox textBoxDog;
        private System.Windows.Forms.TextBox textBoxCat;
    }
}

