using ShoppingCart.Transversal.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCart.Application.Dto
{
    public static class ResponseState<T>
    {
        public static Response<T> NotFound(string Message)
        {
            return new Response<T>
            {
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

        public static Response<T> NotFound(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NotFound
            };
        }

        public static Response<T> InternalServerError(string Message)
        {
            return new Response<T>
            {
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }

        public static Response<T> InternalServerError(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.InternalServerError
            };
        }

        public static Response<T> BadRequest(string Message)
        {
            return new Response<T>
            {
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

        public static Response<T> BadRequest(string Message, T inputData)
        {
            return new Response<T>
            {
                Data = inputData,
                IsSuccess = false,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.BadRequest
            };
        }

        public static Response<T> OK(string Message)
        {
            return new Response<T>
            {
                IsSuccess = true,
                Message = string.IsNullOrEmpty(Message) ? "Success" : Message,
                StatusCode = System.Net.HttpStatusCode.OK
            };
        }

        public static Response<T> OK(string Message, T inputData, int rowCount = 0)
        {
            return new Response<T>
            {
                Data = inputData,
                IsSuccess = true,
                Message = string.IsNullOrEmpty(Message) ? "Success" : Message,
                StatusCode = System.Net.HttpStatusCode.OK,
                RowCount = rowCount
            };
        }

        public static Response<T> NoContent(string Message)
        {
            return new Response<T>
            {
                IsSuccess = true,
                Message = Message,
                StatusCode = System.Net.HttpStatusCode.NoContent
            };
        }
    }
}
