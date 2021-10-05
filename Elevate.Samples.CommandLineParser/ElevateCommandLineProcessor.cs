using Elevate.Samples.CommandLineParser.UI;
using Sdl.Desktop.IntegrationApi.Extensions.CommandLine;
using System.Collections.Generic;
using System.Threading;

namespace Elevate.Samples.CommandLineParser
{
    [ExternalCommandLineProcessor]
    internal class ElevateCommandLineProcessor : IExternalWindowAwareCommandLineProcessor
    {
        private const string LoadFileArgument = "LoadFile";

        private const string ReadOnlyArgument = "ReadOnly";

        public string TaskName => "Load File Contents";

        public string TaskDescription => "Loads the file specified in comand-line";

        public IEnumerable<ExternalCommandLineArgumentDefinition> SupportedArguments => new List<ExternalCommandLineArgumentDefinition>
        {
             new ExternalCommandLineArgumentDefinition(LoadFileArgument,
                    "The full path to the file to load")
                {
                    MinValues = 1,
                    MaxValues = 1,
                    SampleValues = new[] { "C:\\Your\\Path\\YourFile.txt" }
                },
             new ExternalCommandLineArgumentDefinition(ReadOnlyArgument,
                    "Disables file editing")
                {
                    MinValues = 0,
                    MaxValues = 0,
                }
        };

        public void ProcessCommandLine(ExternalCommandLineArguments args)
        {
            ExternalCommandLineArgument fileArgument = args[LoadFileArgument];
            if (fileArgument == null)
            {
                return;
            }

            ExternalCommandLineArgument readOnlyArgument = args[ReadOnlyArgument];

            Thread newWindowThread = new Thread(new ParameterizedThreadStart(ThreadStartingPoint));
            newWindowThread.SetApartmentState(ApartmentState.STA);
            newWindowThread.IsBackground = true;
            newWindowThread.Start(new List<ExternalCommandLineArgument> { fileArgument, readOnlyArgument });
        }

        private void ThreadStartingPoint(object args)
        {
            var argsList = args as List<ExternalCommandLineArgument>;
            var fileArgument = argsList[0];
            var readOnlyArgument = argsList[1];

            var viewer = new FileViewer();
            viewer.LoadFileContents(fileArgument.Values[0]);
            viewer.SetReadOnly(readOnlyArgument != null);
            viewer.Show();
            System.Windows.Threading.Dispatcher.Run();
        }
    }
}
