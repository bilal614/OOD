﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment16_AnimalShelter.Classes
{
    abstract class Animal
    {

        private string chipNumber;
        private int price;
        private DateTime entryDate;
        private int days;
        private string pedigree;
        private string foundLocation;
        private bool reserve;

        public string ChipNumber
        {
            get
            {
                return chipNumber;
            }
            set
            {
                chipNumber = value;
            }
        }

        public bool Reserve
        {
            get { return reserve; }
        }
        /// <summary>
        /// The constructor of animal class
        /// </summary>
        /// <param name="chipNumber"></param>
        /// <param name="entryDate"></param>
        /// <param name="pedigree"></param>
        /// <param name="foundLocation"></param>
        public Animal(string chipNumber, DateTime entryDate, string pedigree, string foundLocation)
        {
            this.chipNumber = chipNumber; //Should be automatic assign in Shelter class when the addAnimal method is called
            this.entryDate = entryDate;
            this.pedigree = pedigree;
            this.foundLocation = foundLocation;

            //Set default for properties can be updated be methods latter on
            this.price = 0;
            this.days = 0;
            this.reserve = false; // has not been assigned to any owner yet
            this.animalOwner = null; // has not been assigned to any owner yet

        }

        public Animal(int p1, DateTime d1, string p2, string p3)
        {
            // TODO: Complete member initialization
            this.p1 = p1;
            this.d1 = d1;
            this.p2 = p2;
            this.p3 = p3;
        }

        /// <summary>
        /// Method return the string contains all information about the animals
        /// </summary>
        /// <returns></returns>
        public virtual string AsString()
        {
            return String.Format("Animal's infor: Chip number: {0}, Entry date: {1}, Pedigree: {2}, Found Location: {3}, Price: {4}, The number of days in shelter: {5}, Revered: {6}, Owner: {7}"
                , this.ChipNumber, this.entryDate.ToString(), this.pedigree, this.pedigree, this.foundLocation, this.price.ToString(), this.days, this.reserve, this.animalOwner.AsString());//animalOwner.AsString();
        }

        /// <summary>
        /// Method return the current Owner of this animal. Return null if the animal has not assigned yet.
        /// </summary>
        /// <returns></returns>
        public Owner getOwner()
        {
            return animalOwner;
        }

        /// <summary>
        /// Return the number of days this animal stays in the shetler
        /// </summary>
        /// <returns></returns>
        public int setDays()
        {
            return (DateTime.Now - this.entryDate).Days;
        }

        public int getDays()
        {
            return days;
        }

        public abstract int setPrice();
        public int getPrice()
        {
            return this.price;
        }
        /// <summary>
        /// Assign this animal to the owner given from the parametter
        /// </summary>
        /// <param name="owner"></param>
        /// <returns></returns>
        public bool assignOwner(Owner owner)
        {
            if(this.reserve == false && this.animalOwner == null)
            {
                animalOwner = owner;
                return true;
            }
            return false;
        }

    }
}
