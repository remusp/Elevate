using Elevate.Samples.SpinnerNew.RibbonGroups;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.FileTypeSupport.Framework.BilingualApi;
using Sdl.TranslationStudioAutomation.IntegrationApi;
using Sdl.TranslationStudioAutomation.IntegrationApi.Extensions;

namespace Elevate.Samples.SpinnerNew.Actions.Editor
{
    [Action("Elevate.Samples.SpinnerNew.WriteToSegment", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(EditorControllerRibbonGroup), 10, DisplayType.Large)]
    public class WriteToSegmentAction : AbstractAction
    {
        protected override void Execute()
        {
            EditorController editorController = SdlTradosStudio.Application.GetController<EditorController>();

            var activeDocument = editorController?.ActiveDocument;

            if (activeDocument is null)
            {
                return;
            }
            string oldText = activeDocument.ActiveSegmentPair.Target.AsSimpleText();
            string newText = oldText + " UPDATED";

            WriteIntoActiveSegment(newText, writeInSource: false, activeDocument);
        }

        internal bool WriteIntoActiveSegment(string text, bool writeInSource, IStudioDocument activeDocument)
        {
            var activeSegmentPair = activeDocument.ActiveSegmentPair;
            if (activeSegmentPair is null)
            {
                return false;
            }

            var textPropertiesItem = activeDocument.PropertiesFactory.CreateTextProperties(text);
            var textNode = activeDocument.ItemFactory.CreateText(textPropertiesItem);

            ISegment segmentToChange = writeInSource ? activeSegmentPair.Source : activeSegmentPair.Target;

            segmentToChange.Clear();
            segmentToChange.Add(textNode);

            activeDocument.UpdateSegmentPair(activeSegmentPair);

            return true;
        }
    }
}
