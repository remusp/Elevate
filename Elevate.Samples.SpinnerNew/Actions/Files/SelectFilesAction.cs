using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Linq;

namespace Elevate.Samples.SpinnerNew.Actions.Files
{
    [Action("Elevate.Samples.SpinnerNew.SelectFilesAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(FilesControllerRibbonGroup), 10, DisplayType.Large)]
    public class SelectFilesAction : AbstractAction
    {
        protected override void Execute()
        {
            var filesController = SdlTradosStudio.Application.GetController<FilesController>();
            var files = filesController.CurrentVisibleFiles?.Where(file => file.Name.Contains("Numbers"));
            filesController.SelectFiles(files);
        }
    }
}
