using lukaszynal.Services;

namespace lukaszynal.Models.ViewModels
{
    public class CoursesViewModel
    {
        public CoursesViewModel(JsonFileService repositoryService)
        {
            RepositoryService = repositoryService;
        }

        public JsonFileService RepositoryService { get; }
        public IEnumerable<CourseModel> CppCourses => RepositoryService.GetCourses().Where(x => x.Category == "Cpp");
        public IEnumerable<CourseModel> PythonCourses => RepositoryService.GetCourses().Where(x => x.Category == "Python");
        public IEnumerable<CourseModel> DotNetCourses => RepositoryService.GetCourses().Where(x => x.Category == ".Net").OrderByDescending(x => x.Id);
        public IEnumerable<CourseModel> WebCourses => RepositoryService.GetCourses().Where(x => x.Category == "Web");
        public IEnumerable<CourseModel> OtherCourses => RepositoryService.GetCourses().Where(x => x.Category == "Other");
    }
}
