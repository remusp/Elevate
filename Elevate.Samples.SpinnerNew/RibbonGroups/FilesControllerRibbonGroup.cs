using Sdl.Desktop.IntegrationApi;
using Sdl.Desktop.IntegrationApi.Extensions;
using Sdl.TranslationStudioAutomation.IntegrationApi.Presentation.DefaultLocations;

namespace Elevate.Samples.SpinnerNew.RibbonGroups
{
    [RibbonGroup("FilesControllerRibbonGroup")]
    [RibbonGroupLayout(LocationByType = typeof(TranslationStudioDefaultRibbonTabs.HomeRibbonTabLocation))]
    class FilesControllerRibbonGroup : AbstractRibbonGroup
    {
    }
}
