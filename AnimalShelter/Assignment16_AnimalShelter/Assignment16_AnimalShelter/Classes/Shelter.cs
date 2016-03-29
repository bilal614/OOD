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
      
        /// <summary>
        /// The shelter constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="address"></param>
        /// <param name="email"></param>
        public Shelter (string name, int phoneNumber, string address, string email)
        {
            this.Name = name;
            this.PhoneNumber = phoneNumber;
            this.Address = address;
            this.Email = email;
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
