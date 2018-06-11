using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Program
    {


        static void Main(string[] args)
        {
            //Instantiate new shelter & new virtual pets
            VirtualPetShelter shelter = new VirtualPetShelter();
            VirtualPet fidget = new VirtualPet("Fidget", "mini-moo", 67, 22, 54);
            VirtualPet tito = new VirtualPet("Tito  ", "minotaur", 73, 45, 87);
            VirtualPet pinky = new VirtualPet("Pinky ", "unicorn", 79, 68, 94);

            // add pets to list
            shelter.AddPet(tito);
            shelter.AddPet(fidget);
            shelter.AddPet(pinky);
            List<VirtualPet> pets = shelter.GetPet();

            //volunteer options
            Console.WriteLine("Hello! Welcome to the Virtual Pet Shelter. Type 1 for manager or 2 for volunteer");
            int userSel = int.Parse(Console.ReadLine());

            if (userSel == 2)
            {
                Console.WriteLine("Thanks for coming in to volunteer today");
                Volunteer sign = new Volunteer();
                Console.WriteLine(sign.CheckIn());
                Console.WriteLine("Current Pet Status");
                Console.WriteLine(" ");

                Console.WriteLine("Name       |Hunger    |Thirst   |Boredom");
                Console.WriteLine("____________________________________________");

                // print out table with status
                foreach (VirtualPet pet in pets)
                {
                    Console.WriteLine(pet.Name + "     | " + pet.Hunger + "       | " + pet.Water + "      | " + pet.Play);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Type yes if you would like to take care of the pets now");
                string userAns = Console.ReadLine().ToLower();

                while (userAns.Equals("yes"))
                {
                    Console.WriteLine("What do you want to do?");
                    Console.WriteLine("");
                    Console.WriteLine("1 Feed the Pets");
                    Console.WriteLine("2 Water the Pets");
                    Console.WriteLine("3 Play with the Pets");
                    Console.WriteLine("4 Quit");
                    int userResp = int.Parse(Console.ReadLine());

                    switch (userResp)
                    {
                        case 1:
                            Volunteer hungry = new Volunteer();
                           hungry.Feed();
                            Console.WriteLine("The pets have been fed.");
                            break;
                        case 2:
                            Volunteer thirsty = new Volunteer();
                            thirsty.Thirst();
                            Console.WriteLine("The pets have been watered");
                            break;
                        case 3:
                            Volunteer fetch = new Volunteer();
                            fetch.Activity();
                            Console.WriteLine("Which pet would you like to play with?");
                            foreach (VirtualPet pet in pets)
                            Console.WriteLine(pet.Name);
                            string choice = Console.ReadLine().ToLower();
                            Console.WriteLine("You have played with  " + choice);
                            break;

                        case 4:
                            userAns = "test";
                            break;

                        default:
                            break;
                    }
                }
               
            }

            //manager options
            if (userSel == 1)
            {
                // print out table with status
                Console.WriteLine("Current Pet Status");
                Console.WriteLine(" ");
                Console.WriteLine("Name       |Hunger    |Thirst   |Boredom");
                Console.WriteLine("____________________________________________");

                foreach (VirtualPet pet in pets)
                {
                    Console.WriteLine(pet.Name + "     | " + pet.Hunger + "       | " + pet.Water + "      | " + pet.Play);
                    Console.WriteLine(" ");
                }
                Console.WriteLine("Type yes to do some work");
                string userAns = Console.ReadLine().ToLower();

                while (userAns.Equals("yes"))
                {

                Console.WriteLine("");
                Console.WriteLine("1 Play with the Pets");
                Console.WriteLine("2 Adopt out a Pet");
                Console.WriteLine("3 Sign in");
                Console.WriteLine("4 Quit");
                int userResp = int.Parse(Console.ReadLine());

                switch (userResp)
                {
                    case 1:
                    Console.WriteLine("Which pet would you like to play with?");
                    foreach (VirtualPet pet in pets)
                    Console.WriteLine(pet.Name);
                    string choice = Console.ReadLine().ToLower();
                    Console.WriteLine("You have played with  " + choice);
                    break;

                    case 2:
                        Console.WriteLine("Which pet is going to be adopted?");
                        foreach (VirtualPet pet in pets)
                        Console.WriteLine(pet.Name + "      " + pet.Description);
                        string adoptee = Console.ReadLine().ToLower();
                        Manager newHome = new Manager();
                        Console.WriteLine(newHome.Adopt());
                        break;

                    case 3:
                            Manager swipe = new Manager();
                            Console.WriteLine(swipe.CheckIn());
                            break;

                    case 4:
                            userAns = "test";
                            break;

                    }
                }
                                   
                Console.WriteLine("Quit");
                               

            }
        }
    }
}

