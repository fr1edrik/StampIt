using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StampIt
{
    class ComboBinder
    {
        public Dictionary<int, string> Source { get; private set; }

        public ComboBinder()
        {
            Source = new Dictionary<int, string>();
        }

        public void AddEntries(int index, string val)
        {
            Source.Add(index, val);
        }

        public void AddEntries(params (int, string)[] entries) =>
            Array.ForEach(entries, entry => Source.Add(entry.Item1, entry.Item2));


        public BindingSource GetBindingSource() => new BindingSource(Source, null);
    }
}
