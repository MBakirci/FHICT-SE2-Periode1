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

            Animal kat = new Cat("98765", new SimpleDate(01,03,2004), "Katertje", "Bijt kinderen!",gender.Female);
            Animal hond = new Dog("23456", new SimpleDate(01, 03, 2014), "Hondje", new SimpleDate(01, 09, 2014),gender.Male);
            Animal kat1 = new Cat("12345", new SimpleDate(01, 03, 2004), "Katertje1", "Bijt kinderen en moeders!", gender.Male);
            kat.PriceTo();
            hond.PriceTo();
            kat1.PriceTo();
            administration.Add(kat);
            administration.Add(hond);
            administration.Add(kat1);
            listBoxNonReserved.Items.Add(kat.ToString());
            listBoxNonReserved.Items.Add(hond.ToString());
            listBoxNonReserved.Items.Add(kat1.ToString());
            comboBoxGender.DataSource = Enum.GetValues(typeof(gender));

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
            gender Gender = (gender)comboBoxGender.SelectedItem;           
            // TODO: See method description
            if(animalTypeComboBox.Text == "Dog")
            {
                SimpleDate LastWalk = new SimpleDate(Convert.ToInt32(tbLastDay.Text), Convert.ToInt32(tbLastMonth.Text), Convert.ToInt32(tbLastYear.Text));
                Animal animal = new Dog(tbChip.Text, Birthday,tbNaam.Text,LastWalk,Gender);
                animal.PriceTo();
                administration.Add(animal);
                listBoxNonReserved.Items.Add(animal.ToString());
            }
            else if(animalTypeComboBox.Text == "Cat")
            {
                Animal animal = new Cat(tbChip.Text, Birthday, tbNaam.Text, tbHabits.Text,Gender);
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
        private void btnTestKnop_Click(object sender, EventArgs e)
        {

            administration.Animals.Sort(); //sort op chipnummer

            foreach(Animal a in administration.Animals)
            {
                if(a is Dog)
                {
                    listBox1.Items.Add(a);
                }
                else if (a is Cat)
                {
                    listBox1.Items.Add(a);
                }

            }

        }
    }
}
