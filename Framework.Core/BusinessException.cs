using System;

namespace Framework.Core
{
    public class BusinessException : Exception
    {
        public string Code { get; set; }

        public BusinessException(string code, string exceptionMessage) : base(exceptionMessage)
        {
            this.Code = code;
        }

        public override string ToString()
        {
            return $"{this.Message}";
        }
    }
}
