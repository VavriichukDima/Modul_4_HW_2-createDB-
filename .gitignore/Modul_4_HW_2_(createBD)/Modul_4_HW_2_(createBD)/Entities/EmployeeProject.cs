using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul_4_HW_2__createBD_.Entities
{
    public class EmployeeProject
    {
        public int EmployeeProjectId { get; set; }
        public double Rate { get; set; }
        public DateTime StartedDate { get; set; }

        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int ProjectId { get; set; }
        public Project Project { get; set; }
    }
}
