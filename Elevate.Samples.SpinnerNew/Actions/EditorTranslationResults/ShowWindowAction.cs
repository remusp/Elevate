using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;

namespace Elevate.Samples.SpinnerNew.Actions.EditorTranslationResults
{
    [Action("Elevate.Samples.SpinnerNew.ShowWindowAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationResultsRibbonGroup), 10, DisplayType.Large)]
    public class ShowWindowAction : AbstractAction
    {
        protected override void Execute()
        {
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            var translationResultsController = editorController.TranslationResultsController;

            translationResultsController.ShowTranslationResultsWindow();
        }
    }
}
