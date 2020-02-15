namespace Model.DotNetCore.Entities
{
    public class AccountTask : EntityBase
    {
        public int AccountId { get; set; }
        virtual public Account Account { get; set; }
        
        public int TaskId { get; set; }
        virtual public Task Task { get; set; }
        
        public bool IsAccepted { get; set; }
    }
}
