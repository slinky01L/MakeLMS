using MakeLMS.Data;
using Microsoft.AspNetCore.Components;

namespace MakeLMS.Components.Pages.Dashboard.Instructor
{
    public partial class CourseTree
    {
        [Parameter] public List<Module> Modules { get; set; } = [];

        [Parameter] public EventCallback OnAddModule { get; set; }
        [Parameter] public EventCallback<int> OnAddLesson { get; set; }

        public Lesson? SelectedLesson { get; set; }

        private async Task AddModule_Click()
        {
            await OnAddModule.InvokeAsync();
        }

        private async Task AddLesson_Click(int moduleNumber)
        {
            await OnAddLesson.InvokeAsync(moduleNumber);
        }

        private void LessonSelect_Click(int lessonNumber)
        {

        }
    }
}
