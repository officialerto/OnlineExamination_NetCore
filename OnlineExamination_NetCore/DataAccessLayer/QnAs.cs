using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class QnAs
    {
        public int Id { get; set; }
        public int ExamsId { get; set; }
        public Exams? Exams { get; set; }
        public string Question { get; set; } = string.Empty;
        public int Answer { get; set; }
        public string Option1 { get; set; } = string.Empty;
        public string Option2 { get; set; } = string.Empty;
        public string Option3 { get; set; } = string.Empty;
        public string Option4 { get; set; } = string.Empty;
        public ICollection<ExamResults> ExamResults { get; set; } = new HashSet<ExamResults>();

    }
}
