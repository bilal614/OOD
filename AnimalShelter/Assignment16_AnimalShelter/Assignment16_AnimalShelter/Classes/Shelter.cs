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
        private List<Animal> animalList = new List<Animal>();
        private List<Owner> ownerList = new List<Owner>();

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
            Animal a1 = new Dog("A10000", d1, "Mastiff", "Kerplein, Eindhoven", d2);
            Animal a2 = new Dog("A10001", d2, "Jack-Russel", "Talent Square, Tilburg", d2);
            Animal a3 = new Cat("A10002", d3, "Siamese", "Strijp-S, Eindhoven","scratches furniture");
            
            animalList.Add(a1);
            animalList.Add(a2);
            animalList.Add(a3);

            Owner o1 = new Owner("Bruce Wayne", 111222333, "Wayne Manor");
            Owner o2 = new Owner("Wally West", 101010101, "Central City");
            ownerList.Add(o1);
            ownerList.Add(o2);
        }

        public void Backup(string fileName)
        { 
        }

        public bool reserveAnimal(string chipNumber, int ownerId)
        {
            Animal tempAnimal = null;
            Owner tempOwner = null;
            foreach (Owner o in ownerList)
            {
                if (o.OwnerId == ownerId)
                {
                    tempOwner = o;
                }
            }

            tempAnimal = FindAnimal(chipNumber);
            bool ok = tempAnimal.assignOwner(tempOwner);
            if (ok)
            {
                return true;
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

        /// <summary>
        /// Gets a list of all the dogs that have not been walked for more than 24 hours.
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetListOfNotWalkingDog()
        {
            DateTime comparison = DateTime.Now;
            List<Animal> tempList = new List<Animal>();
            for (int i = 0; i < animalList.Count; i++)
            {
                if (animalList[i] is Dog)
                {
                    animalList[i] = (Dog)animalList[i];
                }
            }

                return tempList;
        }

        public Animal FindAnimal(string chipNr)
        {
            Animal temp = null;
            foreach (Animal a in animalList)
            {
                if (a.ChipNumber == chipNr)
                {
                    temp = a;
                }
            }
            return temp;
        }

        /// <summary>
        /// This method adds an Animal to the list of Animals in the shelter. This will be an overloaded method and will allow to add a dog
        /// or a cat to the shelter in which case the parameters of the method would be different according to the type of Animal.
        /// </summary>
        /// <param name="chipNr"></param>
        /// <param name="entryDate"></param>
        /// <param name="pedigree"></param>
        /// <param name="foundLocation"></param>
        /// <param name="dogOrCat"></param>
        /// <returns></returns>
        public bool AddAnimal(String chipNr, DateTime entryDate, String pedigree, String foundLocation, DateTime lastWalkDate)
        {
            bool added = false;
            Animal temp = FindAnimal(chipNr);
            if (temp == null)
            {
                Animal a = new Dog(chipNr, entryDate, pedigree, foundLocation, lastWalkDate);
                animalList.Add(a);
                added = true;
            }
            return added;
        }

        /// <summary>
        /// This method adds an Animal to the list of Animals in the shelter. This will be an overloaded method and will allow to add a dog
        /// or a cat to the shelter in which case the parameters of the method would be different according to the type of Animal --Thanh
        /// </summary>
        /// <param name="animal"></param>
        /// <returns></returns>
        public bool AddAnimal(Animal animal)
        {
            bool added = false;
            string chipNr = animal.ChipNumber;
            Animal temp = FindAnimal(chipNr);
            if (temp == null)
            {
                animalList.Add(animal);
                added = true;
            }
            return added;
        }

        public bool RemoveAnimal(String chipNmbr)
        {
            bool removed = false;
            Animal a = FindAnimal(chipNmbr);
            if (a != null)
            {
                animalList.Remove(a);
                removed = true;
            }

            return removed;
        }

        /// <summary>
        /// Auto-generated the ChipNr - only for the purpose of doing this assignment 
        /// Further implementation is done by RFID-chips
        /// </summary>
        /// <returns></returns>
        public string CreateChipNr()
        {
            string ChipNr = animalList[animalList.Count - 1].ChipNumber;
            string numberPart = ChipNr.Substring(1);
            int newNrPart = Convert.ToInt32(numberPart) + 1;
            newNrPart++;
            return 'A' + newNrPart.ToString();
        }

        /// <summary>
        /// Return the list of all animals in the shelter
        /// </summary>
        /// <returns></returns>
        public List<Animal> GetListOfAnimals()
        {
            return this.animalList;
        }

        public List<Animal> GetListOfAnimals(Owner owner)
        {
            List<Animal> assignedAnimals = GetListOfReserved();
            List<Animal> ownerAnimals = new List<Animal>();
            foreach(var a in assignedAnimals)
            {
                if(a.getOwner().OwnerId == owner.OwnerId)
                {
                    ownerAnimals.Add(a);
                }
            }
            if(ownerAnimals.Count == 0)
            {
                return null;
            }
            else
            {
                return ownerAnimals;
            }
        }
    }
}
