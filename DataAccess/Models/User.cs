using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models;

public class UserModel
{
    public long Id { get; set; }
    public string UserName { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Email { get; set; }
    public char Gender { get; set; }
    public long PhoneNumber { get; set; }
    public string Address { get; set; }
    public string Role { get; set; }
    public string EmergencyContactName { get; set; }
    public long EmergencyContactNumber { get; set; }
}