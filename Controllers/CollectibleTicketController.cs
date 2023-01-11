using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using CollectibleMovieTicketDB.Data;
using CollectibleMovieTicketDB.Model;

namespace CollectibleMovieTicketDB.Controllers;

[Route("tickets")]
[ApiController]
public class CollectibleTicketsController : Controller
{
    private readonly CmtdbContext _db;

    public CollectibleTicketsController(CmtdbContext db)
    {
        _db = db;
    }

    [HttpGet]
    public async Task<ActionResult<List<CollectibleTicket>>> GetTickets()
    {
        return (await _db.CollectibleTickets.ToListAsync()).OrderByDescending(s => s.CollectorNumber).ToList();
    }
}
