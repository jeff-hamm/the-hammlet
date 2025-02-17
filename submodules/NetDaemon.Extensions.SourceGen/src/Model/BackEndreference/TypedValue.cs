using Dunet;

namespace Hammlet.Models.BackEnd
{
    [Union]
    public partial class TypedValue<T> where T : Enum
    {
        public partial class Null : TypedValue<T>;
        public partial class UnknownValue : TypedValue<T>
        {
            public string Value { get; }
        }

        public partial class KnownValue : TypedValue<T>
        {
            public T Value { get; }
        }
    }
}
