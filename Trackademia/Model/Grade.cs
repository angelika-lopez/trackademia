using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trackademia_PDC50.Model
{
    public class Grade
    {
        public int GradeID { get; set; }
        public string StudentID { get; set; }
        public string Subject { get; set; }
        public string Quarter { get; set; }
        public decimal Score { get; set; }
        public string SchoolYear { get; set; }
    }
}
