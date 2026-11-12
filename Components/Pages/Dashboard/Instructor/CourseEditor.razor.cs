using MakeLMS.Data;
using Microsoft.AspNetCore.Components;

namespace MakeLMS.Components.Pages.Dashboard.Instructor
{
    public partial class CourseEditor
    {
        [Parameter] public required Course Course { get; set; }
    }
}