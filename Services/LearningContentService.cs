using MakeLMS.Data;

namespace MakeLMS.Services;

public class LearningContentService(ApplicationDbContext context)
{
    private readonly ApplicationDbContext _context = context;
}