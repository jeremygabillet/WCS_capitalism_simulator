using Microsoft.EntityFrameworkCore;

namespace WCS_capitalism_simulator
{
    public class OffshoreContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<SavingAccount> SavingAccounts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                @"Server=LOCALHOST\SQLEXPRESS;Database=Shop;Integrated Security=True");
        }
    }
}
