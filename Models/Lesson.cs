namespace MakeLMS.Models
{
    public enum LessonResourceType
    {
        None = 0,
        Reading, 
        Video,
        Quiz,
    }

    public class LessonResource
    {
        public int Id;
        public int ModuleId;
        public int LessonId;
        public LessonResourceType type;
    }

    public class Lesson
    {
        public int Id;
        public int ModuleId;
        public string Name = string.Empty;
    }
}
