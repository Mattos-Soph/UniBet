namespace UniBet.Entities
{
    public class Deposit : EntitiyBase
    {
        public float DepositAmount { get; set; }
        public int UserId { get; set; }
        public string DepositType { get; set; }
        public DateTime DateTime { get; set; }
    }
}
