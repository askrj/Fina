using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fina.core.Handler;
using fina.core.Models;
using fina.core.Requests.Transaction;
using fina.core.Responses;

namespace Fina.Api.Endpoints.Transactions
{
    public class CreateTransactionEndpoint : Common.Api.IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        => app.MapPost("/", HandleAsync)
            .WithName("Transactions: Create")
            .WithSummary("Cria uma nova transação")
            .WithDescription("Cria uma nova transação")
            .WithOrder(1)
            .Produces<Response<Transaction?>>();

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        CreateTransactionRequest request)
    {
        request.UserId = ApiConfiguration.UserId;
        var result = await handler.CreateAsync(request);
        return result.IsSuccess
            ? TypedResults.Created($"/{result.Data?.Id}", result)
            : TypedResults.BadRequest(result.Data);
    }
  }
}