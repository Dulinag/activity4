using System;
namespace MyNamespace {


    public class Number {
        public int value;
    
    };

    public class Counter
    {
        public event NumberValidator Assigned;

        protected virtual void OnAssigned()
        {
            if(NumberValidator !=null) {
                NumberValidator(this,null);
            }
        }

    }

    public class AppService
    {
        public void CorrecctAssign(int value)
        {
            console.WriteLine("App Service: Dulina Your number is valid")
        }
    }

    class program
    {

        static  Main(string[] args)
        {


            var number = new Number { value= 1 };   
            var CorrectCounter = new Counter();
            var apps = new AppService();
            CorrectCounter.Assigned += apps.CorrecctAssign;
            Console.ReadKey();

        }
    }
}