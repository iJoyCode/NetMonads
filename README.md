# .NET Monads [![Build status](https://ci.appveyor.com/api/projects/status/7wwjjtewbjtfm7ec?svg=true)](https://ci.appveyor.com/project/iJoyCode/netmonads) [![codecov.io](https://codecov.io/github/iJoyCode/NetMonads/coverage.svg?branch=master)](https://codecov.io/github/iJoyCode/NetMonads?branch=master)


This library provides simple C# implementations of some common [monads](http://en.wikipedia.org/wiki/Monad_(functional_programming)).

## Maybe

```C#
match.Get(x => x.Team1).Get(x => x.Title)
```
