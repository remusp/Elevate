using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Linq;

namespace Elevate.Samples.SpinnerNew.Actions.Projects
{
    [Action("Elevate.Samples.SpinnerNew.DemoProjectAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(ProjectsControllerRibbonGroup), 10, DisplayType.Large)]
    public class DemoProjectAction : AbstractAction
    {
        protected override void Execute()
        {
            var projectsController = SdlTradosStudio.Application.GetController<ProjectsController>();

            // Call projectsController.GetAllProjects() here to get all projects instead of just visible ones:
            var projects = projectsController.GetProjects();
            projectsController.SelectedProjects = projects.Where(p => p.GetProjectInfo().Name.Contains("2020"));
        }
    }
}
