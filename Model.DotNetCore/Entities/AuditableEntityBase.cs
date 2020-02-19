using System;

namespace Model.DotNetCore.Entities
{
    public class AuditableEntityBase : EntityBase
    {
        DateTime CreatedOnUTC { get; set; }
        
        int CreatedById { get; set; }
        Account CreatedBy { get; set; }
        
        bool ModifiedFlag { get; set; }
        DateTime? LastModifiedOnUTC { get; set; }
        
        int? LastModifiedById { get; set; }
        Account LastModifiedBy { get; set; }
        
        bool? ArchivedFlag { get; set; }
        DateTime? ArchivedOnUTC { get; set; }
        
        int? ArchivedById { get; set; }
        Account ArchivedBy { get; set; }
        
        bool? DeletedFlag { get; set; }
        DateTime? DeletedOnUTC { get; set; }
        
        int? DeletedById { get; set; }
        Account DeletedBy { get; set; }
        
        bool? InactiveFlag { get; set; }
        DateTime? InactiveOnUTC { get; set; }
        
        int? InactiveById { get; set; }
        Account InactiveBy { get; set; }
    }
}