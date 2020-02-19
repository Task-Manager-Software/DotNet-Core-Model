namespace Model.DotNetCore.Entities
{
    public class Step : AuditableEntityBase
    {
        public int TaskId { get; set; }
        public Task Task { get; set; }
        public string Title { get; set; }
    }
}