using lukaszynal.Services;

namespace lukaszynal.Models.ViewModels
{
    public class ProjectsViewModel
    {
        public ProjectsViewModel(JsonFileService repositoryService, string projectName)
        {
            RepositoryService = repositoryService;
            ProjectName = projectName;
        }

        public JsonFileService RepositoryService { get; }
        public string ProjectName { get; }

        public IEnumerable<ProjectModel> Projects => RepositoryService.GetProjects();
    }
}
