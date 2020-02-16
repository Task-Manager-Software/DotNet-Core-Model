using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public interface IAccount : IEntityBase
    {
        string FullName { get; set; }

        List<IAccountProject> AccountProjects { get; set; }
        List<IAccountTask> AccountTasks { get; set; }
    }
}