using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;


namespace services.Ecommerce.Customer.API.Model
{
    public class Role
    {
        [Key]
        public int Id { get; private set; }
        public string Name { get; private set; }
        public List<UserRole> listRoleUser { get; protected set; } 



    }
}