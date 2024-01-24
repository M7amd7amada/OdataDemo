using Odata.Models;

namespace Odata.Repositories;

public interface IDemoRepository
{
    public IQueryable<DemoModel> GetAll();
    public IQueryable<DemoModel> GetById(int id);
}