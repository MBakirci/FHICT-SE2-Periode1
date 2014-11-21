using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
    public partial class AdministrationForm : Form
    {
        /// <summary>
        /// The (only) animal in this administration (for now....)
        /// </summary>
        private Administration administration = new Administration();

        /// <summary>
        /// Creates the form for doing adminstrative tasks
        /// </summary>
        public AdministrationForm()
        {
            InitializeComponent();
            animalTypeComboBox.SelectedIndex = 0;

            Animal kat = new Cat("00001", new SimpleDate(01,03,2004), "Katertje", "Bijt kinderen!");
            Animal hond = new Dog("00002", new SimpleDate(01, 03, 2014), "Hondje", new SimpleDate(01, 09, 2014));
            kat.PriceTo();
            hond.PriceTo();
            administration.Add(kat);
            administration.Add(hond);
            listBoxNonReserved.Items.Add(kat.ToString());
            listBoxNonReserved.Items.Add(hond.ToString());

        }


        /// <summary>
        /// Create an Animal object and store it in the administration.
        /// If "Dog" is selected in the animalTypeCombobox then a Dog object should be created.
        /// If "Cat" is selected in the animalTypeCombobox then a Cat object should be created.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void createAnimalButton_Click(object sender, EventArgs e)
        {
            SimpleDate Birthday = new SimpleDate(Convert.ToInt32(tbBirthDay.Text), Convert.ToInt32(tbBirthMonth.Text), Convert.ToInt32(tbBirthYear.Text));
                       
            // TODO: See method description
            if(animalTypeComboBox.Text == "Dog")
            {
                SimpleDate LastWalk = new SimpleDate(Convert.ToInt32(tbLastDay.Text), Convert.ToInt32(tbLastMonth.Text), Convert.ToInt32(tbLastYear.Text));
                Animal animal = new Dog(tbChip.Text, Birthday,tbNaam.Text,LastWalk);
                animal.PriceTo();
                administration.Add(animal);
                listBoxNonReserved.Items.Add(animal.ToString());
                
            }
            else if(animalTypeComboBox.Text == "Cat")
            {
                Animal animal = new Cat(tbChip.Text, Birthday, tbNaam.Text, tbHabits.Text);
                animal.PriceTo();
                administration.Add(animal);
                listBoxNonReserved.Items.Add(animal.ToString());
            }
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
        }

        private void btnVrijgeven_Click(object sender, EventArgs e)
        {
            Animal a = administration.FindAnimal(listBoxReserved.SelectedItem.ToString().Substring(4, 5));
            a.IsReserved = false;
            listBoxReserved.Items.Remove(listBoxReserved.SelectedItem);
            listBoxNonReserved.Items.Add(a.ToString());
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            Animal a = administration.FindAnimal(listBoxNonReserved.SelectedItem.ToString().Substring(4,5));
            a.IsReserved = true;
            listBoxNonReserved.Items.Remove(listBoxNonReserved.SelectedItem);
            listBoxReserved.Items.Add(a.ToString());
        }

        private void btnVerwijderen_Click(object sender, EventArgs e)
        {
            if(listBoxNonReserved.SelectedIndex != -1 )
            {
                administration.RemoveAnimal(listBoxNonReserved.SelectedItem.ToString().Substring(4,5));
                listBoxNonReserved.Items.Remove(listBoxNonReserved.SelectedItem);
            }
            else if(listBoxReserved.SelectedIndex != -1)
            {
                administration.RemoveAnimal(listBoxReserved.SelectedItem.ToString().Substring(4,5));
                listBoxReserved.Items.Remove(listBoxReserved.SelectedItem);
            }
            

        }
    }
}
