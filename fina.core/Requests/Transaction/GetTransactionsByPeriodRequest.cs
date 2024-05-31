using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fina.core.Requests.Transaction
{
    public class GetTransactionsByPeriodRequest : PagedRequest
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}