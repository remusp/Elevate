using System.IO;
using System.Windows;

namespace Elevate.Samples.CommandLineParser.UI
{
    /// <summary>
    /// Interaction logic for Trados_Look_and_Feel.xaml
    /// </summary>
    public partial class FileViewer : Window
    {
        public FileViewer()
        {
            InitializeComponent();
        }

        public void LoadFileContents(string filePath)
        {
            tbContent.Text = File.ReadAllText(filePath);
        }

        public void SetReadOnly(bool isReadOnly)
        {
            tbContent.IsReadOnly = isReadOnly;
        }
    }
}
