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
        private int hunger;
        private int thirst;
        private int feeding;
        private int watering;
        private int orneriness;

        //Properties == Mama bear get/set.......get allows us to see the value...set allows us to assign the value...pascal
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
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
        public int Orneriness
        {
            get { return this.orneriness; }
            set { this.orneriness = value; }
        }

        //Constructors
        public VirtualPet()
        {

        }
        public VirtualPet(string name, int hunger, int thirst, int feeding, int watering, int orneriness)
        {
            this.name = name;
            this.hunger = hunger;
            this.thirst = thirst;
            this.feeding = feeding;
            this.watering = watering;


        }
        //Methods()
        //at least three
        //one must be tick








    }
}
