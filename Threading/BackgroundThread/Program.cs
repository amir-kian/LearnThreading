static void DoWork()
{
    for (int i = 0; i < 5; i++)
    {
        Thread.Sleep(100);
        Console.WriteLine("Background thread running...");

    }
}

var t = new Thread(DoWork);
t.IsBackground = true;
t.Start();


// Do some work in the main thread
for (int i = 0; i < 2; i++)
{
    Thread.Sleep(100);
    Console.WriteLine("Main thread running...");
}