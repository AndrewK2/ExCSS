using System.Collections.Generic;
using System.IO;

namespace ExCSS
{
    internal sealed class ListSelector : Selectors, ISelector, IListSelector {
        public bool IsInvalid { get; internal set; }

        public IList<ISelector> Selectors {
            get {
                return _selectors;
            }
        }

        public override void ToCss(TextWriter writer, IStyleFormatter formatter)
        {
            if (_selectors.Count <= 0)
            {
                return;
            }
            writer.Write(_selectors[0].Text);

            for (var i = 1; i < _selectors.Count; i++)
            {
                writer.Write(Symbols.Comma);
                writer.Write(_selectors[i].Text);
            }
        }
    }
}