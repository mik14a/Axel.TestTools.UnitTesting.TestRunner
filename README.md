Axel.TestTools.UnitTesting.TestRunner
=====================================

Easy debug your Unit Test Project with Exception Helper.

## Usage

1. Add startup object and run unit test project.

```cs
class Program : System.TestTools.UnitTesting.TestRunner
{
    static void Main(string[] args) {
        var program = new Program();
        program.Run(Assembly.GetEntryAssembly());
    }
}
```

## Licence

[WTFPL](http://www.wtfpl.net/)

## Author

[mik14a](https://github.com/mik14a)
