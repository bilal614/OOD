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

            //---default animals and owners added to the shelter class animal list and owner list
            DateTime d1 = new DateTime(2015, 11, 17, 10, 16, 18);
            DateTime d2 = new DateTime(2016, 2, 28, 16, 28, 7);
            DateTime d3 = new DateTime(2016, 4, 8);
            Animal a1 = new Dog("145", d1, "Mastiff", "Kerplein, Eindhoven", d2);
            Animal a2 = new Dog("188", d2, "Jack-Russel", "Talent Square, Tilburg", d2);
            Animal a3 = new Cat("218", d3, "Siamese", "Strijp-S, Eindhoven","scratches furniture");
            
            animalList.Add(a1);
            animalList.Add(a2);
            animalList.Add(a3);

            Owner o1 = new Owner("Bruce Wayne", 111222333, "Wayne Manor");
            Owner o2 = new Owner("Wally West", 101010101, "Central City");
            ownerList.Add(o1);
            ownerList.Add(o2);
        }

        public void Backup(string fileName)
        { }

        public bool reserveAnimal(string chipNumber, int ownerId)
        {
            Owner tempOwner;
            foreach (Owner o in ownerList)
            {
                if (o.OwnerId == ownerId)
                {
                    tempOwner = o;
                }
            }
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

        /// <summary>
        /// For all animals whose reserve value is true, which means that the animals are not open for
        /// reservation meaning that they are reserved by someone.
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetListOfReserved()
        {
            List<Animal> temp = new List<Animal>();
            foreach (Animal a in animalList)
            {
                if (a.Reserve)
                {
                    temp.Add(a);
                }
            }
            return temp;
        }

        public List<Owner> GetListOfOwners()
        {
            return ownerList;
        }
    }
}
