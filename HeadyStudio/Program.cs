using System;

namespace HeadyStudio
{
    class Program
    {
        static void Main(string[] args)
        {
            //Instance of an account == objext
            var UserAccount = new UserAccount
            {
                EmailAddress = "test@test.com"
            };

            UserAccount.Deposit3mm(22);
            UserAccount.Deposit14mm(5);
            UserAccount.DepositAqua(4);

            Console.WriteLine($"EmailAddress: {UserAccount.EmailAddress}, " +
                $"Account Number: {UserAccount.AccountNumber}, " +
                $"CreatedDate: {UserAccount.DateCreated}, " +
                $"Clear Rod 3mm: {UserAccount.ClearRod3mm}, " +
                $"Clear Rod 14mm: {UserAccount.ClearRod14mm}, " +
                $"Aqua Azul Rod: {UserAccount.AquaAzulRod}");

            var UserAccount2 = new UserAccount();



        }
    }
}
