namespace DotNetCoreModel.Entities
{
    public class Step : AuditableEntityBase
    {
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public string Title { get; set; }
    }
}
