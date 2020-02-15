using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Project : AuditableEntityBase
    {
        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        public List<ProjectContributor> Accounts { get; set; }
        public List<Task> Tasks { get; set; }
    }
}
