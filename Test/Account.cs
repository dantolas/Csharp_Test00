namespace Test
{
    class Account
    {
        private float limit;
        private float balance;
        private String currency;
        private bool frozen = false;


        public Account(float limit, float balance, string currency)
        {
            while(balance > limit)
            {
                Console.WriteLine("Balance cannot be set higher than the limit, please enter the balance again:");
                float input = (float)Convert.ToInt32(Console.ReadLine());
                balance = input;
            }

            this.limit = limit;
            this.balance = balance;
            this.currency = currency;
        }

        public void freeze(int input)
        {
            if(input > 0)
            {
                this.frozen = true;
                return;
            }
            this.frozen = false;
        }


        public void payDebt()
        {
            Console.WriteLine("Debt paid");
            this.balance = this.limit;
        }


        public float getAsEuros()
        {
            this.currency = "eur";
            this.balance = balance / 25;
            this.limit = limit / 25;
            return this.balance;
        }

        public void raiseLimit(float amount)
        {
            if (this.frozen)
            {
                Console.WriteLine("Operation failed: Account is frozen");
                return;
            }
            this.limit += amount;
            return;
        }


        public void makePayment(float amount)
        {

            if (this.frozen)
            {
                Console.WriteLine("Operation failed: Account is frozen");
                return;
            }

            if(amount <= this.balance)
            {
                this.balance -= amount;
                Console.WriteLine("Payment succesfull");
                return;
            }
            else
            {
                Console.WriteLine("Operation failed:Not enough balance on account");
                return;
            }

        }

        public override string ToString()
        {
            return "- - - - - - - - - - - \nAccount limit:"+this.limit+this.currency + "\nAccount balance:"+this.balance+this.currency+ "\n- - - - - - - - - - - ";
        }


    }
}