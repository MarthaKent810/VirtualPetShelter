using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class MiniMoo : VirtualPet
    {
        //declare properties
        public string Food { get; set; }
        public string Type { get; set; }

        //constructors
        public MiniMoo(string food, string type)
        {
            this.Food = food;
            this.Type = type;
        }

    }
}
