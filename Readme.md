# SimpleLog

> So simple logging library that a cat can use

![really](/cat.png)

## How to use

```csharp
using static SimpleLog.Logger;

Log(() => randomVariable);
Log(() => $"What's {1+2}?");
Log(() => DoSomething(42, 42));

var returnedValue = NotPureFunction();
Log(() => NotPureFunction(), valueIfNeeded: returnedValue);

LoggingFormat = "{0}: {1}\n";

Log(() => "logMe");
```
