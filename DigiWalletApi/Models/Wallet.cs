namespace DigiWalletApi.Models
{
    public class Wallet
    {
        public Guid Id { get; set; }
        public string WalletName { get; set; } = string.Empty;
        public decimal Balance { get; set; } = 0;
        public DateTime CreatedDate { get; set; } = DateTime.UtcNow;
        public string Currency { get; set; } = string.Empty ;
        public ICollection<Transaction> Transactions { get; set; } = new List<Transaction>();
        public Guid UserId { get; set; }

        public User User { get; set; }
    }
}
