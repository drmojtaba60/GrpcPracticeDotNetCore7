using Grpc.Net.Client;
using GrpcMyPracticeService;


Console.WriteLine("Enter your name : ");
var name = Console.ReadLine();
Console.WriteLine("Enter your email : ");
var email = Console.ReadLine();
Console.WriteLine("Enter your mobile : ");
var mobile = Console.ReadLine();
Console.WriteLine("Enter your Age : ");
var age = Convert.ToInt32(Console.ReadLine());

using var channel = GrpcChannel.ForAddress("https://localhost:7071");
var client = new Greeter.GreeterClient(channel);
var reply = await client.SayHelloAsync(new HelloRequest { Name = name ,Email =email,Mobile =mobile,Age =age});
Console.WriteLine("Greeting: " + reply.Message);
Console.ReadLine();
//
// class Program
// {
//     static async Task Main(string[] args)
//     {
//         using var channel = GrpcChannel.ForAddress("https://localhost:7071");
//         var client = new Greeter.GreeterClient(channel);
//         var reply = await client.SayHelloAsync(new HelloRequest { Name = "Mojtaba Shaghi" ,Email = "mojtaba.shagi@gmail.com",Mobile = "09195873517",Age = 42});
//         Console.WriteLine("Greeting: " + reply.Message);
//     }
// }