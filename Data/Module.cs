using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    [PrimaryKey(nameof(CourseNumber), nameof(ModuleNumber))]
    public class Module
    {
        public int CourseNumber { get; set; }
        public int ModuleNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Lesson> Lessons { get; set; } = [];
    }
}
