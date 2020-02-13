namespace DotNetCoreModel.Entities
{
    public class TaskContributor : EntityBase
    {
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Task Task { get; set; }
        public int TaskId { get; set; }
        public bool IsAccepted { get; set; }
    }
}
