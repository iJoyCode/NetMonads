# .NET Monads

This library provides simple C# implementations of some common [monads](http://en.wikipedia.org/wiki/Monad_(functional_programming)).

## `Maybe`

(a.k.a. the [maybe monad](http://en.wikipedia.org/wiki/Monad_%28functional_programming%29#The_Maybe_monad))

```C#
match.Get(x => x.Team1).Get(x => x.Title)
```