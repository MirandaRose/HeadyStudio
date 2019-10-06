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

            Console.WriteLine("0. Exit or Shut Down");
            Console.WriteLine("1. Create User Account");
            Console.WriteLine("2. Enter quantities of Clear Rods");
            Console.WriteLine("3. Enter quantities of Clear Tubing");
            Console.WriteLine("4. Enter quantities of Colored Rods");
            Console.WriteLine("5. Print all User Accounts");

            var option = Console.ReadLine();
            switch (option)
            {
                case "0":
                    Console.WriteLine("Leaving so soon? Thanks for stopping by!");
                    return;
                case "1":
                    Console.WriteLine("Enter Email Address:");
                    var email = Console.ReadLine();
                    return;
                case "2":
                    Console.WriteLine("Clear Colored Rods into Studio");
                    var clearRodSizes = Enum.GetNames(typeof(ClearRodSizes));
                    for(var i = 0; i < clearRodSizes.Length; i++)
                    {
                        Console.WriteLine($"{i}.{clearRodSizes[i]}");
                    }
                    Console.WriteLine("Sizes of Clear Rod:");
                    return;
                case "3":
                    return;
                case "4":
                    return;

            }



        }
    }
}
