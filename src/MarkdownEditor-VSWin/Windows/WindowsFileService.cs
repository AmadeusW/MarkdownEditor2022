using System.Windows.Forms;
using MarkdownEditor2022.Core.Contracts;

namespace MarkdownEditor2022.VSWin.Windows
{
    internal class WindowsFileService : IFileService
    {
        public bool TryOpenFile(string initialDirectory, string initialFileName, string filter, out string fileName)
        {
            fileName = string.Empty;
            using (OpenFileDialog dialog = new())
            {
                dialog.InitialDirectory = initialDirectory;
                dialog.FileName = initialFileName;
                dialog.Filter = filter;

                if (dialog.ShowDialog() != DialogResult.OK)
                    return false;

                fileName = dialog.FileName;
                return true;
            }
        }
    }
}
