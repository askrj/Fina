using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace fina.core.Responses
{
    public class Response<TData>
    {
        private int _Code = Configuration.DefaultStatusCode;

        [JsonConstructor]
        public Response()
        {
            _Code = Configuration.DefaultStatusCode;
        }
        public Response(TData? data, int code = Configuration.DefaultStatusCode, string? message = null) 
        {
            Data = data;
            _Code = code;
            Message = message;
        }
        public TData? Data { get; set; }
        public string? Message { get; set; }
        
        [JsonIgnore]
        public bool IsSuccess => _Code is >= 200 and <= 299;
    }
}