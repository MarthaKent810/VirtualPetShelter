using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Volunteer : Employee

    {
        //declare properties
        public string HrsAvail { get; set; }
        public int Hunger { get; set; }
        public int Water { get; set; }
        public int Play { get; set; }

        //declare methods
       
        public override string CheckIn()
        {
            string numb = "Please sign the volunteer log book";
            return numb;
        }


        public override string Duties()

        {
            throw new NotImplementedException();
        }
            //Methods
            public void Feed()
            {
                Hunger -= 3;
            }

             public void Thirst()
            {
                Water -= 3;
            }

             public void Activity()
            {
                Play -= 4;
            }
        

    }
}
