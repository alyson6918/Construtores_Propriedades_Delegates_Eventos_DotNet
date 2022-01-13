namespace ExemploConstrutoresDotNet.models
{
    public class Date
    {
        private int month;
        private bool valideMonth;

        public int GetMonth(){return month;}
        public void SetMonth(int month){
            if(month <= 12 && month > 0){this.month = month; this.valideMonth = true;}
            else{this.valideMonth=false;}
        }
        public void ToIntroduceMonth(){
            if(this.valideMonth){System.Console.WriteLine(this.month);}
            else{System.Console.WriteLine("mês invalido");}
        }
    }
}