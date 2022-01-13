namespace ExemploConstrutoresDotNet.models
{
    public class Date
    {
        private int month;
        private bool validMonth;

        public int GetMonth(){return month;}
        public void SetMonth(int month){
            if(month <= 12 && month > 0){this.month = month; this.validMonth = true;}
            else{this.validMonth=false;}
        }
        public void ToIntroduceMonth(){
            if(this.validMonth){System.Console.WriteLine(this.month);}
            else{System.Console.WriteLine("mês invalido");}
        }
        public int Month { 
            get{return this.month;} 
            set{
                if(value > 0 && value <= 12){
                    this.month=value;
                    this.validMonth = true;
                }
                else{this.validMonth = true;}
            } 
        }
    }
}