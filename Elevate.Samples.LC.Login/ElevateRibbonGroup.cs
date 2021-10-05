using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Elevate.Samples.LC.Login
{
    [RibbonGroup("MyCustomRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class ElevateRibbonGroup : AbstractRibbonGroup
    {
    }
}
