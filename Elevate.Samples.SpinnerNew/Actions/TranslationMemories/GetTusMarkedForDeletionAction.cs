using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.TranslationMemories
{
    [Action("Elevate.Samples.SpinnerNew.GetTusMarkedForDeletionAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationMemoriesRibbonGroup), 10, DisplayType.Large)]
    public class GetTusMarkedForDeletionAction : AbstractAction
    {
        protected override void Execute()
        {
            var translationMemoriesViewController = SdlTradosStudio.Application.GetController<TranslationMemoriesViewController>();
            var tus = translationMemoriesViewController.GetTranslationUnitsMarkedForDeletion();

            MessageBox.Show($"{tus.Count} TUs marked for deletion.", "Elevate TM Controller sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
