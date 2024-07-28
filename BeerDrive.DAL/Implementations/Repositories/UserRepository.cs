using BeerDrive.DAL.Context;
using System.Threading.Tasks;
using System.Linq;
using System.Data.Entity;

namespace BeerDrive.DAL.Implementations.Repositories
{
    public class UserRepository : GenericRepository<BD_Users>
    {
        public UserRepository(BeerDriveContext context) : base(context) { }

        public async Task<BD_Users> LoginAsync(string loginName, string password)
        {
            var query = from n in context.BD_Users
                        where n.LoginName == loginName &&
                        n.Password == password &&
                        n.Status == true
                        select n;

            Identity.User = await query.FirstOrDefaultAsync();

            return Identity.User;
        }
    }
}
