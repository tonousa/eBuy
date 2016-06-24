using System.Data.Entity;

namespace Ebuy.Website.Models
{
    public class EBuyDataContext : DbContext
    {
        public DbSet<Auction> Auctions { get; set; }
    }
}