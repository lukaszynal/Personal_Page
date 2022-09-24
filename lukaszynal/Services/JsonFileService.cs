using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using lukaszynal.Models;
using Microsoft.AspNetCore.Hosting;

namespace lukaszynal.Services
{
    public class JsonFileService
    {
        public JsonFileService(IWebHostEnvironment webHostEnvironment)
        {
            WebHostEnvironment = webHostEnvironment;
        }

        public IWebHostEnvironment WebHostEnvironment { get; }

        private string JsonCoursesFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "courses.json");
        private string JsonProjectsFileName => Path.Combine(WebHostEnvironment.WebRootPath, "data", "projects.json");

        public IEnumerable<CourseModel>? GetCourses()
        {
            using var jsonFileReader = File.OpenText(JsonCoursesFileName);
            return JsonSerializer.Deserialize<CourseModel[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
        public IEnumerable<ProjectModel>? GetProjects()
        {
            using var jsonFileReader = File.OpenText(JsonProjectsFileName);
            return JsonSerializer.Deserialize<ProjectModel[]>(jsonFileReader.ReadToEnd(),
                new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                });
        }
    }
}
