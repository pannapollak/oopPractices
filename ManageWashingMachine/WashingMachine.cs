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

        public bool CheckColor()
        {

            return true;
        }

        public void CheckWeight()
        {
        }

        static void Main(string[] args)
        {
            WashingMachine wash = new WashingMachine();
            wash.Build();
            wash.Run("Dark");
        }

        private void Build()
        {
            Clothes = new List<PieceOfClothing>
            {
                new Trouser("light", 500),
                new Jumper("dark", 300),
                new TShirt("white", 150),
                new TShirt("red", 100),
                new Trouser("dark", 500),
                new Jumper("dark", 400)
            };
        }

        private void Run(string color)
        {
            foreach (var cloth in Clothes)
            {
                if (cloth.Color == color)
                {
                    if (CheckColor()) CheckWeight();
                }
                 
            }
        }
    }
}
