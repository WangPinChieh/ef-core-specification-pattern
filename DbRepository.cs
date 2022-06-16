using Microsoft.EntityFrameworkCore;

namespace ef_core_specification_pattern;

public interface IDbRepository
{
    Task<IEnumerable<User>> Find(ISpecification<User> spec);
}

public class DbRepository : IDbRepository
{
    private readonly EFContext _efContext;

    public DbRepository(EFContext efContext)
    {
        _efContext = efContext;
    }

    public async Task<IEnumerable<User>> Find(ISpecification<User> spec)
    {
        return _efContext.Users.Where(spec.ToExpression());
    }
}
