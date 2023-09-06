using DataAccessLayer;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Xml.Linq;

namespace OnlineExamination.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(Users model)
        {
            Id = model.Id;
            Name = model.Name ?? "";
            UserName = model.UserName;
            Password = model.Password;
            Role = model.Role;
        }

        public Users ConvertViewModel(UserViewModel vm)
        {
            return new Users
            {
                Id = vm.Id,
                Name = vm.Name ?? "",
                UserName = vm.UserName,
                Password = vm.Password,
                Role = vm.Role,
            };
        }

        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; } = string.Empty;

        [Required]
        [Display(Name = "User Name")]
        public string UserName { get; set; } = string.Empty;

        [Required]
        public string Password { get; set; } = string.Empty;
        public int Role { get; set; }
    }
}