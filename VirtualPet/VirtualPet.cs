using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualPet
{
    class VirtualPet
    {
        //fields == baby bears
        private int hunger;
        private int thirst;
        private int feeding;
        private int watering;


        //Properties == Mama bear get/set.......get allows us to see the value...set allows us to assign the value...pascal
        public int Hunger
        {
            get { return this.hunger; }
            set { this.hunger = value; }
        }
        public int Thirst
        {
            get { return this.thirst; }
            set { this.thirst = value; }
        }
        public int Feeding
        {
            get { return this.feeding; }
            set { this.feeding = value; }
        }
        public int Watering
        {
            get { return this.watering; }
            set { this.watering = value; }
        }
        public void AddFood(int foodAdded)
        {
            hunger += foodAdded;
        }
        public void AddWater(int waterAdded)
        {
            hunger += waterAdded;
        }

        //Constructors
        public VirtualPet()
        {

        }
        public VirtualPet(int hunger, int thirst, int feeding, int watering)
        {
            
            this.hunger = hunger;
            this.thirst = thirst;
            this.feeding = feeding;
            this.watering = watering;
            

        }
        //Methods()
        //at least three
        //one must be tick
        public string Eat()
        {
            if (hunger >= 8)
            {
                return "Pet doesn't need fed!";
            }
            else if (hunger > 4)
            {
                return "getting hungry";
            }
            else
            {
                return "time to feed the beast!";
            }
        }

        public void Tick()
        {

        }
        public string Drink()
        {
            if (thirst >= 8)
            {
                return "Pet doesn't need water!";
            }
            else if (thirst > 4)
            {
                return "getting thirsty";
            }
            else
            {
                return "Wee beastie needs water!";
            }
        }





    }
}
