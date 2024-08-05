namespace BankEncapsulation

{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            var currentBalance = account.GetBalane();
            
            account.Deposit(200);

            currentBalance = account.GetBalane();
            
            Console.WriteLine(currentBalance);
        }
    }
}
