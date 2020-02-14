using System;
using System.ComponentModel.DataAnnotations;

namespace Model.DotNetCore.Entities
{
    public abstract class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
