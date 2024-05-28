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
        Task<Response<Category?>> UpdateAsync(CreateCategoryRequest request);
        Task<Response<Category?>> DeleteAsync(CreateCategoryRequest request);
        Task<Response<Category?>> GetByIdAsync(CreateCategoryRequest request);

        Task<PagedResponse<List<Category>>> GetAllAsync(GetAllCategoryRequest request);
    }
}