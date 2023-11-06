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


var watch = Stopwatch.StartNew();

urls.ForEach(url => CheckHttpStatus(url));

watch.Stop();
WriteLine($"It took {watch.Elapsed.Seconds} second(s) to complete.");