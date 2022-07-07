using System.ComponentModel.Composition;
using System.Windows;
using System.Windows.Media;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace MarkdownEditor2022.VSWin.Editor
{
    internal static class WpfClassificationTypes
    {
        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownBold)]
        [Name(ClassificationTypes.MarkdownBold)]
        internal sealed class MarkdownBoldFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownBoldFormatDefinition()
            {
                IsBold = true;
                DisplayName = "Markdown Bold";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownItalic)]
        [Name(ClassificationTypes.MarkdownItalic)]
        internal sealed class MarkdownItalicFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownItalicFormatDefinition()
            {
                IsItalic = true;
                DisplayName = "Markdown Italic";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownStrikethrough)]
        [Name(ClassificationTypes.MarkdownStrikethrough)]
        internal sealed class MarkdownStrikethroughFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownStrikethroughFormatDefinition()
            {
                TextDecorations = new TextDecorationCollection()
            {
                new TextDecoration(){ Location = TextDecorationLocation.Strikethrough }
            };
                DisplayName = "Markdown Strikethrough";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownHeader)]
        [Name(ClassificationTypes.MarkdownHeader)]
        [UserVisible(true)]
        internal sealed class MarkdownHeaderFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownHeaderFormatDefinition()
            {
                IsBold = true;
                DisplayName = "Markdown Header";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownCode)]
        [Name(ClassificationTypes.MarkdownCode)]
        [UserVisible(true)]
        internal sealed class MarkdownCodeFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownCodeFormatDefinition()
            {
                DisplayName = "Markdown Code";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownQuote)]
        [Name(ClassificationTypes.MarkdownQuote)]
        [UserVisible(true)]
        internal sealed class MarkdownQuoteFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownQuoteFormatDefinition()
            {
                BackgroundColor = Colors.LightGray;
                BackgroundOpacity = .4;
                DisplayName = "Markdown Quote";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownHtml)]
        [Name(ClassificationTypes.MarkdownHtml)]
        [UserVisible(true)]
        internal sealed class MarkdownHtmlFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownHtmlFormatDefinition()
            {
                DisplayName = "Markdown HTML";
            }
        }

        [Export(typeof(EditorFormatDefinition))]
        [ClassificationType(ClassificationTypeNames = ClassificationTypes.MarkdownLink)]
        [Name(ClassificationTypes.MarkdownLink)]
        [UserVisible(true)]
        [Order(After = Priority.High)]
        internal sealed class MarkdownLinkFormatDefinition : ClassificationFormatDefinition
        {
            public MarkdownLinkFormatDefinition()
            {
                TextDecorations = new TextDecorationCollection()
            {
                new TextDecoration(){ Location = TextDecorationLocation.Underline, PenOffset = 2 }
            };
                DisplayName = "Markdown Link";
            }
        }
    }
}
