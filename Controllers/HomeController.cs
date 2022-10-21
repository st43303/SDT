using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using SDT.Services.Contracts.Domains.Projects;
using SDT.Web.Models;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace SDT.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> logger;
        private readonly IProjectService projectService;

        public HomeController(ILogger<HomeController> logger, IProjectService projectService)
        {
            this.logger = logger ?? throw new ArgumentNullException(nameof(logger));
            this.projectService = projectService ?? throw new ArgumentNullException(nameof(projectService));
        }

        public async Task<IActionResult> Index(CancellationToken ct)
        {
           
            var projects = await projectService.GetUserProjectsAsync(1, ct);

            var projectViews = projects.Select(project => new ProjectViewModel
            {
                Description = project.Description,
                CreatedDate = project.CreatedDate,
                AuthorId = project.AuthorId,
                Code = project.Code,
                Id = project.Id,
                Name = project.Name,
                WIP = project.WIP
            });

            return View(projectViews);
        }

        public async Task<IActionResult> Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public async Task<IActionResult> Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
