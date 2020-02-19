using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }

        public List<AccountProject> AccountProjects { get; set; }
        public List<AccountTask> AccountTasks { get; set; }
    }
}