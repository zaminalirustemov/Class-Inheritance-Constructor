namespace ConsoleApp2
{
    internal class Student : Human
    {
        public Student()
        {

        }
        public Student(string name): base(name)
        {

        }
        public Student(string name,string surname): base(name,surname)
        {

        }

        public Student(string name, string surname, byte age): base(name,surname,age)
        {

        }

        public Student(string name, string surname, byte age, double point) : this(name, surname, age)
        {
            this.Point = point;
        }

        public double Point;

        public void ShowFullData()
        {
            Console.WriteLine($"{this.Name} {this.Surname} {this.Age} {this.Point}");
        }
        public string GettFullName()
        {
            return $"{this.Name} {this.Surname}";
        }
    }
}
