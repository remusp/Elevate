using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Elevate.Samples.SpinnerNew
{
    [RibbonGroup("MyCustomRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class MyCustomRibbonGroup : AbstractRibbonGroup
    {
    }
}
