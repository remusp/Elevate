using Elevate.Samples.LC.Login.UI;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;

namespace Elevate.Samples.LC.Login
{
    [Action("Elevate.Samples.LC.Login.MyMainAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(ElevateRibbonGroup), 10, DisplayType.Large)]
    public class ElevateAction : AbstractAction
    {
        protected override void Execute()
        {
            var dialog = new CloudWindow();
            dialog.ShowDialog();
        }
    }
}
