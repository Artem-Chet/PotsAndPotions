using PotsAndPotions.Core.Engine;
using System.Diagnostics;

namespace PotsAndPotions.Simulation
{
    internal class Program
    {
        static void Main(string[] args)
        {            
            var numberOfGames = 10000;
            var concurrencyLimit = 12;

            var synchronousSimulationStopwatch = new Stopwatch();
            synchronousSimulationStopwatch.Start();

            var synchronousScores = new int[numberOfGames];
            RunSynchronously(synchronousScores);

            synchronousSimulationStopwatch.Stop();

            Console.WriteLine($"{numberOfGames} games simulated on single thread in {synchronousSimulationStopwatch.ElapsedMilliseconds}ms");

            var parallelSimulationStopwatch = new Stopwatch();
            parallelSimulationStopwatch.Start();

            var parallelScores = new int[numberOfGames];
            RunParallel(parallelScores, concurrencyLimit);

            parallelSimulationStopwatch.Stop();

            Console.WriteLine($"{numberOfGames} games simulated on {concurrencyLimit} threads in {parallelSimulationStopwatch.ElapsedMilliseconds}ms");
        }

        private static void RunSynchronously(int[] scores)
        {
            for (int x = 0; x < scores.Length; x++)
            {
                var game = new Game();

                scores[x] = game.Run();
            }
        }

        private static void RunParallel(int[] scores, int concurrencyLimit)
        {

            var semaphore = new SemaphoreSlim(concurrencyLimit);

            for (int x = 0; x < scores.Length; x++)
            {
                var xCopy = x;
                semaphore.Wait();
                Task.Factory.StartNew(() =>
                {
                    var game = new Game();

                    scores[xCopy] = game.Run();
                })
                .ContinueWith(t => semaphore.Release());
            }
        }
    }
}