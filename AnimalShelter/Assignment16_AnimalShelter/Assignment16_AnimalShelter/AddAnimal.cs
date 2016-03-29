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
        Shelter animShelter; 
        private Main main;

        public AddAnimal()
        {
            InitializeComponent();
            //animShelter = main.animalShelter;
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            DateTime entryDate = dateTimePickerEntryDate.Value;
            string locationFound = tbLocataion.Text;
            string pedegree = tbPedigree.Text;
            if(radioCat.Checked)
            {
                string habit = tbHabit.Text;
                Cat cat = new Cat(animShelter.CreateChipNr(), entryDate, pedegree, locationFound, habit);
                if (animShelter.AddAnimal(cat))
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
                Dog dog = new Dog(animShelter.CreateChipNr(), entryDate, pedegree, locationFound, DateTime.Now);
                if (animShelter.AddAnimal(dog))
                {
                    MessageBox.Show("Your dog is added");
                }
                else
                {
                    MessageBox.Show("Fail to add this dog");
                }
            }

        }

    }
}
