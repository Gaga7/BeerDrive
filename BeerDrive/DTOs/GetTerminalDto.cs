using System.Collections.Generic;

namespace BeerDrive.DTOs
{
    public class GetTerminalDto
    {
        public GetTransactionDto Transaction { get; set; }
        public List<GetTransactionDetailDto> TransactionDetails { get; set; }
    }
}
