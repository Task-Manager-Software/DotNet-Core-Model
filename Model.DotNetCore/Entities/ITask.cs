using System;
using System.Collections.Generic;
using Model.DotNetCore.Enums;

namespace Model.DotNetCore.Entities
{
    public interface ITask : IAuditableEntityBase
    {
        int ProjectId { get; set; }
        IProject Project { get; set; }
        
        string Title { get; set; }
        bool IsMyDay { get; set; }
        bool IsImportant { get; set; }
        DateTime? RemindDateUTC { get; set; }
        DateTime? DueDateUTC { get; set; }
        RepeatType RepeatType { get; set; }
        byte? SelectedWeekDays { get; set; }
        string Note { get; set; }
        
        List<IAccountTask> AccountTasks { get; set; }
        List<IStep> Steps { get; set; }
        List<IAttachment> Attachments { get; set; }
    }
}