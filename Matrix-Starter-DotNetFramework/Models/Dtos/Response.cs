using System;

namespace Matrix_Starter_DotNetFramework.Models.Dtos
{
    public class Response<T>
    {
        public T Dto { get; set; }

        public Boolean IsValid { get; set; }

        public ResponseMessage Message { get; set; }
    }

}