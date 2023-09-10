using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Services
{
    public interface IQnAService
    {
        PagedResult<QnAsViewModel> GetAll(int pageNumber, int pageSize);
        Task<QnAsViewModel> AddAsync(QnAsViewModel QnAVM);
        IEnumerable<QnAsViewModel> GetAllQnAByExamId(int examId);
        bool IsExamAttended(int examId, int studentId);

    }
}
