using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    [PrimaryKey(nameof(CourseNumber), nameof(ModuleNumber), nameof(LessonNumber))]
    public class Quiz
    {
        public int CourseNumber { get; set; }
        public int ModuleNumber { get; set; }
        public int LessonNumber { get; set; }
    }
}
