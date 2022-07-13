namespace MarkdownEditor2022.Core.Contracts
{
    public interface IFileService
    {
        bool TryOpenFile(string initialDirectory, string initialFileName, string filter, out string fileName);
    }
}
