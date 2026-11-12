using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    [PrimaryKey(nameof(CourseNumber), nameof(ModuleNumber), nameof(LessonNumber))]
    public class Video
    {
        public int CourseNumber { get; set; }
        public int ModuleNumber;
        public int LessonNumber;
        public string YoutubeEmbeddedLink = string.Empty;
    }
}
