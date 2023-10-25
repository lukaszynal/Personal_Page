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
        public IEnumerable<CourseModel> ProgrammingCourses => RepositoryService.GetCourses().Where(x => x.Category == "Programming").OrderByDescending(x => x.Id);
        public IEnumerable<CourseModel> DataCourses => RepositoryService.GetCourses().Where(x => x.Category == "Data").OrderByDescending(x => x.Id);
        public IEnumerable<CourseModel> OtherCourses => RepositoryService.GetCourses().Where(x => x.Category == "Other").OrderByDescending(x => x.Id);
    }
}
