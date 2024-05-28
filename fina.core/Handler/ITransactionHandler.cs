using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Transactions;
using fina.core.Requests.Transaction;
using fina.core.Responses;

namespace fina.core.Handler
{
    public interface ITransactionHandler
    {
        Task<Response<Transaction?>> CreateAsync(CreateTransactionRequest request);
        Task<Response<Transaction?>> UpdateAsync(CreateTransactionRequest request);
        Task<Response<Transaction?>> DeleteAsync(CreateTransactionRequest request);
        Task<Response<Transaction?>> GetByIdAsync(CreateTransactionRequest request);
        Task<PagedResponse<List<Transaction>>> GetByPeriodAsync(GetTransactionByPeriodRequest request);
    }
}