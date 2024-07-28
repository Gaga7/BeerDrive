using System;
using System.Globalization;
using System.Linq;

namespace BeerDrive.DAL.Commons
{
    public class RandomCodeGenerator
    {
        private static readonly Random Random = new Random(Environment.TickCount);

        public static string GetNumber(int length)
        {
            return string.Concat(Enumerable.Range(0, length).Select((index) => Random.Next(10).ToString(CultureInfo.InvariantCulture)));
        }
    }
}
