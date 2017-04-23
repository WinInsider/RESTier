using System;
using Microsoft.Owin.Hosting;

namespace RestireCore
{
	class Program
    {
        static void Main(string[] args)
        {
			var options = new StartOptions("http://localhost:8080/")
			{
				ServerFactory = "WinInsider.Owin.Host.SocketListener"
			};

			using (WebApp.Start<Startup>(options))
			{
				Console.WriteLine("Hello World!");
				Console.ReadLine();
			}
        }
    }
}
