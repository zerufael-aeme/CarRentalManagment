using Microsoft.EntityFrameworkCore;

namespace CarRentalManagment.Models
{
    public class CarManagementDbContext : DbContext
    {
        public CarManagementDbContext(DbContextOptions<CarManagementDbContext> options)
            : base(options)
        {
        }

        public DbSet<Account> Accounts { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<RentOrder> RentOrders { get; set; }
        public DbSet<BookOrder> BookOrders { get; set; }
    }
}
