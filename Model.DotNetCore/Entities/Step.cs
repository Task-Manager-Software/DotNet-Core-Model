namespace Model.DotNetCore.Entities
{
    public class Step : AuditableEntityBase
    {
        int TaskId { get; set; }
        Task Task { get; set; }
        
        string Title { get; set; }
    }
}