using BeerDrive.DAL.Cryptography;
using System.Configuration;

namespace BeerDrive.DAL.Global
{
    public static class Globals
    {
        public static string ConnectionString => StringCipher.Decrypt(ConfigurationManager.ConnectionStrings["BeerDriveContext"].ConnectionString);
    }
}
