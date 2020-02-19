using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Project : AuditableEntityBase
    {
        //This is for a dummy PR

        public string Title { get; set; }
        public bool ShowCompletedTasks { get; set; }

        public List<AccountProject> AccountProjects { get; set; }
        public List<Task> Tasks { get; set; }
    }
}