using System;
using System.Globalization;
using System.Linq;

namespace BeerDrive.DAL.Commons
{
    public class RandomCodeGenerator
    {
        private static readonly Random Random = new Random(Environment.TickCount);
        private static readonly object SyncLock = new object();

        public static string GetNumber(int length)
        {
            lock (SyncLock)
            {
                return string.Concat(Enumerable.Range(0, length).Select((index) => Random.Next(10).ToString(CultureInfo.InvariantCulture)));
            }
        }
    }
}
