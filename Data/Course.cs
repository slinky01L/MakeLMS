using System.ComponentModel.DataAnnotations;

namespace MakeLMS.Data
{
    public class Course
    {
        [Key]
        public int CourseNumber { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ThumbnailImagePath { get; set; } = string.Empty;
        public List<Module> Modules { get; set; } = [];
    }
}
