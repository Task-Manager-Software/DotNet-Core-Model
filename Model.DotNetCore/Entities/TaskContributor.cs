namespace Model.DotNetCore.Entities
{
    public class TaskContributor : EntityBase
    {
        public int AccountId { get; set; }
        public Account Account { get; set; }
        
        public int TaskId { get; set; }
        public Task Task { get; set; }
        
        public bool IsAccepted { get; set; }
    }
}
