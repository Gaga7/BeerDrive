using BeerDrive.DAL.Context;
using DevExpress.DXperience.Demos;
using System.Configuration;

namespace BeerDrive.Base
{
    public class BaseControl : TutorialControlBase
    {
        private BeerDriveContext _context;
        public BeerDriveContext Context
        {
            get
            {
                //if (_context != null)
                //    return _context;

                return _context = new BeerDriveContext(ConfigurationManager.ConnectionStrings["BeerDriveConnectionString"].ConnectionString);
            }
        }
    }
}
