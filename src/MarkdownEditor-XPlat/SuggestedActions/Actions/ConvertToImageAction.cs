using System.IO;
using System.Threading;
using MarkdownEditor2022.Core.Contracts;
using Microsoft.VisualStudio.Imaging;
using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Text;

namespace MarkdownEditor2022
{
    class ConvertToImageAction : BaseSuggestedAction
    {
        private SnapshotSpan _span;
        private const string _format = "![{0}]({1})";
        private readonly string _file;
        private readonly IFileService _platformFileService;

        public ConvertToImageAction(SnapshotSpan span, string file, IFileService platformFileService)
        {
            _span = span;
            _file = file;
            _platformFileService = platformFileService;
        }

        public override string DisplayText
        {
            get { return "Convert To Image"; }
        }

        public override ImageMoniker IconMoniker
        {
            get { return KnownMonikers.Image; }
        }

        public override void Execute(CancellationToken cancellationToken)
        {
            string fileName;
            string dir = Path.GetDirectoryName(_file);

            if (!TryGetFileName(dir, out fileName))
                return;

            string relative = PackageUtilities.MakeRelative(_file, fileName).Replace("\\", "/");

            string text = string.Format(_format, _span.GetText(), Uri.EscapeUriString(relative));

            using (ITextEdit edit = _span.Snapshot.TextBuffer.CreateEdit())
            {
                edit.Replace(_span, text);
                edit.Apply();
            }
        }

        private bool TryGetFileName(string initialDirectory, out string fileName)
        {
            return this._platformFileService.TryOpenFile(
                initialDirectory,
                initialFileName: "Monikers",
                filter: "Image files (*.jpg, *.jpeg, *.gif, *.png) | *.jpg; *.jpeg; *.gif; *.png",
                out fileName);
        }
    }
}
