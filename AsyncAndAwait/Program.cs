using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net.Cache;
using System.Net.Http;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncAndAwait
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //await Task.Run(() => { Console.WriteLine("Hey"); });

            // Task t1 = Task.Run(() => SimulacijaKasnjenja("1"));
            //Task t2 = Task.Run(() => SimulacijaKasnjenja("2"));
            // Task t3 = Task.Run(() => SimulacijaKasnjenja("3"));

            Parallel.For(0, 5, i => Console.WriteLine(i));

            string[] urls =
            {
                "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSiQExr7MlvOCCkAi1lJ9bPIgMaCjx_xdIUgg&s",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fen.wikivoyage.org%2Fwiki%2FNovi_Sad&psig=AOvVaw3LjWuubnea-wdcWAVBNfrx&ust=1746110165755000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPDqy7L9_4wDFQAAAAAdAAAAABAE",
                "https://www.google.com/url?sa=i&url=https%3A%2F%2Fsr.wikipedia.org%2Fwiki%2F%25D0%25A1%25D1%2583%25D0%25B1%25D0%25BE%25D1%2582%25D0%25B8%25D1%2586%25D0%25B0&psig=AOvVaw0T1tRZNcAH4sVE5PNLwvSU&ust=1746110180276000&source=images&cd=vfe&opi=89978449&ved=0CBQQjRxqFwoTCPiIurn9_4wDFQAAAAAdAAAAABAE"
            };

            HttpClient client = new HttpClient();
            Task[] tasks = new Task[urls.Length];
            for (int i = 0;  i < urls.Length; i++)
            {
                tasks[i] = Task.Run(() => PreuzmiSliku(urls[i], client, i + 1.ToString()));
   
            }
            Task.WhenAll(tasks).Wait();

        }

        static async Task PreuzmiSliku(string url, HttpClient httpClient, string nazivFajla)
        {
            HttpResponseMessage res = httpClient.GetAsync(url).Result;
            res.EnsureSuccessStatusCode();

            File.WriteAllText($"File{nazivFajla}.zip", res.ToString());

            Console.WriteLine("Preuzimanje zavrseno");
        }

        static async Task SimulacijaKasnjenja(string naziv)
        {
            Console.WriteLine($"Pocetak metode {naziv}");
            Thread.Sleep(1000);
            Console.WriteLine($"Kraj metode {naziv}");
        }
    }
}
