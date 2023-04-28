using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HKCR.Domain.Shared;

namespace HKCR.Domain.Entities;

public class User : BaseEntity
{
    // public Employee(int id, string name, string email, string password, string phone, string address, UserRole role)
    // {
    //     Id = id;
    //     Name = name ?? throw new ArgumentNullException(nameof(name));
    //     Email = email ?? throw new ArgumentNullException(nameof(email));
    //     Password = password ?? throw new ArgumentNullException(nameof(password));
    //     Phone = phone ?? throw new ArgumentNullException(nameof(phone));
    //     Address = address ?? throw new ArgumentNullException(nameof(address));
    //     Role = role;
    // }

    public Guid Id { get; set; } = new Guid();
    public string Name { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }
    public string Phone { get; set; }
    public string Address { get; set; }
    public UserRole Role { get; set; } = UserRole.User;

    [ForeignKey("Document")]
    public Guid DocId { get; set; }
    public virtual Document Document { get; set; }

    // [ForeignKey("Department")]
    // public int DepartmentId { get; set; }
    // public virtual Department Department { get; set; }
}