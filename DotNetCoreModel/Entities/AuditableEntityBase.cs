using System;

namespace DotNetCoreModel.Entities
{
    public abstract class AuditableEntityBase : EntityBase
    {
        public DateTime CreatedOnUTC { get; set; }
        public Guid CreatedBy { get; set; }
        public bool ModifiedFlag { get; set; }
        public DateTime? LastModifiedOnUTC { get; set; }
        public Guid? LastModifiedBy { get; set; }
        public bool ArchivedFlag { get; set; }
        public DateTime? ArchivedOnUTC { get; set; }
        public Guid? ArchivedBy { get; set; }
        public bool DeletedFlag { get; set; }
        public DateTime? DeletedOnUTC { get; set; }
        public Guid? DeletedBy { get; set; }
        public bool InactiveFlag { get; set; }
        public DateTime? InactiveOnUTC { get; set; }
        public Guid? InactiveBy { get; set; }
    }
}
