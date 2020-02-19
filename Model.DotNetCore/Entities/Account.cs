using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Account : EntityBase
    {
        string FullName { get; set; }

        List<AccountProject> AccountProjects { get; set; }
        List<AccountTask> AccountTasks { get; set; }
    }
}