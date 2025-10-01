using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KbU12Tools
{
    public class ItemData
    {
        public string Text { get; set; } = string.Empty;
        public object? Tag { get; set; }

        public override string ToString()
        {
            return Text;
        }
    }
}
