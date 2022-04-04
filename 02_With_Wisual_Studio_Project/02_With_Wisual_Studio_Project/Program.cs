using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02_With_Wisual_Studio_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Buras� uygulaman�n ba�lang�� noktas�
            //Geriye IHostBuilder t�r�nden veri d�nd�rerek yapar
            //alttaki metot
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
