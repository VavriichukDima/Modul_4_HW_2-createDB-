using System;
using System.Collections.Generic;

namespace Modul_4_HW_2__createBD_.Entities
{
    public class Project
    {
        public int ProjectId { get; set; }
        public string Name { get; set; }
        public double Budget { get; set; }
        public DateTime StartedDate { get; set; }

        public List<EmployeeProject> EmployeeProjects { get; set; } = new List<EmployeeProject>();
    }
}
