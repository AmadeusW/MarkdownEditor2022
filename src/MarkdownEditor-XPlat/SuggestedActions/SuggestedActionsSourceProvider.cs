using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.Intellisense;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Text.Editor;
using Microsoft.VisualStudio.Utilities;
using Microsoft.VisualStudio.Text.Tagging;
using MarkdownEditor2022.Core.Contracts;

namespace MarkdownEditor2022
{
    [Export(typeof(ISuggestedActionsSourceProvider))]
    [Name("Markdown Suggested Actions")]
    [ContentType(Constants.LanguageName)]
    internal class SuggestedActionsSourceProvider : ISuggestedActionsSourceProvider
    {
        [Import]
        internal ITextDocumentFactoryService _textDocumentFactoryService = null;

        [Import]
        internal IFileService _platformFileService = null;

        public ISuggestedActionsSource CreateSuggestedActionsSource(ITextView textView, ITextBuffer textBuffer)
        {

            if (_textDocumentFactoryService.TryGetTextDocument(textView.TextBuffer, out ITextDocument document))
            {
                return textView.Properties.GetOrCreateSingletonProperty(() =>
                    new SuggestedActionsSource(textView, document.FilePath, this));
            }

            return null;
        }
    }
}
