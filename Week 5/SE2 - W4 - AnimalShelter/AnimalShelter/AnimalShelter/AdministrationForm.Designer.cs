namespace AnimalShelter
{
    partial class AdministrationForm
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
            this.animalTypeComboBox = new System.Windows.Forms.ComboBox();
            this.createAnimalButton = new System.Windows.Forms.Button();
            this.showInfoButton = new System.Windows.Forms.Button();
            this.tbNaam = new System.Windows.Forms.TextBox();
            this.tbChip = new System.Windows.Forms.TextBox();
            this.lblNaam = new System.Windows.Forms.Label();
            this.lblGeboorte = new System.Windows.Forms.Label();
            this.lblChipNummer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbHabits = new System.Windows.Forms.TextBox();
            this.tbBirthDay = new System.Windows.Forms.TextBox();
            this.tbBirthMonth = new System.Windows.Forms.TextBox();
            this.tbBirthYear = new System.Windows.Forms.TextBox();
            this.tbLastYear = new System.Windows.Forms.TextBox();
            this.tbLastMonth = new System.Windows.Forms.TextBox();
            this.tbLastDay = new System.Windows.Forms.TextBox();
            this.listBoxReserved = new System.Windows.Forms.ListBox();
            this.lblReserved = new System.Windows.Forms.Label();
            this.lblNonReserved = new System.Windows.Forms.Label();
            this.listBoxNonReserved = new System.Windows.Forms.ListBox();
            this.btnVrijgeven = new System.Windows.Forms.Button();
            this.btnReserveren = new System.Windows.Forms.Button();
            this.btnVerwijderen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalTypeComboBox
            // 
            this.animalTypeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.animalTypeComboBox.FormattingEnabled = true;
            this.animalTypeComboBox.Items.AddRange(new object[] {
            "Cat",
            "Dog"});
            this.animalTypeComboBox.Location = new System.Drawing.Point(12, 12);
            this.animalTypeComboBox.Name = "animalTypeComboBox";
            this.animalTypeComboBox.Size = new System.Drawing.Size(121, 21);
            this.animalTypeComboBox.TabIndex = 0;
            // 
            // createAnimalButton
            // 
            this.createAnimalButton.Location = new System.Drawing.Point(139, 10);
            this.createAnimalButton.Name = "createAnimalButton";
            this.createAnimalButton.Size = new System.Drawing.Size(64, 23);
            this.createAnimalButton.TabIndex = 1;
            this.createAnimalButton.Text = "Create";
            this.createAnimalButton.UseVisualStyleBackColor = true;
            this.createAnimalButton.Click += new System.EventHandler(this.createAnimalButton_Click);
            // 
            // showInfoButton
            // 
            this.showInfoButton.Location = new System.Drawing.Point(209, 9);
            this.showInfoButton.Name = "showInfoButton";
            this.showInfoButton.Size = new System.Drawing.Size(75, 23);
            this.showInfoButton.TabIndex = 2;
            this.showInfoButton.Text = "Show Info";
            this.showInfoButton.UseVisualStyleBackColor = true;
            this.showInfoButton.Click += new System.EventHandler(this.showInfoButton_Click);
            // 
            // tbNaam
            // 
            this.tbNaam.Location = new System.Drawing.Point(102, 55);
            this.tbNaam.Name = "tbNaam";
            this.tbNaam.Size = new System.Drawing.Size(121, 20);
            this.tbNaam.TabIndex = 3;
            // 
            // tbChip
            // 
            this.tbChip.Location = new System.Drawing.Point(102, 108);
            this.tbChip.Name = "tbChip";
            this.tbChip.Size = new System.Drawing.Size(120, 20);
            this.tbChip.TabIndex = 5;
            // 
            // lblNaam
            // 
            this.lblNaam.AutoSize = true;
            this.lblNaam.Location = new System.Drawing.Point(13, 61);
            this.lblNaam.Name = "lblNaam";
            this.lblNaam.Size = new System.Drawing.Size(38, 13);
            this.lblNaam.TabIndex = 8;
            this.lblNaam.Text = "Naam:";
            // 
            // lblGeboorte
            // 
            this.lblGeboorte.AutoSize = true;
            this.lblGeboorte.Location = new System.Drawing.Point(13, 88);
            this.lblGeboorte.Name = "lblGeboorte";
            this.lblGeboorte.Size = new System.Drawing.Size(88, 13);
            this.lblGeboorte.TabIndex = 9;
            this.lblGeboorte.Text = "Geboorte Datum:";
            // 
            // lblChipNummer
            // 
            this.lblChipNummer.AutoSize = true;
            this.lblChipNummer.Location = new System.Drawing.Point(13, 115);
            this.lblChipNummer.Name = "lblChipNummer";
            this.lblChipNummer.Size = new System.Drawing.Size(71, 13);
            this.lblChipNummer.TabIndex = 10;
            this.lblChipNummer.Text = "Chip nummer:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 139);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Laatst Uitgelaten:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Bad Habits: ";
            // 
            // tbHabits
            // 
            this.tbHabits.Location = new System.Drawing.Point(103, 165);
            this.tbHabits.Name = "tbHabits";
            this.tbHabits.Size = new System.Drawing.Size(120, 20);
            this.tbHabits.TabIndex = 14;
            // 
            // tbBirthDay
            // 
            this.tbBirthDay.Location = new System.Drawing.Point(103, 82);
            this.tbBirthDay.Name = "tbBirthDay";
            this.tbBirthDay.Size = new System.Drawing.Size(30, 20);
            this.tbBirthDay.TabIndex = 16;
            // 
            // tbBirthMonth
            // 
            this.tbBirthMonth.Location = new System.Drawing.Point(139, 82);
            this.tbBirthMonth.Name = "tbBirthMonth";
            this.tbBirthMonth.Size = new System.Drawing.Size(30, 20);
            this.tbBirthMonth.TabIndex = 17;
            // 
            // tbBirthYear
            // 
            this.tbBirthYear.Location = new System.Drawing.Point(175, 82);
            this.tbBirthYear.Name = "tbBirthYear";
            this.tbBirthYear.Size = new System.Drawing.Size(47, 20);
            this.tbBirthYear.TabIndex = 18;
            // 
            // tbLastYear
            // 
            this.tbLastYear.Location = new System.Drawing.Point(175, 139);
            this.tbLastYear.Name = "tbLastYear";
            this.tbLastYear.Size = new System.Drawing.Size(47, 20);
            this.tbLastYear.TabIndex = 21;
            // 
            // tbLastMonth
            // 
            this.tbLastMonth.Location = new System.Drawing.Point(139, 139);
            this.tbLastMonth.Name = "tbLastMonth";
            this.tbLastMonth.Size = new System.Drawing.Size(30, 20);
            this.tbLastMonth.TabIndex = 20;
            // 
            // tbLastDay
            // 
            this.tbLastDay.Location = new System.Drawing.Point(103, 139);
            this.tbLastDay.Name = "tbLastDay";
            this.tbLastDay.Size = new System.Drawing.Size(30, 20);
            this.tbLastDay.TabIndex = 19;
            // 
            // listBoxReserved
            // 
            this.listBoxReserved.FormattingEnabled = true;
            this.listBoxReserved.Location = new System.Drawing.Point(288, 31);
            this.listBoxReserved.Name = "listBoxReserved";
            this.listBoxReserved.Size = new System.Drawing.Size(387, 212);
            this.listBoxReserved.TabIndex = 22;
            // 
            // lblReserved
            // 
            this.lblReserved.AutoSize = true;
            this.lblReserved.Location = new System.Drawing.Point(285, 9);
            this.lblReserved.Name = "lblReserved";
            this.lblReserved.Size = new System.Drawing.Size(56, 13);
            this.lblReserved.TabIndex = 23;
            this.lblReserved.Text = "Reserverd";
            // 
            // lblNonReserved
            // 
            this.lblNonReserved.AutoSize = true;
            this.lblNonReserved.Location = new System.Drawing.Point(733, 9);
            this.lblNonReserved.Name = "lblNonReserved";
            this.lblNonReserved.Size = new System.Drawing.Size(82, 13);
            this.lblNonReserved.TabIndex = 25;
            this.lblNonReserved.Text = "Non -Reserverd";
            // 
            // listBoxNonReserved
            // 
            this.listBoxNonReserved.FormattingEnabled = true;
            this.listBoxNonReserved.Location = new System.Drawing.Point(736, 30);
            this.listBoxNonReserved.Name = "listBoxNonReserved";
            this.listBoxNonReserved.Size = new System.Drawing.Size(372, 212);
            this.listBoxNonReserved.TabIndex = 24;
            // 
            // btnVrijgeven
            // 
            this.btnVrijgeven.Location = new System.Drawing.Point(288, 249);
            this.btnVrijgeven.Name = "btnVrijgeven";
            this.btnVrijgeven.Size = new System.Drawing.Size(75, 23);
            this.btnVrijgeven.TabIndex = 26;
            this.btnVrijgeven.Text = "Vrijgeven";
            this.btnVrijgeven.UseVisualStyleBackColor = true;
            this.btnVrijgeven.Click += new System.EventHandler(this.btnVrijgeven_Click);
            // 
            // btnReserveren
            // 
            this.btnReserveren.Location = new System.Drawing.Point(736, 249);
            this.btnReserveren.Name = "btnReserveren";
            this.btnReserveren.Size = new System.Drawing.Size(75, 23);
            this.btnReserveren.TabIndex = 27;
            this.btnReserveren.Text = "Reserveren";
            this.btnReserveren.UseVisualStyleBackColor = true;
            this.btnReserveren.Click += new System.EventHandler(this.btnReserveren_Click);
            // 
            // btnVerwijderen
            // 
            this.btnVerwijderen.Location = new System.Drawing.Point(807, 305);
            this.btnVerwijderen.Name = "btnVerwijderen";
            this.btnVerwijderen.Size = new System.Drawing.Size(75, 23);
            this.btnVerwijderen.TabIndex = 28;
            this.btnVerwijderen.Text = "Verwijderen";
            this.btnVerwijderen.UseVisualStyleBackColor = true;
            this.btnVerwijderen.Click += new System.EventHandler(this.btnVerwijderen_Click);
            // 
            // AdministrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1120, 410);
            this.Controls.Add(this.btnVerwijderen);
            this.Controls.Add(this.btnReserveren);
            this.Controls.Add(this.btnVrijgeven);
            this.Controls.Add(this.lblNonReserved);
            this.Controls.Add(this.listBoxNonReserved);
            this.Controls.Add(this.lblReserved);
            this.Controls.Add(this.listBoxReserved);
            this.Controls.Add(this.tbLastYear);
            this.Controls.Add(this.tbLastMonth);
            this.Controls.Add(this.tbLastDay);
            this.Controls.Add(this.tbBirthYear);
            this.Controls.Add(this.tbBirthMonth);
            this.Controls.Add(this.tbBirthDay);
            this.Controls.Add(this.tbHabits);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblChipNummer);
            this.Controls.Add(this.lblGeboorte);
            this.Controls.Add(this.lblNaam);
            this.Controls.Add(this.tbChip);
            this.Controls.Add(this.tbNaam);
            this.Controls.Add(this.showInfoButton);
            this.Controls.Add(this.createAnimalButton);
            this.Controls.Add(this.animalTypeComboBox);
            this.Name = "AdministrationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox animalTypeComboBox;
        private System.Windows.Forms.Button createAnimalButton;
        private System.Windows.Forms.Button showInfoButton;
        private System.Windows.Forms.TextBox tbNaam;
        private System.Windows.Forms.TextBox tbChip;
        private System.Windows.Forms.Label lblNaam;
        private System.Windows.Forms.Label lblGeboorte;
        private System.Windows.Forms.Label lblChipNummer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbHabits;
        private System.Windows.Forms.TextBox tbBirthDay;
        private System.Windows.Forms.TextBox tbBirthMonth;
        private System.Windows.Forms.TextBox tbBirthYear;
        private System.Windows.Forms.TextBox tbLastYear;
        private System.Windows.Forms.TextBox tbLastMonth;
        private System.Windows.Forms.TextBox tbLastDay;
        private System.Windows.Forms.ListBox listBoxReserved;
        private System.Windows.Forms.Label lblReserved;
        private System.Windows.Forms.Label lblNonReserved;
        private System.Windows.Forms.ListBox listBoxNonReserved;
        private System.Windows.Forms.Button btnVrijgeven;
        private System.Windows.Forms.Button btnReserveren;
        private System.Windows.Forms.Button btnVerwijderen;

    }
}

