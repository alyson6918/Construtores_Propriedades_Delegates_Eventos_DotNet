namespace ExemploConstrutoresDotNet.models
{
    public class Person
    {
        protected readonly string? name;
        protected readonly int? age;
        // public Person()
        // {
        //     name = string.Empty;
        //     age = null;
        // }
        public Person(String name, int age)
        {
            this.name = name;
            this.age = age;
        }
        public virtual void ToIntroduce(){System.Console.WriteLine($"Olá, meu nome é {name} e tenho {age}");}
    }
}