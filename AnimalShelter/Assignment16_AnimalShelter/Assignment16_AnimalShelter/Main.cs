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
    public partial class Main : Form
    {
        public Shelter animalShelter;

        //public Shelter AnimalShelter { get { return animalShelter; } }

        public Main()
        {
            InitializeComponent();
            animalShelter = new Shelter("Eindhoven Animal Shelter", 999000999, "Fontys, Eindhoven", "example@example.com");
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            Form addform = new AddAnimal(animalShelter);
            
            addform.Show();
        }

        private void btnAssignAnimal_Click(object sender, EventArgs e)
        {
            Form assignForm = new AssignAnimalToOwner(animalShelter);
            assignForm.Show();
        }

    }
}
