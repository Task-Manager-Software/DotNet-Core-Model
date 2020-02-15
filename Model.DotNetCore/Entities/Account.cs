using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Account : EntityBase
    {
        public string FullName { get; set; }

        virtual public List<AccountProject> AccountProjects { get; set; }
        virtual public List<AccountTask> AccountTasks { get; set; }
    }
}
