using Microsoft.EntityFrameworkCore;
using WCS_capitalism_simulator;

class OffshoreContext : DbContext // DbContext overriden
{
    // Product entites can be accessed by this context
    public virtual DbSet<Person> Persons { get; set; }
    // Shop entities can be accessed by this context
    public virtual DbSet<SavingAccount> Accounts { get; set; }

    // OnConfiguring is a hook that executes while the context configures itself
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        // I add a connection to a database instance while the context configures
        optionsBuilder.UseSqlServer(
            @"Server=localhost,1433;Database=Offshore;user id=sa;password=MyPass@word;");
    
    }
}
