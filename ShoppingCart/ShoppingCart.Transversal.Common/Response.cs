using System.Net;

namespace ShoppingCart.Transversal.Common
{
    public  class Response<T>
    {
        public T? Data { get; set; }
        public bool IsSuccess { get; set; }
        public string? Message { get; set; }
        public HttpStatusCode StatusCode { get; set; }
        public int RowCount { get; set; }
    }
}
