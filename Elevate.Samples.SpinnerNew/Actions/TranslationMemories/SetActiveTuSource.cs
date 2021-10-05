using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;

namespace Elevate.Samples.SpinnerNew.Actions.TranslationMemories
{
    [Action("Elevate.Samples.SpinnerNew.SetActiveTuSource", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationMemoriesRibbonGroup), 10, DisplayType.Large)]
    public class SetActiveTuSource : AbstractAction
    {
        protected override void Execute()
        {
            var translationMemoriesViewController = SdlTradosStudio.Application.GetController<TranslationMemoriesViewController>();
            var tu = translationMemoriesViewController.GetActiveTranslationUnit();
            string oldSource = tu.SourceSegment.ToPlain();
            translationMemoriesViewController.SetActiveTranslationUnitSource(oldSource + " UPDATED");
        }
    }
}
