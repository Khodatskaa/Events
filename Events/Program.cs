namespace Events
{
    public class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
    }

    public static class PersonExtensions
    {
        public static double AverageAge(this Person[] persons)
        {
            if (persons.Length == 0)
                return 0;
            double sum = 0;
            foreach (var person in persons)
            {
                sum += person.Age;
            }
            return sum / persons.Length;
        }
    }

    public class Program
    {
        static void Main()
        {
            Person[] persons = new Person[]
            {
                new Person { Name = "John", Surname = "Doe", Age = 25 },
                new Person { Name = "Jane", Surname = "Doe", Age = 30 },
                new Person { Name = "Alice", Surname = "Smith", Age = 20 },
                new Person { Name = "Bob", Surname = "Johnson", Age = 35 }
            };

            var minAgePerson = persons.OrderBy(p => p.Age).First();
            var maxAgePerson = persons.OrderByDescending(p => p.Age).First();

            double averageAge = persons.AverageAge();

            Console.WriteLine($"Person with minimum age: {minAgePerson.Name} {minAgePerson.Surname}, Age: {minAgePerson.Age}");
            Console.WriteLine($"Person with maximum age: {maxAgePerson.Name} {maxAgePerson.Surname}, Age: {maxAgePerson.Age}");
            Console.WriteLine($"Average age: {averageAge}");
        }
    }
}
