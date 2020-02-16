using System.ComponentModel.DataAnnotations;

namespace Model.DotNetCore.Entities
{
    public interface IEntityBase
    {
        [Key]
        int Id { get; set; }
    }
}