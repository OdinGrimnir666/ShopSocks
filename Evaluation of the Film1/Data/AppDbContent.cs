using Evaluation_of_the_Film1.Data.Models;
using Evaluation_of_the_Film1.Models;
using Microsoft.EntityFrameworkCore;


namespace Evaluation_of_the_Film1.Data
{
    public class AppDbContent : DbContext
    {
        public  AppDbContent(DbContextOptions<AppDbContent> options):base(options)
        {

        }

        public DbSet<Socks> Socks { get; set; }

        public DbSet<SocksCategory> SocksCategories { get; set; }
        public DbSet<Floor> Floor { get; set; }

        public DbSet<SocksITem> SocksITem { get; set; }

        public DbSet<Order> Order { get; set; }

        public DbSet<OrderDeteil> OrderDeteil { get; set; }




    }
}
