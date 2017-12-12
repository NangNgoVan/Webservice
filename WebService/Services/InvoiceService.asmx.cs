using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebService.Enum;
using WebService.Models.Account;
using WebService.Models.invoices.NewReplaceAdjustInvoice;
using WebService.Shared.Enums;
using WebService.Shared.Serialize;

namespace WebService.Services
{
    /// <inheritdoc />
    /// <summary>
    /// Summary description for InvoiceService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class InvoiceService : System.Web.Services.WebService
    {
        private static readonly string BaseUri = ConfigurationManager.AppSettings["BaseUri"];
        public Header InHeader;

        [WebMethod(Description = "New, Replace, Adjust.Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public NewReplaceAdjustInvoiceMessagesModel CreateInsuranceInvoice(NewReplaceAdjustInvoiceModel XMLINPUT)
        {

            if (string.IsNullOrEmpty(InHeader.Username) || string.IsNullOrEmpty(InHeader.Password))
                return NewReplaceAdjustInvoiceMesages(400,"Tài khoản và mật khẩu không được để trống!");

            var token = Login(new LoginModel {UserName = InHeader.Username, Password = InHeader.Password});
            if (string.IsNullOrEmpty(token))
                return NewReplaceAdjustInvoiceMesages(400, "Tài khoản hoặc mật khẩu không đúng!");
            
            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                HttpContent content = new StringContent(XMLINPUT.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/api/invoices/create-insurance", content).Result;
                var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<NewReplaceAdjustInvoiceMessagesModel>();
                return messages;
            }
        }
        
        [WebMethod(Description = "Bên gửi: Hệ thống HDĐT của EInvoice. Bên nhận: Hệ thống core bảo hiểm của CMC")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string NoticeStateChangedInsuranceInvoice(NewReplaceAdjustInvoiceMessagesModel XMLINPUT)
        {
            return "chờ bên CMS cấp link";
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public NewReplaceAdjustInvoiceMessagesModel DeleteInsuranceInvoice(NewReplaceAdjustInvoiceMessagesModel XMLINPUT)
        {
            if (string.IsNullOrEmpty(InHeader.Username) || string.IsNullOrEmpty(InHeader.Password))
                return NewReplaceAdjustInvoiceMesages(400, "Tài khoản và mật khẩu không được để trống!");

            var token = Login(new LoginModel { UserName = InHeader.Username, Password = InHeader.Password });
            if (string.IsNullOrEmpty(token))
                return NewReplaceAdjustInvoiceMesages(400, "Tài khoản hoặc mật khẩu không đúng!");

            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                HttpContent content = new StringContent(XMLINPUT.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/api/invoices/delete-insurance", content).Result;
                var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<NewReplaceAdjustInvoiceMessagesModel>();
                return messages;
            }
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public ReplaceInsuranceInvoiceMessagesModel ReplaceInsuranceInvoice(ReplaceInsuranceInvoiceModel XMLINPUT)
        {
            if (string.IsNullOrEmpty(InHeader.Username) || string.IsNullOrEmpty(InHeader.Password))
                return new ReplaceInsuranceInvoiceMessagesModel();

            var token = Login(new LoginModel { UserName = InHeader.Username, Password = InHeader.Password });
            if (string.IsNullOrEmpty(token))
                return new ReplaceInsuranceInvoiceMessagesModel();

            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                HttpContent content = new StringContent(XMLINPUT.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/api/invoices/replace-insurance", content).Result;
                var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<ReplaceInsuranceInvoiceMessagesModel>();
                return messages;
            }
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public CertificatesMessagesModel ProcessCertificates(CertificatesModel XMLINPUT)
        {
            if (string.IsNullOrEmpty(InHeader.Username) || string.IsNullOrEmpty(InHeader.Password))
                return new CertificatesMessagesModel();

            var token = Login(new LoginModel { UserName = InHeader.Username, Password = InHeader.Password });
            if (string.IsNullOrEmpty(token))
                return new CertificatesMessagesModel();

            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");
                HttpContent content = new StringContent(XMLINPUT.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/api/invoices/process-certificates", content).Result;
                var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<CertificatesMessagesModel>();
                return messages;
            }
        }

        [WebMethod(Description = "chưa rõ yêu cầu")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string EInvoiceVerifyInvoices()
        {
            return "Hello World";
        }

        [WebMethod(Description = "chưa rõ yêu cầu")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string EInvoiceVerifyCertificates()
        {
            return "Hello World";
        }

        private static NewReplaceAdjustInvoiceMessagesModel NewReplaceAdjustInvoiceMesages(int errorCode,string errorDesc)
        {
            return new NewReplaceAdjustInvoiceMessagesModel
            {
                MessageID = 0,
                MessageTime = DateTime.UtcNow,
                InvoiceID = 0,
                State = InsuranceStatus.Fail.ToDisplayName(),
                ErrorCode = errorCode,
                ErrorDesc = errorDesc,
                InvoiceNo = "00",
                InvoiceState = "0000"
            };
        }

        private static string Login(LoginModel model)
        {
            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                ServicePointManager.ServerCertificateValidationCallback += (sender, cert, chain, sslPolicyErrors) => true;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                HttpContent content = new StringContent(model.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/token", content).Result;
                if (!response.IsSuccessStatusCode)
                {
                    return null;
                    //throw new Exception(response.Content.ReadAsStringAsync().Result);
                }

                var data = response.Content.ReadAsStringAsync().Result.JsonDeserialize<TokenResult>();
                return data.Token;
            }
        }
    }
}
