using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using Org.BouncyCastle.Asn1.Cms;

namespace Ogani.WebUI
{
    public class Program
    {
        internal static string[] policies = null;

        public static void Main(string[] args)
        {

            if (policies == null)
            {

                var controllers = Assembly.GetExecutingAssembly().GetTypes()
                    .Where(t => typeof(Controller).IsAssignableFrom(t))
                    .ToList();
                policies = controllers.SelectMany(c => c.GetMethods()
                .Where(m => m.IsDefined(typeof(AuthorizeAttribute)) &&
                !m.IsDefined(typeof(NonActionAttribute))))
                    .SelectMany(m => m.GetCustomAttributes(true)
                    .Where(a => typeof(AuthorizeAttribute).IsInstanceOfType(a)
                    && !string.IsNullOrWhiteSpace((a as AuthorizeAttribute)?.Policy)))
                    .Select(a => (a as AuthorizeAttribute)?.Policy)
                    .Distinct()
                    .ToArray(); 
            }

            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}

