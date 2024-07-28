using System.ServiceModel;

namespace BeerDrive.DAL.Exceptions
{
    public class ValidationFault
    {
        public string Message { get; set; }

        public bool IsWarning { get; set; }

        public ErrorCodes ErrorCode { get; set; }

        public static void Throw(string message, bool isWarning, ErrorCodes errorCode = 0)
        {
            throw new FaultException<ValidationFault>(new ValidationFault { Message = message, IsWarning = isWarning, ErrorCode = errorCode });
        }

        public static void Throw(string message, ErrorCodes errorCode = 0)
        {
            Throw(message, false, errorCode);
        }
    }
}
