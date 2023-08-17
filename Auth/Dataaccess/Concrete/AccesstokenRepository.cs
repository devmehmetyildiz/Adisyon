using Auth.Dataaccess.Abstract;
using Auth.Entities;

namespace Auth.Dataaccess.Concrete
{
    public class AccesstokenRepository : Repository<AccesstokenEntity> , IAccesstokenRepository
    {
        public AccesstokenRepository(AppDbContext options) : base(options)
        {
            
        }
    }
}
