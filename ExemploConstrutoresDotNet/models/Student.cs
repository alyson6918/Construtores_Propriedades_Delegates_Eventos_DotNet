namespace ExemploConstrutoresDotNet.models
{
    public class Student : Person
    {
        private double note;
        public Student(string name, int age, double note) : base(name, age)
        {
            this.note=note;
        }
        public override void ToIntroduce()
        {
            System.Console.WriteLine($"Olá, meu nome é {this.name} tenho {base.age} e sou uma aluna nota {note}");
        }
    }
}