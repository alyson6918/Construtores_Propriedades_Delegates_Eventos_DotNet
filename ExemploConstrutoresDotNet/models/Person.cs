namespace ExemploConstrutoresDotNet.models
{
    public class Person
    {
        private string? name;
        private int? age;
        public Person()
        {
            name = string.Empty;
            age = null;
        }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public void ToIntroduce(){System.Console.WriteLine($"Olá, meu nome é {name} e tenho {age}");}
    }
}