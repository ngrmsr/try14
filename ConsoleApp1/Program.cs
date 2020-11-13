using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Approver a = new employee();
            Approver b = new viceManager();
            Approver c = new Manager();
            a.Setsuccessor(b);
            b.Setsuccessor(c);
            Purches purches = new Purches(10, 1000);
            a.Process(purches);
            Console.ReadKey();
        }
    }
    public class Purches
    {
        private  int number;
        private  double amount;

        public Purches(int number,double amount)
        {
            this.number = number;
            this.amount = amount;
        }
        public int Number
        {
            get { return number; }
            set { number = value; }
        }
        public double Amount
        {
            get { return amount; }
            set { amount = value; }
        }

    }
    public abstract class Approver
    {
        protected Approver approver;
        public void Setsuccessor(Approver approver) {
            this.approver = approver;
        }
        public abstract void Process(Purches purches);
    }
    public class employee : Approver
    {
        public override void Process(Purches purches)
        {
            if (purches.Amount>1000)
            {
                throw new Exception();
            }
            approver.Process(purches);
        }
    }
    public class viceManager : Approver
    {
        public override void Process(Purches purches)
        {
            if (purches.Number > 10)
            {
                throw new Exception();
            }
            approver.Process(purches);
        }
    }
    public class Manager : Approver
    {
        public override void Process(Purches purches)
        {
            Console.WriteLine("HI");
        }
    }
}
