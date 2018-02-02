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
        private string name;
        private bool hunger = false;
        private bool thirst = false;
        private int feeding;
        private int watering;
        private int orneriness;

        //Properties == Mama bear get/set.......get allows us to see the value...set allows us to assign the value...pascal
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
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
        public int Orneriness
        {
            get { return this.orneriness; }
            set { this.orneriness = value; }
        }

        //Constructors
        public VirtualPet()
        {

        }
        public VirtualPet(string name, bool hunger, bool thirst, int feeding, int watering, int orneriness)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.feeding = feeding;
            this.watering = watering;
            this.orneriness = orneriness;

        }
        //Methods()
        //at least three
        //one must be tick
        public string Eat()
        {
            if (hunger)
            {
                hunger = true;
                return "Hey," + this.name + " needs fed.";
            }
            else
            {
                return this.name + " is already fed. Go have a beer.";
            }
        }

        public void Tick()
        {

        }
        public string Drink()
        {
            if (thirst)
            {
                thirst = true;
                return "Hey," + this.name + " needs water.";
            }
            else
            {
                return this.name + " is already has water. Go have a beer.";
            }
        }





    }
}
