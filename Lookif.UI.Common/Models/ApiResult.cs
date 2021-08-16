using Newtonsoft.Json;

namespace Lookif.UI.Common.Models
{
    public class ApiResult
    {
        /// <summary>
        /// Means If this Request was Successful
        /// </summary>
        public bool IsSuccess { get; set; }


        /// <summary>
        /// What is return Code
        /// </summary>
        public string StatusCode { get; set; }



        /// <summary>
        /// Show If there is an extra information
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }

    

   
    }

    public class ApiResult<TData> : ApiResult
       where TData : class
    {


        /// <summary>
        /// This Will Show attached Data if it is needed
        /// </summary>
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public TData Data { get; set; }
    }


  
}
