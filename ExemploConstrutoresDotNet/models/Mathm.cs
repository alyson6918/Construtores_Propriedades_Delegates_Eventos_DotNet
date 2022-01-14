namespace ExemploConstrutoresDotNet.models
{
    public class Mathm
    {
        public int n1 { get; set; }
        public int n2 { get; set; }
        public Mathm(int n1, int n2)
        {
            this.n1 = n1;
            this.n2 = n2;
            Calculator.EventCalculator += EventHandler;
        }
        public void sum(){Calculator.sum(n1, n2);}
        public void EventHandler(){System.Console.WriteLine("metodo executado");}
    }
}