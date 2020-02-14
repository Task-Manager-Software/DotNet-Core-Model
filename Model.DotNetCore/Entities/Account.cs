using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }
        
        public IList<ProjectContributor> Projects { get; set; }
        public IList<TaskContributor> Tasks { get; set; }
    }
}
