using MakeLMS.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;

namespace MakeLMS.Services;

public class LearningContentService(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;

    public Task<Course?> ReadCourseById(int id)
    {
        return _context.Courses
            .Include(c => c.Modules)
                .ThenInclude(m => m.Lessons)
            .Where(x => x.CourseNumber == id)
            .FirstOrDefaultAsync();
    }

    public async Task<Module> AddModuleAsync(int courseNumber)
    {
        int maxModuleNumber = await _context.Modules
            .Where(m => m.CourseNumber == courseNumber)
            .Select(m => (int?)m.ModuleNumber) 
            .MaxAsync() ?? 0;

        int nextModuleNumber = maxModuleNumber + 1;

        var newModule = new Module
        {
            CourseNumber = courseNumber,
            ModuleNumber = nextModuleNumber,
            Name = $"Untitled Module - {nextModuleNumber}"
        };

        var addedModule = _context.Modules.Add(newModule);
        await _context.SaveChangesAsync();

        return newModule;
    }

    public async Task<Lesson> AddLessonAsync(int courseNumber, int moduleNumber, LessonResourceType lessonType)
    {
        int maxLessonNumber = await _context.Lessons
            .Where(l => l.CourseNumber == courseNumber && l.ModuleNumber == moduleNumber)
            .Select(l => (int?)l.LessonNumber)
            .MaxAsync() ?? 0;

        int nextLessonNumber = maxLessonNumber + 1;

        var newLesson = new Lesson
        {
            CourseNumber = courseNumber,
            ModuleNumber = moduleNumber,
            LessonNumber = nextLessonNumber,
            LessonType = lessonType,
            Name = $"Untitled Lesson - {nextLessonNumber}",
        };

        _context.Lessons.Add(newLesson);
        await _context.SaveChangesAsync();
        return newLesson;
    }
}