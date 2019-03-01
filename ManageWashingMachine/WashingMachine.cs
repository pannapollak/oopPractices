using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageWashingMachine
{
    class WashingMachine
    {
        
        public List<PieceOfClothing> Clothes { get; set; }
        public List<PieceOfClothing> CurrentLoad { get; set; }

        public void CheckWeight(PieceOfClothing cloth, int weightCounter)
        {
            if (cloth.Weight + weightCounter <= 5000)
            {
                CurrentLoad.Add(cloth);
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
                new PieceOfClothing("Jumper", "light", 500),
                new PieceOfClothing("Jumper", "dark", 300),
                new PieceOfClothing("Leggings", "white", 150),
                new PieceOfClothing("T-shirt", "red", 100),
                new PieceOfClothing("Jeans", "dark", 500),
                new PieceOfClothing("Trousers", "dark", 400)
            };

            CurrentLoad = new List<PieceOfClothing>();

        }

        private void Run(string currentColor)
        {
            int weightCounter = 0;
            foreach (var cloth in Clothes)
            {
                if (cloth.Color == currentColor && weightCounter < 5000)
                {
                    CheckWeight(cloth, weightCounter);
                }
                 
            }
        }

        private void PrintResult()
        {
            foreach (var gettingCleanPieceOfClothing in CurrentLoad)
            {
                Console.WriteLine(gettingCleanPieceOfClothing);
            }
        }
    }
}
