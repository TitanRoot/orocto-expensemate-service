using System.ComponentModel.DataAnnotations.Schema;

namespace Orocto.ExpenseMate.Domain.Models;

[Table("Users")]
public class UsersModel
{
    [Column("SID")]
    public int UserId { get; set; }
    public string FirstName { get; set; } = string.Empty;
    public string? MiddleName { get; set; }
    public string LastName { get; set; } = string.Empty;
    public string Gender { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    public bool IsActive { get; set; }
    public string Email { get; set; } = string.Empty;
    public string UserName { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
}