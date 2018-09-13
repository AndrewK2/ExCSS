namespace ExCSS {
    public interface IListSelector {
        ISelector this[int index] { get; set; }
        int Length { get; }
    }
}