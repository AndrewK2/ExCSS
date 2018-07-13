
namespace ExCSS
{
    public interface IMediaRule : IConditionRule
    {
        MediaList Media { get; }

        void RemoveChild(IStylesheetNode child);
    }
}