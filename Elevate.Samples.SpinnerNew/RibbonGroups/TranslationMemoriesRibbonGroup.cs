using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Elevate.Samples.SpinnerNew.RibbonGroups
{
    [RibbonGroup("TranslationMemoriesRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class TranslationMemoriesRibbonGroup : AbstractRibbonGroup
    {
    }
}
