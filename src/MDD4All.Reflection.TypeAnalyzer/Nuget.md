Tells you at runtime what a type is.

Hand it a `Type` - or an object, and it takes the type from that - and it reports a
category: a simple value such as `int` or `string`, a nullable one such as `int?`, an
array, a list, a dictionary, another generic type such as `HashSet<T>`, or a plain
object. Alongside it comes the list of types it is built from: the element type of a
list or an array, the key and the value type of a dictionary.

It does not read the properties of an object. It says what kind of thing you are
holding, not what is inside it.

Written for programs that meet a type for the first time while running: editors that
build their interface from whatever model they are handed, and serializers that walk
an object graph they do not know beforehand.

Targets netstandard2.0.
