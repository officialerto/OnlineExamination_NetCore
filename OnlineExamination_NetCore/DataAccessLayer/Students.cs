using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Students
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string UserName { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Contact { get; set; } = string.Empty;
        public string CVFileName { get; set; } = string.Empty;
        public string PictureFileName { get; set; } = string.Empty;
        public int GroupsId { get; set; }
        public Groups Groups { get; set; }
        public ICollection<ExamResults>? ExamResults { get; set; } = new HashSet<ExamResults>();
    }
}
