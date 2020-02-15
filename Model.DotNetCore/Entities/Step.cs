namespace Model.DotNetCore.Entities
{
    public class Step : AuditableEntityBase
    {
        public int TaskId { get; set; }
        virtual public Task Task { get; set; }
        
        public string Title { get; set; }
    }
}