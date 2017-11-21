//-----------------------------------------------------------------------
// <copyright file="Program.cs" company="Get Started Pty Ltd">
//     © 2017 Get Started Pty Ltd. All Rights Reserved.
// </copyright>
//-----------------------------------------------------------------------

using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MovieCharacters.WebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BuildWebHost(args).Run();
        }

        public static IWebHost BuildWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>()
                .Build();
    }
}
