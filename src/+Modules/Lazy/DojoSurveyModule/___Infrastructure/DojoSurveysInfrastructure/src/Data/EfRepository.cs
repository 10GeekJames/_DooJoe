namespace DojoSurveysInfrastructure.Data;
public class EfRepository<T> : RepositoryBase<T>, IReadRepository<T>, IRepository<T> where T : class, IAggregateRoot
{
    public EfRepository(DojoSurveysDbContext dbContext) : base(dbContext)
    {
    }
}
