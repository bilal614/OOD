using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_AnimalShelter.Classes
{
    class Dog : Animal
    {
        private DateTime lastWalkDate;

        public Dog(string chipNumber, DateTime entryDate, string pedigree, string foundLocation, DateTime lastWalk)
            :base(chipNumber,entryDate,pedigree,foundLocation)
        {
            this.lastWalkDate = lastWalk;
        }

        public override int setPrice()
        {
            return 20 + 2 * this.getDays();
        }

        public override string AsString()
        {
            return base.AsString() + string.Format("\n Last walk date: {0}",lastWalkDate.ToString());
        }

        public DateTime getLastWalkDate()
        {
            return lastWalkDate;
        }
        public void setLastWalkDate(DateTime lastWalk)
        {
            this.lastWalkDate = lastWalk;
        }
    }
}
