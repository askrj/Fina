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
    public class GetTransactionByIdEndpoint : Common.Api.IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        => app.MapGet("/{id}", HandleAsync)
            .WithName("Transactions: Get By Id")
            .WithSummary("Recupera uma transação")
            .WithDescription("Recupera uma transação")
            .WithOrder(4)
            .Produces<Response<Transaction?>>();

    private static async Task<IResult> HandleAsync(
        ITransactionHandler handler,
        long id)
    {
        var request = new GetTransactionByIdRequest
        {
            UserId = ApiConfiguration.UserId,
            Id = id
        };

        var result = await handler.GetByIdAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
  }
}