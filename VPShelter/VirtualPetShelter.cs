using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class VirtualPetShelter

    {
        //declare properties
        public string Pets { get; set; }
        public string EmpName { get; set; }

        //constructors
        public VirtualPetShelter()
        {
            //default constructor
        }
        public VirtualPetShelter(string pets, string empName)
        {
            this.Pets = pets;
            this.EmpName = empName;
        }

        //make list
        public List<VirtualPet> listPets = new List<VirtualPet>();

        public List<Employee> listEmp = new List<Employee>();

        public void AddPet(VirtualPet pest)
        {
            listPets.Add(pest);
        }

        public List<VirtualPet> GetPet()
        {
            return this.listPets;
        }

        public void AddEmployee(Employee employee)
        {
            listEmp.Add(employee);
        }

        public  List<Employee> GetEmp()
        {
            return listEmp;
        }
       
        
    }

}
