using Grpc.Net.Client;
using GrpcServer;

namespace GrpcClient;

class Program
{
    static async Task Main(string[] args)
    {
        using var channel = GrpcChannel.ForAddress("https://localhost:5001");
        var client = new Greeter.GreeterClient(channel);

        var reply = await client.SayHelloAsync(new HelloRequest() { Name = "World!" });
        
        Console.WriteLine(reply.Message);
        Console.ReadKey();
    }
}