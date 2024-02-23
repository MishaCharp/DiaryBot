using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiaryBot.Database.Models
{
    public class VKUser
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public long VKID { get; set; }

        public Student Student { get; set; }
    }
}
