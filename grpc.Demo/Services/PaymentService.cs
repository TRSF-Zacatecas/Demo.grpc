using grpc.Demo.Protos;
using Grpc.Core;

namespace grpc.Demo.Services;

public class PaymentService: Payment.PaymentBase
{
    public override Task<PaymentResponse> SendMoney(PaymentRequest request, ServerCallContext context)
    {
        return Task.FromResult(new PaymentResponse()
        {
            Message = $"Pago recibido de {request.Sender} a {request.Receiver} exitosamente",
            Status = 10
        }); 
    }
}
