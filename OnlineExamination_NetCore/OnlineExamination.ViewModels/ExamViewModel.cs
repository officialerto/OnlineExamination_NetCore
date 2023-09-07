using DataAccessLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewModels
{
    public class ExamViewModel
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Exam Name")]
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public int Time { get; set; }
        public int GroupsId { get; set; }
        public List<ExamViewModel> ExamList { get; set; }
        public int TotalCount { get; set; }
        public IEnumerable<Groups> GroupList { get; set; }
        public ExamViewModel(Exams model)
        {
            Id = model.Id;
            Title = model.Title ?? "";
            Description = model.Description ?? "";
            StartDate = model.StartDate;
            GroupsId = model.GroupsId;
        }

        public Exams ConvertViewModel(ExamViewModel vm)
        {
            return new Exams
            {
                Id = vm.Id,
                Title = vm.Title ?? "",
                Description = vm.Description ?? "",
                StartDate = vm.StartDate,
                GroupsId = vm.GroupsId,
            };
        }
    }
}
