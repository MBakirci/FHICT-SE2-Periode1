using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

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

            //Dit hoeft allemaal niet meer omdat er Seriazable wordt gebruitk.!
            //Animal kat = new Cat("98765", new SimpleDate(01, 03, 2004), "Katertje", "Bijt kinderen!", gender.Female);
            //Animal hond = new Dog("23456", new SimpleDate(01, 03, 2014), "Hondje", new SimpleDate(01, 09, 2014), gender.Male);
            //Animal kat1 = new Cat("12345", new SimpleDate(01, 03, 2004), "Katertje1", "Bijt kinderen en moeders!", gender.Male);
            //kat.PriceTo();
            //hond.PriceTo();
            //kat1.PriceTo();
            //administration.Add(kat);
            //administration.Add(hond);
            //administration.Add(kat1);
            //listBoxNonReserved.Items.Add(kat.ToString());
            //listBoxNonReserved.Items.Add(hond.ToString());
            //listBoxNonReserved.Items.Add(kat1.ToString());
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
            SimpleDate Birthday = new SimpleDate(dTPBirthDay.Value.Day, dTPBirthDay.Value.Month, dTPBirthDay.Value.Year);

            gender Gender = (gender)comboBoxGender.SelectedItem;    
                  
            // TODO: See method description
            if(animalTypeComboBox.Text == "Dog")
            {
                SimpleDate LastWalk = new SimpleDate(dTPlaatsUitgelaten.Value.Day,dTPBirthDay.Value.Month,dTPBirthDay.Value.Year);
                Animal animal = new Dog(tbChip.Text, Birthday,tbNaam.Text,LastWalk,Gender);
                administration.NiewDier += administration_NiewDier;
                administration.addAnimal(animal);
                administration.NiewDier -= administration_NiewDier;
            }
            else if(animalTypeComboBox.Text == "Cat")
            {
                Animal animal = new Cat(tbChip.Text, Birthday, tbNaam.Text, tbHabits.Text, Gender);
                administration.NiewDier += administration_NiewDier;
                administration.addAnimal(animal);
                administration.NiewDier -= administration_NiewDier;
            }
        }

        private bool administration_NiewDier(Animal animal)
        {
            if (administration.Animals.Count == 0)
            {
                animal.PriceTo();
                administration.Animals.Add(animal);
                string StringAnimal = animal.ToString();
                listBoxNonReserved.Items.Add(StringAnimal);
            }
            else
            {
                foreach (Animal a in administration.Animals)
                {
                    if (a.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                    {
                        MessageBox.Show("Dit chipnummer is al in gebruik");
                        return false;
                    }
                    else
                    {
                        animal.PriceTo();
                        administration.Animals.Add(animal);
                        string StringAnimal = animal.ToString();
                        listBoxNonReserved.Items.Add(StringAnimal);
                        return true;
                    }
                }
            }
            return false;
        }

        /// <summary>
        /// Show the info of the animal referenced by the 'animal' field. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void showInfoButton_Click(object sender, EventArgs e)
        {
            // TODO: See method description
            //Wat heeft deze knop voor functionalteit?? :|
        }

        private void btnVrijgeven_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a = administration.FindAnimal(listBoxReserved.SelectedItem.ToString().Substring(4, 5));
                a.IsReserved = false;
                listBoxReserved.Items.Remove(listBoxReserved.SelectedItem);
                listBoxNonReserved.Items.Add(a.ToString());
            }
            catch(NullReferenceException NRE)
            {
                 if(listBoxNonReserved.Items.Count ==0)
                {
                    MessageBox.Show("De lijst is nog leeg!" + "\n" + NRE.Message);
                }
                else
                {
                    MessageBox.Show("Selecteer een dier aub.");
                }
            }
           
        }

        private void btnReserveren_Click(object sender, EventArgs e)
        {
            try
            {
                Animal a = administration.FindAnimal(listBoxNonReserved.SelectedItem.ToString().Substring(4, 5));
                a.IsReserved = true;
                listBoxNonReserved.Items.Remove(listBoxNonReserved.SelectedItem);
                listBoxReserved.Items.Add(a.ToString());
            }

            catch (NullReferenceException NRE)
            {
                if(listBoxNonReserved.Items.Count ==0)
                {
                    MessageBox.Show("De lijst is nog leeg!" + "\n" + NRE.Message);
                }
                else
                {
                    MessageBox.Show("Selecteer een dier aub.");
                }
                
            }
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

        private void Serialize()
        {
            
                FileStream bestand = new FileStream("temp.bin", FileMode.Open, FileAccess.ReadWrite);
                BinaryFormatter formater = new BinaryFormatter();
                try
                {
                    formater.Serialize(bestand, administration);
                    MessageBox.Show("Bestanden opgeslagen.");
                }
                catch (SerializationException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    bestand.Close();
                }
            
            
           
            
        }

        private void btnOpslaanGegev_Click(object sender, EventArgs e)
        {
            if (listBoxReserved.Items.Count != 0 || listBoxNonReserved.Items.Count != 0)
            {
                Serialize();
            }
            else
            {
                MessageBox.Show("De listboxen zijn nog leeg!");
            }

        }
    
        private void Deserialize()
        {
            
                Administration SerializedData = null;

                FileStream bestand = new FileStream("temp.bin", FileMode.Open);
                BinaryFormatter formater = new BinaryFormatter();
                try
                {
                    listBoxNonReserved.Items.Clear();
                    listBoxReserved.Items.Clear();
                    SerializedData = (Administration)formater.Deserialize(bestand);
                    MessageBox.Show("Bestanden geladen.");


                    foreach (Animal animals in SerializedData.Animals)
                    {
                        administration.Add(animals);
                        if (animals.IsReserved)
                        {
                            listBoxReserved.Items.Add(animals);
                        }
                        else
                        {
                            listBoxNonReserved.Items.Add(animals);
                        }
                    }

                }
                catch (SerializationException exc)
                {
                    MessageBox.Show(exc.Message);
                }
                finally
                {
                    bestand.Close();
                }
            
            
        }

        private void btnLaadGegev_Click(object sender, EventArgs e)
        {
            if (listBoxReserved.Items.Count == 0 && listBoxNonReserved.Items.Count == 0)
            {
                Deserialize();
            }
        }
    }
}
