using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew.Actions.Editor
{
    [Action("Elevate.Samples.SpinnerNew.SelectSegment", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(EditorControllerRibbonGroup), 10, DisplayType.Large)]
    public class SelectSegmentAction : AbstractAction
    {
        protected override void Execute()
        {
            var segmentNumber = "3";
            var editorController = SdlTradosStudio.Application.GetController<EditorController>();
            IStudioDocument activeDocument = editorController?.ActiveDocument;

            bool isSegmentSelected = activeDocument?.SetActiveSegmentPair(activeDocument.ActiveFile, segmentNumber, setFocusOnSegment: true) == true;

            if (!isSegmentSelected)
            {
                MessageBox.Show("Error selecting segment", "Elevate EditorController sample", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
