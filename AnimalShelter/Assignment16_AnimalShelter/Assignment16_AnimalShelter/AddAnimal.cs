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
<<<<<<< HEAD

=======
>>>>>>> 488223cfb69d73208b281b5291d26df63169330a
namespace Assignment16_AnimalShelter
{
    public partial class AddAnimal : Form
    {
        //Variables
        Shelter LShelter = new Shelter("LoopIT", 268809, "I don't know", "loopITemail@gmail.com");
        
        public AddAnimal()
        {
            InitializeComponent();
        }

        private void btnAddAnimal_Click(object sender, EventArgs e)
        {
            DateTime entryDate = dateTimePickerEntryDate.Value;
            string locationFound = tbLocataion.Text;
            string pedegree = tbPedigree.Text;
            if(radioCat.Checked)
            {
                string habit = tbHabit.Text;
                Cat cat = new Cat(LShelter.CreateChipNr(), entryDate, pedegree, locationFound, habit);
                if (LShelter.AddAnimal(cat))
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

            }

        }
    }
}
