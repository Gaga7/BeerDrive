using System.ServiceModel;

namespace BeerDrive.DAL.Exceptions
{
    public class AccessFault
    {
        public string Message { get; set; }

        internal static void Throw(string message)
        {
            throw new FaultException<AccessFault>(new AccessFault { Message = message });
        }
    }
}
