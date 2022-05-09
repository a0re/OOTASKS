namespace Cookie
{
    public class Colour
    {
        public int Red { get; set; }
        public int Blue { get; set; }
        public int Green { get; set; }
        public string Name { get; set; }

        public Colour(int red, int blue, int green, string name)
        {
            this.Red = red;
            this.Blue = blue;
            this.Green = green;
            this.Name = name;
        }
    }

}
