namespace ManageWashingMachine
{
    public class PieceOfClothing
    {
        public PieceOfClothing(string name, string color, int weight)
        {
            Name = name;
            Color = color;
            Weight = weight;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }

        public override string ToString()
        {
            return $"This {Name} is getting clean.";
        }
    }
}