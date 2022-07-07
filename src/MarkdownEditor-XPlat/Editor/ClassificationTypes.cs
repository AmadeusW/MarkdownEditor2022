using System.ComponentModel.Composition;
using Microsoft.VisualStudio.Language.StandardClassification;
using Microsoft.VisualStudio.Text.Classification;
using Microsoft.VisualStudio.Utilities;

namespace MarkdownEditor2022
{
    public static class ClassificationTypes
    {
        public const string MarkdownBold = "md_bold";
        public const string MarkdownItalic = "md_italic";
        public const string MarkdownStrikethrough = "md_strikethrough";
        public const string MarkdownHeader = "md_header";
        public const string MarkdownCode = "md_code";
        public const string MarkdownQuote = "md_quote";
        public const string MarkdownHtml = "md_html";
        public const string MarkdownLink = "md_link";
        public const string MarkdownComment = PredefinedClassificationTypeNames.Comment;

        [Export, Name(MarkdownBold)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationBold { get; set; }

        [Export, Name(MarkdownItalic)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationItalic { get; set; }

        [Export, Name(MarkdownStrikethrough)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationStrikethrough { get; set; }

        [Export, Name(MarkdownHeader)]
        [BaseDefinition(PredefinedClassificationTypeNames.SymbolDefinition)]
        public static ClassificationTypeDefinition MarkdownClassificationHeader { get; set; }

        [Export, Name(MarkdownCode)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationCode { get; set; }

        [Export, Name(MarkdownQuote)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationQuote { get; set; }

        [Export, Name(MarkdownHtml)]
        [BaseDefinition(PredefinedClassificationTypeNames.MarkupNode)]
        public static ClassificationTypeDefinition MarkdownClassificationHtml { get; set; }

        [Export, Name(MarkdownLink)]
        [BaseDefinition(PredefinedClassificationTypeNames.Text)]
        public static ClassificationTypeDefinition MarkdownClassificationLink { get; set; }
    }
}
