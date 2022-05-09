namespace OOTASK
{
    public class Subject
    {
        public string Name { get; set; }
        public string YearOfDelivery { get; set; }

        public Subject(string Name, string YearOfDelivery)
        {
            this.Name = Name;
            this.YearOfDelivery = Name;
        }
    }
}
