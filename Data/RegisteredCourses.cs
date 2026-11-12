using Microsoft.EntityFrameworkCore;

namespace MakeLMS.Data
{
    [PrimaryKey(nameof(UserId), nameof(CourseNumber))]
    public class RegisteredCourses
    {
        public int UserId { get; set; }
        public int CourseNumber { get; set; }
    }
}
