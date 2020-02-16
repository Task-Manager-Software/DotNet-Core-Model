namespace Model.DotNetCore.Entities
{
    public interface IAttachment : IAuditableEntityBase
    {
        int TaskId { get; set; }
        ITask Task { get; set; }
        
        string FileName { get; set; }
    }
}