using MakeLMS.Data;
using MakeLMS.Services;
using Microsoft.AspNetCore.Components;

namespace MakeLMS.Components.Pages.Dashboard.Instructor
{
    public partial class CourseEditor(LearningContentService lcService)
    {
        [Parameter] public int Id { get; set; }

        private Course? _course;

        private bool _isLoading = true;

        protected override async Task OnParametersSetAsync()
        {
            try
            {
                _isLoading = true;
                _course = await lcService.ReadCourseById(Id);
            }
            catch (Exception e)
            {

            }
            finally
            {
                _isLoading = false;
            }
        }

        private async Task HandleAddModule()
        {
            if (_course is null) return;
            try
            {
                await lcService.AddModuleAsync(_course.CourseNumber);
            }
            catch (Exception e)
            {

            }
        }

        private async Task HandleAddLesson(int moduleNumber)
        {
            if (_course is null) return;
            try
            {
                await lcService.AddLessonAsync(_course.CourseNumber, moduleNumber, LessonResourceType.Reading);
            }
            catch (Exception ex) { }
        }
    }
}