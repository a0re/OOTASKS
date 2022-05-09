using System;

namespace Cookie
{
    class Program
    {
        static void Main(string[] args)
        {
            Colour brown = new Colour(101, 67, 33, "brown");
            Colour caramel = new Colour(181, 141, 110, "caramel");
            Cookie c1 = new Cookie(100, "circle", brown);
            Cookie c2 = new Cookie(100, "rectangle", caramel);
            Cookie c3 = new Cookie(100, "semi-circle", brown);
            Cookie c4 = new Cookie(100, "square", caramel);
        }
    }

    public class Cookie
    {
        public int weight;
        public string shape;
        public Colour color;

        public Cookie(int weight, string shape, Colour color)
        {
            this.weight = weight;
            this.shape = shape;
            this.color = color;
        }
    }

    public class Colour
    {
        public int red;
        public int blue;
        public int green;
        public string name;

        public Colour(int red, int blue, int green, string name)
        {
            this.red = red;
            this.blue = blue;
            this.green = green;
            this.name = name;
        }
    }

}
