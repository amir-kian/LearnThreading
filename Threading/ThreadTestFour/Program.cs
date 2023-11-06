using System.Diagnostics;
using static System.Console;


static void DoWork(string message)
{
    Thread.Sleep(1000);
    WriteLine(message);

}

var watch = Stopwatch.StartNew();

var t1 = new Thread(() => DoWork("Hi"));
var t2 = new Thread(() => DoWork("Bye"));


// start both threads
t1.Start();
t2.Start();

// wait for both threads completed
t1.Join();
t2.Join();


watch.Stop();
WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");