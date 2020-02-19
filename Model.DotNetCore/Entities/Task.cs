using System;
using System.Collections.Generic;
using Model.DotNetCore.Enums;

namespace Model.DotNetCore.Entities
{
    public class Task : AuditableEntityBase
    {
        int ProjectId { get; set; }
        Project Project { get; set; }
        
        string Title { get; set; }
        bool IsMyDay { get; set; }
        bool IsImportant { get; set; }
        DateTime? RemindDateUTC { get; set; }
        DateTime? DueDateUTC { get; set; }
        RepeatType RepeatType { get; set; }
        byte? SelectedWeekDays { get; set; }
        string Note { get; set; }
        
        List<AccountTask> AccountTasks { get; set; }
        List<Step> Steps { get; set; }
        List<Attachment> Attachments { get; set; }
    }
}