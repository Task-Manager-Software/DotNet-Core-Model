namespace Model.DotNetCore.Entities
{
    public interface IAccountTask : IEntityBase
    {
        int AccountId { get; set; }
        IAccount Account { get; set; }
        
        int TaskId { get; set; }
        ITask Task { get; set; }
        
        bool IsAccepted { get; set; }
    }
}