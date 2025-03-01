using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace MvcMovie.Models;
public interface IPerson
{
    string PersonId { get; set; }
    string FullName { get; set; }
    string? Address { get; set; }
}

[Table("Persons")]
public class Person : IPerson
{
    [Key]
    public required string PersonId { get; set; }
    public required string FullName { get; set; }
    public string? Address { get; set; }
}
