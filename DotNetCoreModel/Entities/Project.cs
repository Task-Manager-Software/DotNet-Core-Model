using System.Collections.Generic;

namespace DotNetCoreModel.Entities
{
    public class Project : AuditableEntityBase
    {
        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        public IList<ProjectContributor> Accounts { get; set; }
        public IList<Task> Tasks { get; set; }
    }
}
