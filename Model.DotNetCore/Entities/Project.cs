using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Project : AuditableEntityBase
    {
        string Title { get; set; }
        bool ShowCompletedTasks { get; set; }

        List<AccountProject> AccountProjects { get; set; }
        List<Task> Tasks { get; set; }
    }
}