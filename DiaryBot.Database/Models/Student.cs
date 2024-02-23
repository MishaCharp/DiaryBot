namespace DiaryBot.Database.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string Surname { get; set; }
        public string Name { get; set; }
        public string? Patronymic { get; set; }

        public int GroupId { get; set; }


        public List<User> Users { get; set; }
        public List<LessonMark> LessonMarks { get; set; }
    }
}
