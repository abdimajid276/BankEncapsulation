namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            
            var currentBalance = account.getbalane();
            
            account.Deposit(200);

            currentBalance = account.getbalane();
            
            Console.WriteLine(currentBalance);
        }
    }
}
