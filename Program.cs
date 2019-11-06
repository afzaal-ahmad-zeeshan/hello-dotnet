using System;
using Sentry;

namespace hello_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SentrySdk.Init("https://<hidden>@sentry.io/<hidden>"))
            {
                int a = 1;
                int b = 0;
                Console.WriteLine(a / b);
            }
        }
    }
}
