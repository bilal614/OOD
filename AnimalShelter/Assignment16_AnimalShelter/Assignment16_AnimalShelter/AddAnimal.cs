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
        Shelter animalShelter;
        public AddAnimal(Shelter s)
        {
            InitializeComponent();
            animalShelter = s;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            try
            {
                DateTime entryDate = dateTimePickerEntryDate.Value;
                string locationFound = tbLocataion.Text;
                string pedegree = tbPedigree.Text;
                if (radioCat.Checked)
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

                    Dog dog = new Dog(animalShelter.CreateChipNr(), entryDate, pedegree, locationFound, entryDate);
                    if (animalShelter.AddAnimal(dog))
                    {
                        MessageBox.Show("Your dog is added");
                    }
                    else
                    {
                        MessageBox.Show("Fail to add this dog");
                    }
                }
            }
            catch
            {
                MessageBox.Show("Invalid input");
            }
           

        }

        private void btnShowAnimals_Click(object sender, EventArgs e)
        {
            listBoxAnimal.Items.Clear();
            List<Animal> animals = animalShelter.GetListOfAnimals();
            foreach(var a in animals)
            {
                listBoxAnimal.Items.Add(a.AsString());
            }

        }

    }
}
