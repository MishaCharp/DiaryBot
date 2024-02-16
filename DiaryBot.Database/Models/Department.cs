using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class Department
    {
        public int Id { get; set; }
        public string DepartmentName { get; set; }

        public List<Group> Groups { get; set; }
    }
}
