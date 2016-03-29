using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_AnimalShelter.Classes
{
    public class Owner
    {
        private string name;
        private int phoneNumber;
        private string address;
        private static int idCounter = 0;
        private int ownerId;

        public string Name
        {
            get {return name;}
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
        public int OwnerId
        {
            get { return ownerId; }
            set { ownerId = value; }
        }

        public Owner(string Name, int PhoneNumber, string Address)
        {
            this.Name = Name;
            this.PhoneNumber = PhoneNumber;
            this.Address = Address;
            this.OwnerId = idCounter++;
        }

        public string AsString()
        {
            return "Owner's ID: "+ this.OwnerId + " Owner's name: " + this.Name + 
                "Address: " + this.Address + " Phone: "+ this.PhoneNumber;
        }
    }
}
