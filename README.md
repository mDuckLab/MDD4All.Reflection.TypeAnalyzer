# MDD4All.Reflection.TypeAnalyzer

Categorizes .NET types via reflection into simple value, array, list,
dictionary, or complex object. No external dependencies.

## Usage

```csharp
// Option 1: you already have a Type
TypeAnalyzer analyzer = TypeAnalyzer.CreateAnalyst(typeof(List<int>));
TypeCategory category = analyzer.TypeCategory;         // TypeCategory.IList
List<Type> underlyingTypes = analyzer.UnderlyingTypes; // contains typeof(int)

// Option 2: you have an object instance instead (works even if it's null)
TypeAnalyzer instanceAnalyzer = TypeAnalyzer.CreateAnalyst(someObject);

// re-analyze the same instance for a different type
instanceAnalyzer.Analyze(typeof(Dictionary<string, int>));

// static checks without creating an instance
bool isSimple = TypeAnalyzer.IsSimpleDataType(typeof(int));      // true
bool isNullable = TypeAnalyzer.IsSimpleNullableType(typeof(int?)); // true
```

`TypeAnalyzer` also has a copy constructor (`new TypeAnalyzer(other)`) and
convenience checks on the instance itself (`IsSimple()`,
`IsSimpleNullable()`, `IsSimpleOrSimpleNullable()`).

## What it's useful for

It's useful anywhere you need to figure out what kind of thing you're
looking at before deciding how to handle it, like generating UI for an
object graph, writing a generic (de)serializer, or building a generic
object-graph walker.

The tricky part in all of those is `null`. `obj.GetType()` needs a live
instance. A `null` reference carries no type information at runtime.
`CreateAnalyst<T>(T obj)` sidesteps this with a generic entry point. If `obj`
is `null`, it falls back to the compile-time type `T`, so an uninitialized
property still gets classified correctly instead of blowing up or being
skipped.

The classification checks run in order. First a simple type, then an array,
then a generic collection (`IList` or `IDictionary`, checked via interface,
not the concrete `List`/`Dictionary` class). Everything else counts as a
"complex object". For arrays, lists and dictionaries, the element/key/value
types are also collected in `UnderlyingTypes`.

## License

MIT, see [LICENSE](LICENSE).
