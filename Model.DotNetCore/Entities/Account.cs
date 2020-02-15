using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }
        
        public List<ProjectContributor> Projects { get; set; }
        public List<TaskContributor> Tasks { get; set; }
    }
}
