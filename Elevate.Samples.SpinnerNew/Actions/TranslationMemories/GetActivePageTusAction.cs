using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.TranslationMemories
{
    [Action("Elevate.Samples.SpinnerNew.GetTusActivePageAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationMemoriesRibbonGroup), 10, DisplayType.Large)]
    public class GetActivePageTusAction : AbstractAction
    {
        protected override void Execute()
        {
            var translationMemoriesViewController = SdlTradosStudio.Application.GetController<TranslationMemoriesViewController>();
            var tus = translationMemoriesViewController.GetAllTranslationUnitsFromActivePage();

            MessageBox.Show($"{tus.Count} TUs on the current page.", "Elevate TM Controller sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
