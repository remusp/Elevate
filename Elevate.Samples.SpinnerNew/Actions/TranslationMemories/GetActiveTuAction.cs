using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.TranslationMemories
{
    [Action("Elevate.Samples.SpinnerNew.GetActiveTuAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationMemoriesRibbonGroup), 10, DisplayType.Large)]
    public class GetActiveTuAction : AbstractAction
    {
        protected override void Execute()
        {
            var translationMemoriesViewController = SdlTradosStudio.Application.GetController<TranslationMemoriesViewController>();
            var tu = translationMemoriesViewController.GetActiveTranslationUnit();

            MessageBox.Show($"Source: {tu.SourceSegment.ToPlain()}{Environment.NewLine}Target: {tu.TargetSegment.ToPlain()}", "Elevate TM Controller sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
