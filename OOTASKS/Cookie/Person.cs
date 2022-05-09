using System;


namespace Cookie
{
    public class Person
    {
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Dob { get; set; }
        public int Height { get; set; }
        public int ID { get; set; }

        public Person(string FirstName, string Surname, string Dob, int Height)
        {
            this.FirstName = FirstName;
            this.Surname = Surname;
            this.Dob = Dob;
            this.Height = Height;
            ID = Random = rnd.Next(1000, 9999);
        }
        public string GetFullName()
        {
            return $"{FirstName} {Surname}";
            
        }
        public int GetHeightDifference(Person other)
        {
            return Math.Abs(Height - other.Height);
        }
    }
}
