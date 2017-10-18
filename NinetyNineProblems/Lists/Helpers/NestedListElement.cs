using System.Collections.Generic;

namespace NinetyNineProblems.Lists.Helpers
{
    public class NestedListElement<T>
    {
        public T Value { get; set; }

        public List<NestedListElement<T>> ListValue { get; set; }
    }
}