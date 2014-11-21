using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AnimalShelter
{
   // public delegate string NiewDierHandler(Animal animal);
    [Serializable]
    class Administration
    {
        public delegate bool NiewDierHandler(Animal animal);
        public event NiewDierHandler NiewDier;

        private List<Animal> animals= new List<Animal>();

        public List<Animal> Animals { get { return animals; } }
        
        public Administration()
        {
        }

        public bool Add(Animal animal)
        {
            bool succes = true;
            foreach(Animal a in animals)
            {
                if(a.ChipRegistrationNumber == animal.ChipRegistrationNumber)
                {
                    succes = false;
                }
            }
            if(succes)
            {
                animals.Add(animal);
            }
            return succes;
        }

        public bool RemoveAnimal(string chipRegistrationNumber)
        {
            foreach(Animal a in animals)
            {
                if(a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    animals.Remove(a);
                    return true;
                }
            }
            return false;
        }

        public Animal FindAnimal(string chipRegistrationNumber)
        {
            foreach(Animal a in animals)
            {
                if(a.ChipRegistrationNumber == chipRegistrationNumber)
                {
                    return a;
                }
            }            
            return null;
        }
        public bool addAnimal(Animal animal)
        {
            if (NiewDier != null)
            {
                NiewDier(animal);
                return true;
            }
            return false;
        }
        

    }
}
