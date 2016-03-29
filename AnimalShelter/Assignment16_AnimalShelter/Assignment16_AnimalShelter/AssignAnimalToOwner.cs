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
    public partial class AssignAnimalToOwner : Form
    {
<<<<<<< HEAD
        private Main main;
        Shelter animShelter;

=======
        Shelter animalShelter = new Shelter("LoopIT", 268809, "I don't know", "loopITemail@gmail.com");
>>>>>>> 18ab2ea4b81559a5fdc2898c7d40155a74fd5b6e
        public AssignAnimalToOwner()
        {
            InitializeComponent();
            //animShelter = main.AnimalShelter;
        }

        private void FillListBox(List<Animal> animals)
        {
            listBoxAnimal.Items.Clear();
            foreach (Animal a in animals)
            {
                listBoxAnimal.Items.Add(a.AsString());
            }
        }

<<<<<<< HEAD
        private void button1_Click(object sender, EventArgs e)
        {
            FillListBox(animShelter.GetListOfNonReserved());
        }

=======
        private void btnAssign_Click(object sender, EventArgs e)
        {
            string chipNr = tbChipNr.Text;
            int OwnerId = Convert.ToInt32(tbOwnerID.Text);

            if (animalShelter.reserveAnimal(chipNr, OwnerId))
            {
                MessageBox.Show(String.Format("Animal {0} is assigned successfully to owner {1}", chipNr, OwnerId.ToString()));
            }
            else
            {
                MessageBox.Show("Fail to assign - Check your input again");
            }
        }

        private void btnAnimalOfOwner_Click(object sender, EventArgs e)
        {
            listBoxAnimal.Items.Clear();
            List<Animal> ownerAnimals = new List<Animal>();

            //ownerAnimals = LShelter.GetListOfAnimals();
        }
>>>>>>> 18ab2ea4b81559a5fdc2898c7d40155a74fd5b6e
    }
}
