# Cappy.SDK

[Cappy](https://cappy.se/) is a service to offer flexible pay to employees. The service gives an ongoing control over time worked and earned salary, as well as the possibility to withdraw part of your earned salary when the employee needs it and between regular paydays. Everything available around the clock, every day of the year, in a user-friendly mobile app.

This SDK helps .NET developers integrate with Cappy by using the underlying Cappy Integration API.

## Installation

`nuget install Cappy.SDK`

## Usage

**Add Cappy SDK in Program.cs**

```
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddCappySdk();
```

This will add a scoped DI registration to the current ServiceCollection so that the main service can be injected as such:

```
public class MyController
{
    private readonly ICappyService _cappyService;

    public MyController(ICappyService cappyService)
    {
        //Scoped service
        _cappyService = cappyService;
    }
}
```


## Dependencies

## License

The MIT License (MIT)

Permission is hereby granted, free of charge, to any person obtaining a copy of this software and associated documentation files (the "Software"), to deal in the Software without restriction, including without limitation the rights to use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of the Software, and to permit persons to whom the Software is furnished to do so, subject to the following conditions:

The above copyright notice and this permission notice shall be included in all copies or substantial portions of the Software.

THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.