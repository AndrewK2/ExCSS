using System;

namespace ExCSS.Formatting {
    public sealed class DefaultFormatters {
        private static readonly Lazy<DefaultFormatters> instance = new Lazy<DefaultFormatters>(() => new DefaultFormatters());
        private Func<string, string> formatString = StringExtensions.StylesheetString;
        public static DefaultFormatters Instance => instance.Value;

        public Func<string, string> FormatString {
            get => formatString;
            set {
                if(null == formatString) {
                    throw new ArgumentNullException();
                }

                formatString = value;
            }
        }

        private DefaultFormatters() {
        }
    }
}