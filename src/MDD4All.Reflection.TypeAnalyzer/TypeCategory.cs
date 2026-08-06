namespace MDD4All.Reflection
{
    public enum TypeCategory
    {
        /// <summary>
        /// The initial state before analysis, or the state if 'null' was passed as the type to analyze.
        /// </summary>
        Null = 0,

        /// <summary>
        /// A complex type that is not a collection (e.g., a standard class).
        /// </summary>
        None = 10,

        /// <summary>
        /// A simple data type (e.g., int, string, bool, decimal, DateTime, Enum).
        /// </summary>
        Simple = 20,

        /// <summary>
        /// A simple data type that is nullable (e.g., int?, bool?).
        /// </summary>
        SimpleNullable = 21,

        /// <summary>
        /// A standard array (e.g., string[]).
        /// </summary>
        Array = 35,

        /// <summary>
        /// Represents a type that implements IList&lt;T&gt;.
        /// IList&lt;T&gt; inherits from ICollection&lt;T&gt; and IEnumerable&lt;T&gt; (enables 'foreach').
        /// Key implementations: List&lt;T&gt;, ObservableCollection&lt;T&gt;, Collection&lt;T&gt;.
        /// </summary>
        IList = 40,

        /// <summary>
        /// Represents a type that implements IDictionary&lt;TKey, TValue&gt;.
        /// IDictionary&lt;TKey, TValue&gt; inherits from IEnumerable&lt;KeyValuePair&lt;TKey, TValue&gt;&gt; (enables 'foreach').
        /// Key implementations: Dictionary&lt;TKey, TValue&gt;, SortedDictionary&lt;TKey, TValue&gt;, ConcurrentDictionary&lt;TKey, TValue&gt;.
        /// </summary>
        IDictionary = 45,

        /// <summary>
        /// Another generic type that is neither an IList nor an IDictionary (e.g., HashSet&lt;T&gt;, Queue&lt;T&gt;).
        /// </summary>
        OtherGenericType = 80,

        /// <summary>
        /// An error occurred during analysis.
        /// </summary>
        Error = 90
    }
}
