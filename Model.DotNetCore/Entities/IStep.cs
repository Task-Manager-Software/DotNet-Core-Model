namespace Model.DotNetCore.Entities
{
    public interface IStep : IAuditableEntityBase
    {
        int TaskId { get; set; }
        ITask Task { get; set; }
        
        string Title { get; set; }
    }
}