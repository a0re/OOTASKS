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
}
