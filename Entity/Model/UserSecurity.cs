using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Model
{
    public class UserSecurity : BaseEntity
    {
        public int UserId { get; set; }
        public string PasswordHash { get; set; }
    }
}
