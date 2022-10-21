using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace services.Ecommerce.Customer.API.Model
{
    public class UserRole
    {
        [Key]
        [Column(Order = 1)]
        public int UserId { get; set; }
        public User User { get; set; }
        
        [Key]
        [Column(Order = 2)]
        public int RoleId { get; set; }
        public Role role { get; set; }
        public User user { get; set; }
    }
}