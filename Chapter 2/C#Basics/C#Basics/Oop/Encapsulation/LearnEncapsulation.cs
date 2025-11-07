namespace C_Basics.Oop.Encapsulation
{
    /* Encapsultaion : Process of wrapping data and methods into a single unit : class , 
     * 
     * Protects data form unintented modification 
     * implemented using access modifiers 
     * provides getter and settr method to control access modifier 
     */

    class LearnEncapsulation
    {
        private string name; // Private field (cannot be accessed directly)

        public void SetName(string newName) // Public method to modify private field
        {
            name = newName;
        }

        public string GetName() // Public method to access private field
        {
            return name;
        }
    }

    class EncapsulationCaller
    {
        public static void CallEncapsulationDemo()
        {
            LearnEncapsulation person = new LearnEncapsulation();
            person.SetName("Piyush");
            Console.WriteLine(person.GetName());
        }

        public static void CallEncapsulationBankDemo()
        {
            BankAccount account = new BankAccount("AC: 400", 5000);
            //getter only cant set it from here 
            //account.AccountNumber.ToString();
            //account.AccountNumber = 7000; // This line would cause a compile-time error

            account.Deposit(500);
            account.Withdraw(2000);

        }
    }
}
