using Grpc.Net.Client;

using grpc.Demo;
using grpc.Demo.Protos;


// See https://aka.ms/new-console-template for more information
Console.WriteLine("Comunicandome con el grpc");


PaymentRequest request = new PaymentRequest()
{
    Id = 2,
    Sender = "Miguel de Lys",
    Receiver = "Ubisoft",
    Amount = 200
};

var channel = GrpcChannel.ForAddress("http://localhost:5247");
var client = new Payment.PaymentClient(channel);
var result = await client.SendMoneyAsync(request);

Console.WriteLine(result.Message);



