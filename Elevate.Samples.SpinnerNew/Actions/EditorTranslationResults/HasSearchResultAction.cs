using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.EditorTranslationResults
{
    [Action("Elevate.Samples.SpinnerNew.HasSearchResultAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationResultsRibbonGroup), 10, DisplayType.Large)]
    public class HasSearchResultAction : AbstractAction
    {
        protected override void Execute()
        {
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            var translationResultsController = editorController.TranslationResultsController;

            bool result = translationResultsController.HasSearchResult(2);

            MessageBox.Show(result.ToString(), "Elevate TranslationResults sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
