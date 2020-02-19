namespace Model.DotNetCore.Entities
{
    public class Attachment : AuditableEntityBase
    {
        int TaskId { get; set; }
        Task Task { get; set; }
        
        string FileName { get; set; }
    }
}