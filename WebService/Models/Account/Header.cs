using System.Web.Services.Protocols;

namespace WebService.Models.Account
{
    public class Header : SoapHeader
    {
        public string Username;
        public string Password;
    }

}