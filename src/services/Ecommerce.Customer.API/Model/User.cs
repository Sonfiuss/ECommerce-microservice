using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace services.Ecommerce.Customer.API.Model
{
    public class User
    {
        [Key]
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Mail{ get; set; }
        public string Phone{ get; set; }
        public string Password{ get; set; }
        public string Email{ get; set; }
        [Required]
        public string UrlAvatar{ get; set; }
        public DateTime? Date{ get; set; }
        [Required]
        public bool Genders{ get; set; }
        public string FirstName{ get; set; }
        public string LastName{ get; set; }
        public int Status{ get; set; }
        public List<UserRole> listUserRoles{ get; set; }

        public User(int id, string mail,string phone, string username, string password, string urlavatar, DateTime? birth, bool genders, string firstName, string lastName, int status){
            Id = id;
            UserName = username;
            Phone = phone;
            Mail = mail;
            UserName = username;
            Password = password;
            UrlAvatar = urlavatar;
            FirstName = firstName;
            LastName = lastName;
            Genders = genders;
            Status = status;
            Date = birth;
        }
        protected User(){}

    }
}