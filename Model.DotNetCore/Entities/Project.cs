using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Project : AuditableEntityBase
    {
        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        virtual public List<AccountProject> AccountProjects { get; set; }
        virtual public List<Task> Tasks { get; set; }
    }
}
