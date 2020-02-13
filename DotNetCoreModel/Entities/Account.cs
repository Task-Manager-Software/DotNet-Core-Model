using System.Collections.Generic;

namespace DotNetCoreModel.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }
        public IList<ProjectContributor> Projects { get; set; }
        public IList<TaskContributor> Tasks { get; set; }
    }
}
