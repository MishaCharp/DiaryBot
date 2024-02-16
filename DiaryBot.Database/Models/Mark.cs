using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class Mark
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public List<LessonMark> LessonMarks { get; set; }

    }
}
