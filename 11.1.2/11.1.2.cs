
using System.Diagnostics;
interface IMyAsyncInterface
{
    Task<int> CountBytesAsync(HttpClient client, string url);
}

class MyAsyncClassStub : IMyAsyncInterface
{
    public Task<int> CountBytesAsync(HttpClient client, string url)
    {
        return Task.FromResult(13);
    }
}

public class Task1111
{
    public static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        IMyAsyncInterface ac = new MyAsyncClassStub();
        await UseMyInterfaceAsync(client, ac);
    }
    static async Task UseMyInterfaceAsync(HttpClient client,
 IMyAsyncInterface service)
    {
        var result = await service.CountBytesAsync(client, "http://www.mail.ru");
        Trace.WriteLine(result);
    }

}
