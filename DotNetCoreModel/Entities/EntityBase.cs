using System;
using System.ComponentModel.DataAnnotations;

namespace DotNetCoreModel.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
