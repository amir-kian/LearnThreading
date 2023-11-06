using System.Diagnostics;
using static System.Console;


static void DoWork()
{
    WriteLine("Doing the work...");
    Thread.Sleep(1000);
    WriteLine("done");
}

var watch = Stopwatch.StartNew();

DoWork();
DoWork();


watch.Stop();
WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");
