using MakeLMS.Data;
using Microsoft.AspNetCore.Components;

namespace MakeLMS.Components.Pages.Dashboard.Instructor
{
    public partial class CourseTree
    {
        [Parameter] public List<Data.Module> Modules { get; set; } = [];

        public Lesson? SelectedLesson { get; set; }
    }
}
