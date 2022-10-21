using services.Ecommerce.Customer.API.Model;

namespace services.Ecommerce.Customer.API.Data.Reponsitory
{
    public interface IUserRepository
    {
        Task<IEnumerable<User>> GetAllUsers();
        Task<User> GetUserById(int id);
        
    }
}