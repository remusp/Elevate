using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.Files
{
    [Action("Elevate.Samples.SpinnerNew.VisibleFilesAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(FilesControllerRibbonGroup), 10, DisplayType.Large)]
    public class VisibleFilesAction : AbstractAction
    {
        protected override void Execute()
        {
            var filesController = SdlTradosStudio.Application.GetController<FilesController>();
            var filesNames = filesController.CurrentVisibleFiles?.Select(file => file.Name);
            var message = $"Visible files:{Environment.NewLine}" + string.Join(Environment.NewLine, filesNames);
            MessageBox.Show(message, "Elevate FilesController sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
