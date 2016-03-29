using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Assignment16_AnimalShelter.Classes;

namespace Assignment16_AnimalShelter
{
    public partial class AddAnimal : Form
    {
        //Variables
<<<<<<< HEAD
        Shelter animShelter; 
        private Main main;

        public AddAnimal()
        {
            InitializeComponent();
            //animShelter = main.animalShelter;
=======
        Shelter animalShelter = new Shelter("Eindhoven Animal Shelter", 999000999, "Fontys, Eindhoven", "example@example.com");
        public AddAnimal()
        {
            InitializeComponent();
>>>>>>> 18ab2ea4b81559a5fdc2898c7d40155a74fd5b6e
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            DateTime entryDate = dateTimePickerEntryDate.Value;
            string locationFound = tbLocataion.Text;
            string pedegree = tbPedigree.Text;
            if(radioCat.Checked)
            {
                string habit = tbHabit.Text;
                Cat cat = new Cat(animalShelter.CreateChipNr(), entryDate, pedegree, locationFound, habit);
                if (animalShelter.AddAnimal(cat))
                {
                    MessageBox.Show("Your cat is added");
                }
                else
                {
                    MessageBox.Show("Fail to add this cat");
                }
            }
            else
            {
<<<<<<< HEAD
                Dog dog = new Dog(animShelter.CreateChipNr(), entryDate, pedegree, locationFound, DateTime.Now);
                if (animShelter.AddAnimal(dog))
=======
                Dog dog = new Dog(animalShelter.CreateChipNr(), entryDate, pedegree, locationFound, entryDate);
                if (animalShelter.AddAnimal(dog))
>>>>>>> 18ab2ea4b81559a5fdc2898c7d40155a74fd5b6e
                {
                    MessageBox.Show("Your dog is added");
                }
                else
                {
                    MessageBox.Show("Fail to add this dog");
                }
<<<<<<< HEAD
=======
            }

        }

        private void btnShowAnimals_Click(object sender, EventArgs e)
        {
            listBoxAnimal.Items.Clear();
            List<Animal> animals = animalShelter.GetListOfAnimals();
            foreach(var a in animals)
            {
                listBoxAnimal.Items.Add(a.AsString());
>>>>>>> 18ab2ea4b81559a5fdc2898c7d40155a74fd5b6e
            }

        }

    }
}
