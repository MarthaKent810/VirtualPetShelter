using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {  
        //declare properties
        public string Name { get; set; }
        public string Description { get; set; }
        public int Hunger { get; set; }
        public int Water { get; set; }
        public int Play { get; set; }

        //constructors
        public VirtualPet()
        {
            //default constructor
        }
        public VirtualPet(string name, string description)
        {
            this.Name = name;
            this.Description = description;
        }

        public VirtualPet(string name, string description, int hunger, int water, int play)
        {
            this.Name = name;
            this.Description = description;
            this.Hunger = hunger;
            this.Water = water;
            this.Play = play;
        }

            //Methods
            //public void Feed()
            //{
            //    Hunger -= 3;
            //}

            //void Thirst()
            //{
            //    Water -= 3;
            //}

            //void Activity()
            //{
            //    Play -= 4;
            //}
        }
    
}
