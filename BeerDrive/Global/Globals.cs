using BeerDrive.DAL.ViewEntities;
using BeerDrive.DTOs;

namespace BeerDrive.Global
{
    public static class Globals
    {
        private static AuthHeader _header;

        public static AuthHeader AuthHeader
        {
            get { return _header; }
            set
            {
                if (_header == null)
                    _header = value;
            }
        }

        public static GetUserDto User { get; set; }
        public static string Culture { get { return "ka"; } }
        public static int CurrentVersion { get { return 1; } }
    }
}
