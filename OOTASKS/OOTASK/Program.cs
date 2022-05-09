using System;

namespace OOTASK
{
    class Program
    {
        static void Main(string[] args)
        {

            Person person1 = new Person("Dhanveer", "Ramnauth", "16th June 2003", 185);
            Person person2 = new Person("Anh", "Nguyen", "1st April 1955", 100);
            Person person3 = new Person("qwerty", "qwerty", "2nd March 2001", 174);

            Console.WriteLine(person1.GetHeightDifference(person2));
        }
    }
}
