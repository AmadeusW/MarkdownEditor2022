using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using Markdig.Syntax;
using Microsoft.VisualStudio.Text;
using Slugify;

namespace MarkdownEditor2022
{
    [Command(PackageIds.GenerateTOC)]
    internal sealed class GenerateTocCommand : BaseCommand<GenerateTocCommand>
    {
        protected override Task InitializeCompletedAsync()
        {
            Command.Supported = false;
            return base.InitializeCompletedAsync();
        }        

        protected override async Task ExecuteAsync(OleMenuCmdEventArgs e)
        {
            DocumentView docView = await VS.Documents.GetActiveDocumentViewAsync();
            Document doc = docView?.TextBuffer?.GetDocument();

            if (doc == null)
            {
                return;
            }

            int position = docView.TextView.Caret.Position.BufferPosition;
            string toc = TableOfContents.Generate(docView, doc, position);

            SnapshotSpan selection = docView.TextView.Selection.SelectedSpans.First();
            docView.TextBuffer.Replace(selection, toc);
        }
    }
}
