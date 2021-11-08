using System;
using System.Collections.Generic;

namespace WCS_capitalism_simulator
{
    public class Person
    {
        public Guid PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<SavingAccount> Accounts { get; set; }
    }
}
