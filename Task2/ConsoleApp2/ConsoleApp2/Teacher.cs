namespace ConsoleApp2
{
    internal class Teacher : Human
    {
        public Teacher()
        {

        }
        public Teacher(string name) : base(name)
        {

        }
        public Teacher(string name, string surname) : base(name, surname)
        {

        }

        public Teacher(string name, string surname, byte age) : base(name, surname, age)
        {

        }
        public Teacher(string name, string surname, byte age, string profession) : this(name, surname, age)
        {
            this.Profession = profession;
        }
        public Teacher(string name, string surname, byte age, string profession, double experience) : this(name, surname, age, profession)
        {
            this.Experience = experience;
        }

        public string Profession;
        public double Experience;

        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Profession} {this.Experience}");
        }
        public string GettFullName()
        {
            return $"{this.Name} {this.Surname}";
        }
    }
}
