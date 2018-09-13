namespace ExCSS {
    public interface ICombinator {
        ISelector Change(ISelector selector);
        string Delimiter { get; }
    }
}