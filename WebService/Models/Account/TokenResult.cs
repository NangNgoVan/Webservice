using System;

namespace WebService.Models.Account
{
    public class TokenResult
    {
        public bool Successed { get; set; }
        public string Message { get; set; }
        public int Code { get; set; }
        public TokenData Data { get; set; }
        
        public class TokenData
        {
            public string Token { get; set; }
            public DateTime ExpireOn { get; set; }
            public double ValidFor { get; set; }
        }
    }
}