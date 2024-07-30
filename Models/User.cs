using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace TaskBackend.Models
{
    public class User : IdentityUser
    {
        public string Name { get; set; }
        public string Role { get; set; }
        public ICollection<TaskItem> Tasks { get; set; }
    }
}
