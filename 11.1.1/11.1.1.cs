
using System.Diagnostics;
interface IMyAsyncInterface
{
    Task<int> CountBytesAsync(HttpClient client, string url);
}
class MyAsyncClass : IMyAsyncInterface
{
    public async Task<int> CountBytesAsync(HttpClient client, string url)
    {
        var bytes = await client.GetByteArrayAsync(url);
        return bytes.Length;
    }
    
}

public class Task1111
{
    public static async Task Main(string[] args)
    {
        HttpClient client = new HttpClient();
        IMyAsyncInterface ac = new MyAsyncClass();
        await UseMyInterfaceAsync(client, ac);
    }
    static async Task UseMyInterfaceAsync(HttpClient client,
 IMyAsyncInterface service)
    {
        var result = await service.CountBytesAsync(client, "http://www.mail.ru");
        Trace.WriteLine(result);
    }

}