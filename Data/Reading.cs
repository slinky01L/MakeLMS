using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    [PrimaryKey(nameof(CourseNumber), nameof(ModuleNumber), nameof(LessonNumber))]
    public class Reading
    {
        public int CourseNumber { get; set; }
        public int ModuleNumber { get; set; }
        public int LessonNumber { get; set; }
        public int EstimatedReadingTimeSeconds { get; set; }
        public string Content { get; set; } = string.Empty; // TODO: Later, maybe point this towards a storage bucket
    }
}
