using System;

namespace Model.DotNetCore.Entities
{
    public abstract class AuditableEntityBase : EntityBase
    {
        public DateTime CreatedOnUTC { get; set; }
        
        public int CreatedById { get; set; }
        virtual public Account CreatedBy { get; set; }
        
        public bool ModifiedFlag { get; set; }
        public DateTime? LastModifiedOnUTC { get; set; }
        
        public int? LastModifiedById { get; set; }
        virtual public Account LastModifiedBy { get; set; }
        
        public bool? ArchivedFlag { get; set; }
        public DateTime? ArchivedOnUTC { get; set; }
        
        public int? ArchivedById { get; set; }
        virtual public Account ArchivedBy { get; set; }
        
        public bool? DeletedFlag { get; set; }
        public DateTime? DeletedOnUTC { get; set; }
        
        public int? DeletedById { get; set; }
        virtual public Account DeletedBy { get; set; }
        
        public bool? InactiveFlag { get; set; }
        public DateTime? InactiveOnUTC { get; set; }
        
        public int? InactiveById { get; set; }
        virtual public Account InactiveBy { get; set; }
    }
}
