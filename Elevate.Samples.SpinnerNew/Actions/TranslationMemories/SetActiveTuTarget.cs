using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;

namespace Elevate.Samples.SpinnerNew.Actions.TranslationMemories
{
    [Action("Elevate.Samples.SpinnerNew.SetActiveTuTarget", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationMemoriesRibbonGroup), 10, DisplayType.Large)]
    public class SetActiveTuTarget : AbstractAction
    {
        protected override void Execute()
        {
            var translationMemoriesViewController = SdlTradosStudio.Application.GetController<TranslationMemoriesViewController>();
            var tu = translationMemoriesViewController.GetActiveTranslationUnit();
            string oldTarget = tu.TargetSegment.ToPlain();
            translationMemoriesViewController.SetActiveTranslationUnitTarget(oldTarget + " UPDATED");
        }
    }
}
