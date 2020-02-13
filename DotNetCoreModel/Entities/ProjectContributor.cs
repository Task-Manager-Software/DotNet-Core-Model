namespace DotNetCoreModel.Entities
{
    public class ProjectContributor : EntityBase
    {
        public Account Account { get; set; }
        public int AccountId { get; set; }
        public Project Project { get; set; }
        public int ProjectId { get; set; }
        public bool IsOwner { get; set; }
        public bool IsAccepted { get; set; }
    }
}
