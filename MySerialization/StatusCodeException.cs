using System;
using System.Collections.Generic;
using System.Text;

namespace MySerialization
{
    public class StatusCodeException : Exception
    {
        public StatusCode StatusCode { get; set; }

        public StatusCodeException(StatusCode statusCode)
        {
            StatusCode = statusCode;
        }

        public StatusCodeException(StatusCode statusCode, string message)
            : base(message)
        {
            StatusCode = statusCode;
        }

        public StatusCodeException(StatusCode statusCode, string message, Exception innerException)
            : base(message, innerException)
        {
            StatusCode = statusCode;
        }
    }

    public enum StatusCode
    {
        Success = 0,
        InvalidFunction = 1
    }
}