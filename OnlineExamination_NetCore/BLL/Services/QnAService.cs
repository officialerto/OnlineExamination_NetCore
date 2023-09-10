using DataAccessLayer;
using DataAccessLayer.UnitOfWork;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ViewModels;

namespace BLL.Services
{
    public class QnAService : IQnAService
    {
        IUnitOfWork _unitofwork;
        ILogger<QnAService> iLogger;

        public QnAService(IUnitOfWork unitofwork, ILogger<QnAService> iLogger)
        {
            _unitofwork = unitofwork;
            this.iLogger = iLogger;
        }

        public async Task<QnAsViewModel> AddAsync(QnAsViewModel QnAVM)
        {
            try
            {
                QnAs objGroup = QnAVM.ConvertViewModel(QnAVM);
                await _unitofwork.GenericRepository<QnAs>().AddAsync(objGroup);
                _unitofwork.Save();
            }
            catch (Exception ex)
            {
                return null;
            }
            return QnAVM;
        }

        public PagedResult<QnAsViewModel> GetAll(int pageNumber, int pageSize)
        {
            var model = new QnAsViewModel();
            try
            {
                int ExcludeRecords = (pageSize * pageNumber) - pageSize;
                List<QnAsViewModel> detailList = new List<QnAsViewModel>();
                var modelList = _unitofwork.GenericRepository<QnAs>().GetAll().Skip(ExcludeRecords).Take(pageSize).ToList();
                var totalCount = _unitofwork.GenericRepository<QnAs>().GetAll().ToList();
                detailList = ListInfo(modelList);
                if (detailList != null)
                {
                    model.QnAsList = detailList;
                    model.TotalCount = totalCount.Count();
                }
            }
            catch (Exception ex)
            {
                iLogger.LogError(ex.Message);
            }
            var results = new PagedResult<QnAsViewModel>
            {
                Data = model.QnAsList,
                TotalItems = model.TotalCount,
                PageNumber = pageNumber,
                PageSize = pageSize,
            };
            return results;
        }

        private List<QnAsViewModel> ListInfo(List<QnAs> modelList)
        {
            return modelList.Select(o => new QnAsViewModel(o)).ToList();
        }

        public IEnumerable<QnAsViewModel> GetAllQnAByExamId(int examId)
        {
            try
            {
                var qnaList = _unitofwork.GenericRepository<QnAs>().GetAll().Where(x => x.ExamsId == examId);
                return ListInfo(qnaList.ToList());
            }
            catch (Exception ex)
            {
                iLogger.LogError(ex.Message);
            }
            return Enumerable.Empty<QnAsViewModel>();
        }

        public bool IsExamAttended(int examId, int studentId)
        {
            try
            {
                var qnaRecord = _unitofwork.GenericRepository<ExamResults>().GetAll().FirstOrDefault(x => x.ExamsId == examId && x.StudentsId == studentId);
                return qnaRecord == null ? false : true;
            }
            catch (Exception ex)
            {
                iLogger.LogError(ex.Message);
            }
            return false;
        }
    }
}
