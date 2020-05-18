// C# tutorial: https://docs.microsoft.com/en-us/dotnet/csharp/tutorials/intro-to-csharp/

using System;

namespace build_hello_world
{
    class HelloWorld
    {
        static void Main(string[] args)
        {
            String message = "Hello, World!";
            Console.WriteLine(message);
        }
    }
}

//run: 
// dotnet run
// OR
// dotnet clean
// (check your bin!)
// dotnet build
// dotnet ./bin/Debug/netcoreapp3.1/build-hello-world.dll

// C#
// 1. compiled to an executable - can run FAST
// 2. object-oriented with strict rules 
// 3. mature and stable, powerful debugging
