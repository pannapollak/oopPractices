using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWashingMachine
{
    class WashingMachine
    {
        public int WeightCounter = 0;
        public List<PieceOfClothing> Clothes { get; set; }
        public List<PieceOfClothing> CurrentLoad { get; set; }

        public void CheckWeight(PieceOfClothing cloth)
        {
            if (cloth.Weight + WeightCounter <= 5000)
            {
                CurrentLoad.Add(cloth);
                WeightCounter += cloth.Weight;
            }
        }

        static void Main(string[] args)
        {
            WashingMachine wash = new WashingMachine();
            wash.Build();
            wash.Run("dark");
            wash.PrintResult();
        }


        private void Build()
        {
            Clothes = new List<PieceOfClothing>
            {
                new PieceOfClothing("Jumper", "light", 550),
                new PieceOfClothing("Jumper", "dark", 650),
                new PieceOfClothing("Leggings", "white", 250),
                new PieceOfClothing("T-shirt", "red", 100),
                new PieceOfClothing("Jeans", "dark", 500),
                new PieceOfClothing("Trousers", "dark", 800),
                new PieceOfClothing("T-shirt", "dark", 300),
                new PieceOfClothing("Leggings", "dark", 250),
                new PieceOfClothing("Jeans", "dark", 750)
            };

            CurrentLoad = new List<PieceOfClothing>();

        }

        private void Run(string currentColor)
        {
            foreach (var cloth in Clothes)
            {
                if (cloth.Color == currentColor && WeightCounter < 5000)
                {
                    CheckWeight(cloth);
                }
                 
            }
            
        }

        private void PrintResult()
        {
            if (WeightCounter >= 2000)
            {
                foreach (var gettingCleanPieceOfClothing in CurrentLoad)
                {
                    Console.WriteLine(gettingCleanPieceOfClothing);
                }
            }
            else
            {
                double currentWeight = (double)WeightCounter / (double)1000;
                Console.WriteLine($"Current load is {currentWeight} kg. Not enough dirty clothes for the load.");
            }
        }
    }
}
