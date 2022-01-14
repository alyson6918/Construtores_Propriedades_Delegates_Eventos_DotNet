namespace ExemploConstrutoresDotNet.models
{
    public class Calculator
    {
        public delegate void delegateCalculator();
        public static event delegateCalculator? EventCalculator;
        public static void sum(int n1, int n2){
            if (EventCalculator != null){
                System.Console.WriteLine($"valor da soma {n1} + {n2} = {n1 + n2}");
                EventCalculator();
            }
            else{System.Console.WriteLine("nenhum subscrito");}
        }
        public static void sub(int n1, int n2){System.Console.WriteLine($"valor da subtração {n1} - {n2} = {n1 - n2}");}
        public static void mult(int n1, int n2){System.Console.WriteLine($"valor da multiplicação {n1} * {n2} = {n1 * n2}");}
        public static void div(int n1, int n2){System.Console.WriteLine($"valor da divisão {n1} / {n2} = {n1 / n2}");}
    }
}