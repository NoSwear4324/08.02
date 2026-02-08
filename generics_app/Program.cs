using System.Collections.Generic;

namespace generics_app
{
    public class Person<T>
    {
        public T Id { get; set; }
        public string? Name { get; set; }

        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Name: {Name}";
        }
    }
    
    public class Program
    {
        static void Main(string[] args)
        {
            Person<int> person = new Person<int>(3, "Alex");
            Console.WriteLine(person);
            Console.ReadKey();
        }
    }
    
}