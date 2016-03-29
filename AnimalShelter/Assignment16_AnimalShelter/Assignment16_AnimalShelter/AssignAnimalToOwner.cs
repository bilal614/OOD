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
        Shelter LShelter = new Shelter("LoopIT", 268809, "I don't know", "loopITemail@gmail.com");
        public AssignAnimalToOwner()
        {
            InitializeComponent();
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            string chipNr = tbChipNr.Text;
            int OwnerId = Convert.ToInt32(tbOwnerID.Text);

            if(LShelter.reserveAnimal(chipNr,OwnerId))
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
    }
}
