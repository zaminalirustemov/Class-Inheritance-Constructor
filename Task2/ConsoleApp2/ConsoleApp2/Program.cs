using System.Runtime.CompilerServices;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Human human=new Human("Zaminali", "Rustamov", 19);
             
            
            
            human.ShowFullData();
            Console.WriteLine(human.GettFullName());
        }
    }
}