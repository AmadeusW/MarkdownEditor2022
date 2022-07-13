namespace MarkdownEditor2022
{
    public sealed class Constants
    {
        public const string LanguageName = "Markdown";
        public const string FileExtension = ".md";
        public static bool IsTest = false;
        public const string MarketplaceId = "MadsKristensen.MarkdownEditor2";
    }

    // Copied from source.extension.cs
    internal sealed class Vsix
    {
        public const string Id = "MarkdownEditor2022.2347dc70-1875-4775-bf48-f2b9fdfee8d4";
        public const string Name = "Markdown Editor v2";
        public const string Description = @"A full featured Markdown editor with live preview and syntax highlighting. Supports GitHub flavored Markdown.";
        public const string Language = "en-US";
        public const string Version = "2.0.1003";
        public const string Author = "Mads Kristensen";
        public const string Tags = "markdown";
    }

    // Copied from VSCommandTable.cs
    internal sealed class PackageGuids
    {
        public const string EditorFactoryString = "24510b54-a648-4d69-a6c5-f68cbdf07546";
        public static Guid EditorFactory = new Guid(EditorFactoryString);

        public const string MarkdownEditor2022String = "0b1dfe17-2eb2-4fcc-8054-b6ab002a579d";
        public static Guid MarkdownEditor2022 = new Guid(MarkdownEditor2022String);
    }
}