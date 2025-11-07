namespace C_Basics.Class.Static
{
    public class SICaller
    {

        public static void GetBankAccount()
        {
            BankAccount acc1 = new BankAccount("Piyush", 5000);
            BankAccount acc2 = new BankAccount("Sarita", 8000);

            acc1.Deposit(1500);
            acc1.DisplayBalance();

            acc2.Withdraw(2000);
            acc2.DisplayBalance();
        }

        public static void GetBankUtility()
        {
            double nprAmount = BankUtility.ConvertUsdToNpr(100);
            Console.WriteLine("100 USD in NPR = " + nprAmount);

            double interest = BankUtility.CalculateInterest(5000, 7);
            Console.WriteLine("Interest = " + interest);

        }

        //use instance class when dealing with object-specific data and behavior.
        //use static class when dealing with utility functions or shared data that doesn't depend on instance-specific information.


    }
}
