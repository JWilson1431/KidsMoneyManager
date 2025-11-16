namespace KidsMoneyManager.Models
{
    public class Child
    {
        public int Id { get; set; } 
        public string Name { get; set; } = string.Empty;
        public string Avatar { get; set; } = string.Empty;
        public decimal BankBalance { get; set; } = 0m;
        public decimal InterestRate { get; set; } = 0.01m; //Default interest rate is 1%
    }
}
