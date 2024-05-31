using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fina.core.Handler;
using fina.core.Models;
using fina.core.Requests.Categories;
using fina.core.Responses;

namespace Fina.Api.Endpoints.Categories
{
    public class UpdateCategoryEndpoint : Common.Api.IEndpoint
    {
        public static void Map(IEndpointRouteBuilder app)
        => app.MapPut("/{id}", HandleAsync)
            .WithName("Categories: Update")
            .WithSummary("Atualiza uma categoria")
            .WithDescription("Atualiza uma categoria")
            .WithOrder(2)
            .Produces<Response<Category?>>();

        private static async Task<IResult> HandleAsync(
        ICategoryHandler handler,
        UpdateCategoryRequest request,
        long id)
    {
        request.UserId = ApiConfiguration.UserId;
        request.Id = id;

        var result = await handler.UpdateAsync(request);
        return result.IsSuccess
            ? TypedResults.Ok(result)
            : TypedResults.BadRequest(result);
    }
   }
  }

