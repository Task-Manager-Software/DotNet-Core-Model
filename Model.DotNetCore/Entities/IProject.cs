using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public interface IProject : IAuditableEntityBase
    {
        string Title { get; set; }
        bool ShowCompletedTasks { get; set; }

        List<IAccountProject> AccountProjects { get; set; }
        List<ITask> Tasks { get; set; }
    }
}