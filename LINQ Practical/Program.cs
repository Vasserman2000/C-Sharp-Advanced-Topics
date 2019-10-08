using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_Practical
{
    class Program
    {
        static void Main(string[] args)
        {
            PetOwner[] petOwners = {
                new PetOwner { Name="Higa",
                    Pets = new List<string>{ "Scruffy", "Sam" } },
                new PetOwner { Name="Ashkenazi",
                    Pets = new List<string>{ "Walker", "Sugar" } },
                new PetOwner { Name="Price",
                    Pets = new List<string>{ "Scratches", "Diesel" } },
                new PetOwner { Name="Hines",
                    Pets = new List<string>{ "Dusty" } } };

            var query = petOwners
                            .SelectMany(petOwner => petOwner.Pets, (Owner, Pet) => new { Owner.Name, Pet})
                            .Select(OwnerAndPet => 
                                    new
                                    {
                                        Owner = OwnerAndPet.Name,
                                        OwnerAndPet.Pet
                                    }
                           );
        }
    }
    class PetOwner
    {
        public string Name { get; set; }
        public List<string> Pets { get; set; }
    }
}
