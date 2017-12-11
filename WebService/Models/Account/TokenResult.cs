using System;

namespace WebService.Models.Account
{
    public class TokenResult
    {
        public string Token { get; set; }
        public DateTime ExpireOn { get; set; }
        public double ValidFor { get; set; }
    }
}