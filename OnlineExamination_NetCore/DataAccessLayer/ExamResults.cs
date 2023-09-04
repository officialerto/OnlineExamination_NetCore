using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class ExamResults
    {
        public int Id { get; set; }
        public string StudentsId { get; set; } = string.Empty;
        public Students Students { get; set; } 
        public int? ExamsId { get; set; }
        public Exams Exams { get; set; }
        public int QnAsId { get; set; }
        public QnAs QnAs { get; set; }
        public int Answer { get; set; }
    }
}
