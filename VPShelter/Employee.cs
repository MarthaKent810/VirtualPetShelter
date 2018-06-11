using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        public string EmpID { get; set; }

        public abstract string CheckIn();

        public abstract string Duties();

        
    }
}
