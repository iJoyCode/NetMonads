# .NET Monads

This library provides simple C# implementations of some common [monads](http://en.wikipedia.org/wiki/Monad_(functional_programming)).

## Maybe

```C#
match.Get(x => x.Team1).Get(x => x.Title)
```