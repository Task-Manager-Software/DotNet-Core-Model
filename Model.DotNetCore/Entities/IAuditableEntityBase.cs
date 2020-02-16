using System;

namespace Model.DotNetCore.Entities
{
    public interface IAuditableEntityBase : IEntityBase
    {
        DateTime CreatedOnUTC { get; set; }
        
        int CreatedById { get; set; }
        IAccount CreatedBy { get; set; }
        
        bool ModifiedFlag { get; set; }
        DateTime? LastModifiedOnUTC { get; set; }
        
        int? LastModifiedById { get; set; }
        IAccount LastModifiedBy { get; set; }
        
        bool? ArchivedFlag { get; set; }
        DateTime? ArchivedOnUTC { get; set; }
        
        int? ArchivedById { get; set; }
        IAccount ArchivedBy { get; set; }
        
        bool? DeletedFlag { get; set; }
        DateTime? DeletedOnUTC { get; set; }
        
        int? DeletedById { get; set; }
        IAccount DeletedBy { get; set; }
        
        bool? InactiveFlag { get; set; }
        DateTime? InactiveOnUTC { get; set; }
        
        int? InactiveById { get; set; }
        IAccount InactiveBy { get; set; }
    }
}