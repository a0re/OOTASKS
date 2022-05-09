namespace Cookie
{
    public class Cookie
    {
        public int Weight { get; set; }
        public string Shape { get; set; }
        public Colour Color { get; set; }

        public Cookie(int weight, string shape, Colour color)
        {
            this.Weight = weight;
            this.Shape = shape;
            this.Color = color;
        }

    }

}
