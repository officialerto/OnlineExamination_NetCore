using DataAccessLayer.UnitOfWork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Services
{
    public class AccountService : IAccountService
    {
        IUnitOfWork _unitOfWork;

        public AccountService()
        {
            
        }

        public bool AddTeacher(UserViewModel vm)
        {
            throw new NotImplementedException();
        }

        public PagedResult<UserViewModel> GetAllTeachers(int pageNumber, int pageSize)
        {
            throw new NotImplementedException();
        }

        public LoginViewModel login(LoginViewModel vm)
        {
            throw new NotImplementedException();
        }
    }
}
