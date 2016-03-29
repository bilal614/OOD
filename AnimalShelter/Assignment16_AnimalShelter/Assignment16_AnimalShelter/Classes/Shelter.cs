using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_AnimalShelter.Classes
{
    class Shelter
    {
        private string name;
        private int phoneNumber;
        private string address;
        private string email;
        private List<Animal> animalList;
        private List<Owner> ownerList;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }
        public string Email
        {
            get { return email; }
            set { email= value; }
        }
      
        public Shelter (string name)
        {

        }

        public void Backup(string fileName)
        { }

        public bool reservedAnimal(string chipNumber, Owner owner)
        {
            return false;
        }

        public List<Animal> GetListOfNonReserved()
        { 
            List<Animal> nonReserveAnimalList = new List<Animal>();

            foreach(Animal x in animalList)
            {
                if (x.Reserve == false)
                    nonReserveAnimalList.Add(x);
            }
            return nonReserveAnimalList;
        }

        public List<Animal> GetListOfReserved()
        {

        }

        public List<Owner> GetListOfOwners()
        {
            animalList = new List<Animal>();

            foreach(Animal x in animalList)
            {
                if (x.)
            }
        }
    }
}
