using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.EditorTranslationResults
{
    [Action("Elevate.Samples.SpinnerNew.GetTranslationResultsAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(TranslationResultsRibbonGroup), 10, DisplayType.Large)]
    public class GetTranslationResultsAction : AbstractAction
    {
        protected override void Execute()
        {
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            var translationResultsController = editorController.TranslationResultsController;

            var results = translationResultsController.TryGetCurrentTranslationResults();
            var targetProposals = results.LookupResults.Results.Select(r => $"{r.ScoringResult.Match}% {r.TranslationProposal.TargetSegment.ToPlain()}");

            string output = string.Join(Environment.NewLine, targetProposals);
            MessageBox.Show(output, "Elevate TranslationResults sample", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
