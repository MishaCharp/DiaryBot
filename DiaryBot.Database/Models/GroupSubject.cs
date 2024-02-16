using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class GroupSubject
    {
        public int Id { get; set; }
        public Group Group { get; set; }
        public Subject Subject { get; set; }
    }
}
