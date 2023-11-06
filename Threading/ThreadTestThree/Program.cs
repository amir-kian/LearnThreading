using System;
using System.Diagnostics;
using static System.Console;

static void CheckHttpStatus(string url)
{
    HttpClient client = new();
    var response = client.GetAsync(url).Result;
    WriteLine($"The HTTP status code of {url} is {response.StatusCode}");

}

List<string> urls = new()
{
    "https://www.google.com/",
    "https://www.duckduckgo.com/",
    "https://www.yahoo.com/",
};
List<Thread> threads = new();

urls.ForEach(url => threads.Add(new Thread(() => CheckHttpStatus(url))));

var watch = Stopwatch.StartNew();

// start the threads
threads.ForEach(thread => thread.Start());

// wait for all threads to complete
threads.ForEach(thread => thread.Join());

watch.Stop();
WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");