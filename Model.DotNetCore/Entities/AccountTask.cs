namespace Model.DotNetCore.Entities
{
    public class AccountTask : EntityBase
    {
        int AccountId { get; set; }
        Account Account { get; set; }
        
        int TaskId { get; set; }
        Task Task { get; set; }
        
        bool IsAccepted { get; set; }
    }
}