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
        private Main main;
        Shelter animShelter;

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

        private void button1_Click(object sender, EventArgs e)
        {
            FillListBox(animShelter.GetListOfNonReserved());
        }

    }
}
