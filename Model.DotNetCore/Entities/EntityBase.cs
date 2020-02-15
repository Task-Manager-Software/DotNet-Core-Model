using System.ComponentModel.DataAnnotations;

namespace Model.DotNetCore.Entities
{
    public class EntityBase
    {
        [Key]
        public int Id { get; set; }
    }
}
