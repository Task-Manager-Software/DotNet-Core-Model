namespace DotNetCoreModel.Entities
{
    public class Attachment : AuditableEntityBase
    {
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public string FileName { get; set; }
    }
}
