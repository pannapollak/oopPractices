namespace ManageWashingMachine
{
    public class PieceOfClothing
    {
        public PieceOfClothing(string color, int weight)
        {
            Color = color;
            Weight = weight;
        }

        public string Name { get; set; }
        public string Color { get; set; }
        public int Weight { get; set; }
    }
}