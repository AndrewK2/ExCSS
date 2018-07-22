
using ExCSS.Formatting;

namespace ExCSS
{
    internal sealed class UrlToken : Token
    {
        public UrlToken(string functionName, string data, bool valid, TextPosition position)
            : base(TokenType.Url, data, position)
        {
            IsValid = valid;
            FunctionName = functionName;
        }
        public override string ToValue()
        {
            var url = DefaultFormatters.Instance.FormatString(Data);
            return FunctionName.StylesheetFunction(url);
        }

        public bool IsValid { get; }
        public string FunctionName { get; }
    }
}