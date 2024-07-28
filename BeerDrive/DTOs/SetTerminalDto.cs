namespace BeerDrive.DTOs
{
    public class SetTerminalDto
    {
        public string TransactionNumber { get; set; }
        public SetTransactionDetailDto TransactionDetail { get; set; }
    }
}
