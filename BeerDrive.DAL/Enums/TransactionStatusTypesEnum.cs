using System;

namespace BeerDrive.DAL.Enums
{
    public class TransactionStatusTypesEnum
    {
        public static Guid WorkingProcess = Guid.Parse("8C947DBF-4E27-4D8A-9405-E195D2C201C4");
        public static Guid Completed = Guid.Parse("AD7EA291-3ADE-4B9D-B607-6DB79C1C3D92");
        public static Guid Cancelled = Guid.Parse("05A87AB0-28C0-466C-90B7-0202BC5FE597");
    }
}
