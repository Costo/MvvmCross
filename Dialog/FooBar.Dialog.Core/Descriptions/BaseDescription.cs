using System.Collections.Generic;

namespace Foobar.Dialog.Core.Descriptions
{
    public class BaseDescription
    {
        public string OnlyFor { get; set; }
        public string NotFor { get; set; }
        public Dictionary<string, object> Properties { get; set; }
    }
}