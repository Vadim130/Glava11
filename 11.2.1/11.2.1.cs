using System.Diagnostics;
public class MyAsyncClass
{
    public MyAsyncClass() 
    {
        Console.WriteLine("Constructor");
    }
    public async Task InitializeAsync()
    {
        await Task.Delay(1000);
        Console.WriteLine("InitializedAsync");
    }
}
public class Task1121
{
    public static async Task Main(string[] args)
    {
        var instance = new MyAsyncClass();
        await instance.InitializeAsync();
    }

}
