using System;
using System.Collections.Generic;

namespace Model.DotNetCore.Entities
{
    public class Task : AuditableEntityBase
    {
        public int ProjectId { get; set; }
        public Project Project { get; set; }
        
        public string Title { get; set; }
        public bool IsMyDay { get; set; }
        public bool IsImportant { get; set; }
        public DateTime? RemindDateUTC { get; set; }
        public DateTime? DueDateUTC { get; set; }
        public RepeatType RepeatType { get; set; }
        public byte? SelectedWeekDays { get; set; }
        public string Note { get; set; }
        
        public IList<TaskContributor> Accounts { get; set; }
        public IList<Step> Steps { get; set; }
        public IList<Attachment> Attachments { get; set; }
    }
}
