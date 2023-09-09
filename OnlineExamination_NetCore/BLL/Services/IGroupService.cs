using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Services
{
    public interface IGroupService
    {
        PagedResult<GroupViewModel> GetAllGroups(int pageNumber, int pageSize);
        Task<GroupViewModel> AddGroupAsync(GroupViewModel groupVM);
        IEnumerable<Groups> GetAllGroups();
        GroupViewModel GetById(int groupId);
    }
}
