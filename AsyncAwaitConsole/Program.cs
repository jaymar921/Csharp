

using Newtonsoft.Json;

namespace AsyncAwaitConsole
{
    public class Program
    {

        private static CancellationTokenSource cancellationToken;
        public static async Task Main(string[] args)
        {
            Console.WriteLine("Aynchronous Programming");

            cancellationToken = new CancellationTokenSource();

            // cancellationToken.Cancel();
            await RunGetTaskAysncMethod3(cancellationToken.Token);
        }

        // method 1 of implementing cancellation token
        public static Task RunGetTaskAysncMethod1(CancellationToken cancellationToken)
        {
            return Task.Run(async () =>
            {
                Console.WriteLine("Calling RunGetTaskAysnc()");

                using (var client = new HttpClient())
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Task was cancelled");
                        return;
                    }
                        

                    var response = await client.GetAsync($"http://103.44.234.157:5000/PSITS/api/mcs");

                    var content = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<object>(content);

                    Console.WriteLine(data);
                }
            });
        }

        // method 2 of implementing cancellation token
        public static Task RunGetTaskAysncMethod2(CancellationToken cancellationToken)
        {
            return Task.Run(async () =>
            {
                Console.WriteLine("Calling RunGetTaskAysnc()");

                using (var client = new HttpClient())
                {
                    var response = await client.GetAsync($"http://103.44.234.157:5000/PSITS/api/mcs");

                    var content = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<object>(content);

                    Console.WriteLine(data);
                }
            }, cancellationToken);
        }

        // method 3 of implementing cancellation token with ContinueWith method, once the first task was thrown, it will
        // no longer continue with the other task
        public static Task RunGetTaskAysncMethod3(CancellationToken cancellationToken)
        {
            return Task.Run(async () =>
            {
                Console.WriteLine("Calling RunGetTaskAysnc()");

                using (var client = new HttpClient())
                {
                    if (cancellationToken.IsCancellationRequested)
                    {
                        Console.WriteLine("Task was cancelled");
                        throw new OperationCanceledException();
                    }


                    var response = await client.GetAsync($"http://103.44.234.157:5000/PSITS/api/mcs");

                    var content = await response.Content.ReadAsStringAsync();

                    var data = JsonConvert.DeserializeObject<object>(content);

                    Console.WriteLine(data);
                }
            }).ContinueWith((completedTask) =>
            {
                Console.WriteLine("Another Task was called successfully");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);
        }

        // get task async test
        public static async Task GetAsyncTest()
        {
            Console.WriteLine("Calling GetAsyncTest()");

            using(var client = new HttpClient())
            {
                var response = await client.GetAsync($"http://103.44.234.157:5000/PSITS/api/mcs");

                var content = await response.Content.ReadAsStringAsync();

                var data = JsonConvert.DeserializeObject<object>(content);

                Console.WriteLine(data);
            }
            
        }
    }
}