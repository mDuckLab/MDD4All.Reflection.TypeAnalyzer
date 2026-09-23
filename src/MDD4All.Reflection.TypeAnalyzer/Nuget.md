Answers what a .NET type is at runtime.

Hand it a `Type` and it tells you which kind you are holding - a simple value, an
object with properties, a list, an array or a dictionary - along with the types it is
built from. A dictionary reports its key and value type, a list its element type, an
object its properties.

Written for programs that meet a type for the first time while running: editors that
build their user interface from whatever model they are given, and serializers that
have to walk an object graph without knowing it beforehand.
