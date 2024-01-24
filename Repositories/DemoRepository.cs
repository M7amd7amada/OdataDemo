using Microsoft.EntityFrameworkCore;
using Odata.Data;
using Odata.Models;

namespace Odata.Repositories;

public class DemoRepository : IDemoRepository
{
    private readonly AppDbContext _context;
    private readonly DbSet<DemoModel> _demos;

    public DemoRepository(AppDbContext context)
    {
        _context = context;
        _demos = _context.Demos;
    }

    public IQueryable<DemoModel> GetAll()
    {
        return _demos
            .AsNoTracking()
            .AsQueryable();
    }

    public IQueryable<DemoModel> GetById(int id)
    {
        return _demos
            .AsQueryable()
            .Where(d => d.Id == id);
    }
}