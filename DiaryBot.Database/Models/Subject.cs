﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string SubjectName { get; set; }

        public List<GroupSubject> GroupSubjects { get; set; }
        public List<Lesson> Lessons { get; set; }
    }
}
