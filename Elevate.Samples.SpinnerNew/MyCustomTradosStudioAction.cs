using Elevate.Samples.SpinnerNew.UI;
using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using System.Windows.Forms;

namespace Elevate.Samples.SpinnerNew
{
    [Action("MyMainAction", Icon = "MyAction_Icon")]
    [ActionLayout(typeof(MyCustomRibbonGroup), 10, DisplayType.Large)]
    [Shortcut(Keys.Alt | Keys.F8)]
    public class MyCustomTradosStudioAction : AbstractAction
    {
        protected override void Execute()
        {
            var dialog = new TradosStyles();
            dialog.ShowDialog();
        }
    }
}
