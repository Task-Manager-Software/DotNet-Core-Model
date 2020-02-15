namespace Model.DotNetCore.Entities
{
    public class AccountProject : EntityBase
    {
        public int AccountId { get; set; }
        virtual public Account Account { get; set; }
        
        public int ProjectId { get; set; }
        virtual public Project Project { get; set; }
        
        public bool IsOwner { get; set; }
        public bool IsAccepted { get; set; }
    }
}
