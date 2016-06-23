
## Jon's C# Trivia

http://aakinshin.net/en/blog/dotnet/jon-skeet-quiz

### Q1. What constructor call can you write such that this prints True (at least on the Microsoft .NET implementation)?


```csharp
object x = new /* fill in code here */;
object y = new /* fill in code here */;
Console.WriteLine(x == y);
```

Note that it’s just a constructor call, and you can’t change the type of the variables…

### Q2. How can you make this code compile such that it calls three different method overloads?

```csharp
void Foo()
{
    EvilMethod<string>();
    EvilMethod<int>();
    EvilMethod<int?>();
}
```

### Q3. With a local variable (so no changing the variable value cunningly), how can you make this code fail on the second line?

```csharp
string text = x.ToString(); // No exception
Type type = x.GetType(); // Bang!
```

Please leave your answers below! Don't be afraid if it's wrong :) and No posting on Stack Overflow ;-).