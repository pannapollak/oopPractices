using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FridgeManagement
{
    class Fridge
    {
        public List<Food> Foods { get; set; }
        public List<Shelf> Shelves { get; set; }

        public void PlaceFoodOnShelves()
        {
        }

        public void CheckBestBefore()
        {
        }

        static void Main(string[] args)
        {
            Fridge coldie = new Fridge();
            coldie.Build();
            coldie.Run();
            coldie.PrintResult();
        }

        private void Build()
        {
            Foods = new List<Food>()
            {
                new Food("Cucumber", DateTime.Now),
                new Food("Sausage", DateTime.Now),
                new Food("Butter", DateTime.Now)
            };
        }

        private void Run()
        {
            throw new NotImplementedException();
        }

        private void PrintResult()
        {
            throw new NotImplementedException();
        }
    }
}
