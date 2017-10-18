using System;

namespace NinetyNineProblems.Lists.Helpers
{
    public class LengthEncodingElement<T>
    {
        public T ValueWithoutDuplicate { get; set; }

        public Tuple<int, T> ValueWithDuplicate { get; set; }
    }
}