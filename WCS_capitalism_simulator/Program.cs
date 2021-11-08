using System;
using System.Collections.Generic;


namespace WCS_capitalism_simulator
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var context = new OffshoreContext())
            {
                context.Database.EnsureDeleted();
                context.Database.EnsureCreated();

                Person person1 = new Person
                {
                    Firstname = "Patrick",
                    Lastname = "Balkany",

                };

                person1.Accounts = new List<SavingAccount>
                {
                    new SavingAccount { Amount = 2000000, InterestRate=5 },
                    new SavingAccount { Amount = 250000, InterestRate=15 },
                    new SavingAccount { Amount = 10000000, InterestRate=2 },
                };

                context.Add(person1);          
                context.SaveChanges();
                foreach (SavingAccount account in person1.Accounts)
                {
                    Console.WriteLine(account.GetInterests());
                }
            }
        }
    }
}
