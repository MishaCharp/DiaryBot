using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class LessonMark
    {
        public int Id { get; set; }
        public Lesson Lesson { get; set; }
        public Mark Mark { get; set; }
    }
}
