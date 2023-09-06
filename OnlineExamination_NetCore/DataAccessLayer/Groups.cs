using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer
{
    public class Groups
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int UsersId { get; set; }
        public Users Users { get; set; } // 1
        public ICollection<Students> Students { get; set; } = new HashSet<Students>(); //sonsuz
        public ICollection<Exams> Exams { get; set; } = new HashSet<Exams>(); //sonsuz
    }
}
