using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    public enum LessonResourceType
    {
        None = 0,
        Reading, 
        Video,
        Quiz,
    }

    [PrimaryKey(nameof(CourseNumber), nameof(ModuleNumber), nameof(LessonNumber))]
    public class Lesson
    {
        public int CourseNumber { get; set; }
        public int ModuleNumber { get; set; }
        public int LessonNumber { get; set; }
        public LessonResourceType LessonType { get; set; } = LessonResourceType.None;
        public string Name { get; set; } = string.Empty;
    }
}
