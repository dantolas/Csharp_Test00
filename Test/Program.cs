namespace Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello user");

            Account a = new Account(500, 600, "kc");

            Console.WriteLine(a);


            a.raiseLimit(400);

            a.makePayment(50);
            a.makePayment(50);
            a.makePayment(500);

            Console.WriteLine(a);

            Console.WriteLine("Balance in euros:" + a.getAsEuros());

            

            Console.WriteLine(a);


            a.freeze(1);

            a.makePayment(20);
            a.raiseLimit(30);
            Console.WriteLine(a);
            a.freeze(0);
            a.makePayment(2);
            a.raiseLimit(5);
            Console.WriteLine(a);

        }
    }
}