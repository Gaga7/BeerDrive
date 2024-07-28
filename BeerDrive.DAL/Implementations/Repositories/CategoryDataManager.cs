using BeerDrive.DAL.Context;
using System.Collections.Generic;
using System.Linq;

namespace BeerDrive.DAL.Implementations.Repositories
{
    public class CategoryDataManager
    {
        private readonly BeerDriveContext _context;
        public CategoryDataManager(BeerDriveContext context)
        {
            _context = context;
        }

        public List<BD_Categories> GetAll()
        {
            var query = from n in _context.BD_Categories
                        where n.DateDeleted == null
                        select n;

            return query.ToList();
        }
    }
}
