using CollectibleMovieTicketDB.Model;
using Microsoft.EntityFrameworkCore;

namespace CollectibleMovieTicketDB.Data;

public class CmtdbContext : DbContext
{
    public CmtdbContext(DbContextOptions options) : base(options)
    {
    }

    public DbSet<CollectibleTicket> CollectibleTickets { get; set; }
}
