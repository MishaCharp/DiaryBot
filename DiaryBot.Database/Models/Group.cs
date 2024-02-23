using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class Group
    {
        public int Id { get; set; }
        public string GroupName { get; set; }
        public Department Department { get; set; }


        public List<Student> Students { get; set; }
        public List<Lesson> Lessons { get; set; }
        public List<GroupSubject> GroupSubjects { get; set; }
    }
}
