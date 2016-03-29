using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_AnimalShelter.Classes
{
    class Cat : Animal
    {
        private string habit;

        public Cat(string chipNumber, DateTime entryDate, string pedigree, string foundLocation, string habit)
            :base(chipNumber,entryDate,pedigree,foundLocation)
        {
            this.habit = habit;
        }

        public override int setPrice()
        {
            return 20;
        }

        public override string AsString()
        {
            return base.AsString() + string.Format("\n Habit: {0}", this.habit);
        }

    }
}
