using Markdig.Syntax;
using Microsoft.VisualStudio.Text;
using Microsoft.VisualStudio.Threading;

namespace MarkdownEditor2022
{
    public static class ExtensionMethods
    {
        public static Document GetDocument(this ITextBuffer buffer)
        {
            return buffer.Properties.GetOrCreateSingletonProperty(() => new Document(buffer));
        }

        public static Span ToSpan(this MarkdownObject item)
        {
            return new Span(item.Span.Start, item.Span.Length);
        }

        public static void ThrowIfNotOnUiThread(this JoinableTaskContext joinableTaskContext)
        {
            if (!joinableTaskContext.IsOnMainThread)
            {
                throw new InvalidOperationException($"This method must be callled on the UI thread.");
            }
        }

        public static void ThrowIfOnUiThread(this JoinableTaskContext joinableTaskContext)
        {
            if (joinableTaskContext.IsOnMainThread)
            {
                throw new InvalidOperationException($"This method must be callled off the UI thread.");
            }
        }
    }
}
