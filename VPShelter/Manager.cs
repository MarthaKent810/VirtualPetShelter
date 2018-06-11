using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Manager : Employee

    {
        public string EmpID { get; set; }

        public Manager()
        {
        }
        public Manager(string empID)
        {
            this.EmpID = empID;
        }

        public string Adopt()
        {
            string home = "You gave a pet a furever home! Thank you!";
            return home;
        }

        public override string CheckIn()
        {
            string numb = "Please swipe your ID card";
            return numb;
        }

        public override string Duties()
        {
            throw new NotImplementedException();
        }
    }
}
