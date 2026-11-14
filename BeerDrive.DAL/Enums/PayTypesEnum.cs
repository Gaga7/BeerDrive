using System;

namespace BeerDrive.DAL.Enums
{
    public class PayTypesEnum
    {
        public static Guid Cash = Guid.Parse("429595B0-64FA-4589-9AB5-F7478D7B34B9");
        public static Guid Card = Guid.Parse("4A7533FE-D1D6-4664-9940-29B6D0BDECF2");
        public static Guid Points = Guid.Parse("E020A709-BCF7-424B-8F70-D030255EB6E6");
    }
}
