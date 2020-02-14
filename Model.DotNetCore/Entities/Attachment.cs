namespace Model.DotNetCore.Entities
{
    public class Attachment : AuditableEntityBase
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }
        
        public string FileName { get; set; }
    }
}
