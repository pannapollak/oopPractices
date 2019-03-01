using System;

namespace FridgeManagement
{
    public class Food
    {
        public Food(string name, DateTime bestBefore)
        {
            Name = name;
            BestBefore = bestBefore;
        }

        public string Name { get; set; }
        public DateTime BestBefore { get; set; }

    }
}