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
                $"Clear Rod: {UserAccount.ClearRod4mm}, " +
                $"Clear Rod 14mm: {UserAccount.ClearRod14mm}, " +
                $"Aqua Azul Rod: {UserAccount.AquaAzulRod}");



            var UserAccount2 = new UserAccount();

            UserAccount2.Deposit3mm(55);
            UserAccount2.Deposit14mm(18);
            UserAccount2.DepositAqua(6);

            Console.WriteLine($"Email Address: {UserAccount2.AccountNumber}," +
                $"Account Number:: {UserAccount2.AccountNumber}," +
                $"CreatedDate: {UserAccount2.DateCreated}," +
                $"Clear Rod 3mm: {UserAccount2.ClearRod3mm}," +
                $"Clear Rod 14mm: {UserAccount2.ClearRod14mm}," +
                $"Aqua Azul Rod: {UserAccount2.AquaAzulRod}");




        }
    }
}
