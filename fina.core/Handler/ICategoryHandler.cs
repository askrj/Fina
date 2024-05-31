using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using fina.core.Models;
using fina.core.Requests.Categories;
using fina.core.Responses;

namespace fina.core.Handler
{
    public interface ICategoryHandler
    {
        Task<Response<Category?>> CreateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> UpdateAsync(UpdateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(DeleteCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(GetCategoryByIdRequest request);

        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoryRequest request);
    }
}