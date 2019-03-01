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
            wash.Run();
        }

        private void Build()
        {
            Clothes = new List<PieceOfClothing>
            {
            }
        }

        private void Run()
        {
            throw new NotImplementedException();
        }
    }
}
