namespace Model.DotNetCore.Entities
{
    public interface IAccountProject : IEntityBase
    {
        int AccountId { get; set; }
        IAccount Account { get; set; }
        
        int ProjectId { get; set; }
        IProject Project { get; set; }
        
        bool IsOwner { get; set; }
        bool IsAccepted { get; set; }
    }
}