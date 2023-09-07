using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Services
{
    public interface IStudentService
    {
        PagedResult<StudentViewModel> GetAll(int pageNumber, int pageSize);
        Task<StudentViewModel> AddAsync(StudentViewModel vm);
        IEnumerable<Students> GetAllStudents();
        bool SetGroupIdToStudents(GroupViewModel vm);
        bool SetExamResult(AttendExamViewModel vm);
        IEnumerable<ResultViewModel> GetExamResults(int studentId);
        StudentViewModel GetStudentDetails(int studentId);
        Task<StudentViewModel> UpdateAsync(StudentViewModel vm);
    }
}
