using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using services.Ecommerce.Customer.API.Model;

namespace services.Ecommerce.Customer.API.Data.Reponsitory
{
    public class UserRepository : IUserRepository
    {
        public Task<IEnumerable<User>> GetAllUsers()
        {
            throw new NotImplementedException();
        }

        public Task<User> GetUserById(int id)
        {
            throw new NotImplementedException();
        }
    }
}