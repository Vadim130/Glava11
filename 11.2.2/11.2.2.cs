#if BAD_CODE
class MyAsyncClass
{
 public MyAsyncClass()
    {
        InitializeAsync();
    }
    // ПЛОХОЙ КОД!!
    private async void InitializeAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
    }
}
#else
class MyAsyncClass
{
    private MyAsyncClass()
    {
    }
    private async Task<MyAsyncClass> InitializeAsync()
    {
        await Task.Delay(TimeSpan.FromSeconds(1));
        return this;
    }
    public static Task<MyAsyncClass> CreateAsync()
    {
        var result = new MyAsyncClass();
        return result.InitializeAsync();
    }
}
#endif
public class Task1122
{
    public static async Task Main(string[] args)
    {
        MyAsyncClass ac = await MyAsyncClass.CreateAsync();
    }

}
