using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Elevate.Samples.SpinnerOld
{
    [RibbonGroup("MyCustomRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class MyCustomRibbonGroup : AbstractRibbonGroup
    {
    }
}
