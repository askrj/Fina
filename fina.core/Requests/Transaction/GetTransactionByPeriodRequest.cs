using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace fina.core.Requests.Transaction
{
    public class GetTransactionByPeriodRequest : Request
    {
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}