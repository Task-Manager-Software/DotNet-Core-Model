namespace Model.DotNetCore.Entities
{
    public class AccountProject : EntityBase
    {
        int AccountId { get; set; }
        Account Account { get; set; }
        
        int ProjectId { get; set; }
        Project Project { get; set; }
        
        bool IsOwner { get; set; }
        bool IsAccepted { get; set; }
    }
}