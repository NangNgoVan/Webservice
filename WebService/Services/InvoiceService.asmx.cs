using System;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebService.Enum;
using WebService.Models.Account;
using WebService.Shared.Enums;
using WebService.Shared.Serialize;
using WebService.Models.Invoices.NewChangeDeleteInvoice;
using System.Xml;
using Newtonsoft.Json;
using System.IO;

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

        private static readonly string Username = ConfigurationManager.AppSettings["Username"];
        private static readonly string Password = ConfigurationManager.AppSettings["Password"];

        [WebMethod(Description = "New, Replace, Adjust.Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        //[SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public NewAdjustReplaceInvoiceMessagesModel CreateInvoice(NewAdjustReplaceInvoiceModel XMLINPUT)
        {

            var token = Login(new LoginModel {UserName = Username, Password = Password});

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
                try
                {
                    var response = client.PostAsync("/api/invoice-mic/create", content).Result;

                    if(!response.IsSuccessStatusCode)
                    {
                        return NewReplaceAdjustInvoiceMesages((int)response.StatusCode, response.ReasonPhrase);
                    }
                    var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<NewAdjustReplaceInvoiceMessagesModel>();

                    if(messages == null) return NewReplaceAdjustInvoiceMesages(400, "Lỗi nhận dữ liệu.");

                    return messages;
                }
                catch(Exception e)
                {
                    return NewReplaceAdjustInvoiceMesages(400, "Đã xảy ra lỗi: "+ e.ToString());
                }
            }
        }

        [WebMethod(Description = "Bên gửi: Hệ thống HDĐT của EInvoice. Bên nhận: Hệ thống core bảo hiểm của CMC")]
        [SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string RequestChangedInvoiceState(NewAdjustReplaceInvoiceMessagesModel XMLINPUT)
        {
            return "chờ bên CMS cấp link";
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        //[SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public NewAdjustReplaceInvoiceMessagesModel DeleteInvoice(NewAdjustReplaceInvoiceMessagesModel XMLINPUT)
         {

            var token = Login(new LoginModel { UserName = Username, Password = Password });

            if (string.IsNullOrEmpty(token))
                return new NewAdjustReplaceInvoiceMessagesModel()
                {
                    MessageID = XMLINPUT.MessageID,
                    MessageTime = DateTime.Now,
                    Status = "FAIL",
                    ErrorCode = 400,
                    ErrorDesc = "Tài khoản hoặc mật khẩu không đúng!"
                };

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
                try
                {
                    var response = client.PostAsync("/api/invoice-mic/delete", content).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        return new NewAdjustReplaceInvoiceMessagesModel()
                        {
                            MessageID = XMLINPUT.MessageID,
                            MessageTime = DateTime.Now,
                            Status = "FAIL",
                            ErrorCode = (int)response.StatusCode,
                            ErrorDesc = response.ReasonPhrase
                        };
                    }


                    var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<NewAdjustReplaceInvoiceMessagesModel>();
                    return messages;
                }
                catch(Exception e)
                {
                    return new NewAdjustReplaceInvoiceMessagesModel()
                    {
                        MessageID = XMLINPUT.MessageID,
                        MessageTime = DateTime.Now,
                        Status = "FAIL",
                        ErrorCode = 400,
                        ErrorDesc = "Đã có lỗi xảy ra ("+ e.ToString()+")"
                    };
                }
            }
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        //[SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public ProcessCertificatesMessagesModel ProcessCertificates(ProcessCertificatesModel XMLINPUT)
        {

            var token = Login(new LoginModel { UserName = Username, Password = Password });
            if (string.IsNullOrEmpty(token))
                return new ProcessCertificatesMessagesModel()
                {
                    MessageID = XMLINPUT.MessageID,
                    MessageTime = DateTime.Now,
                    Status = "FAIL",
                    ErrorCode = 400,
                    ErrorDesc = "Tài khoản hoặc mật khẩu không đúng!"
                };

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
                var x = XMLINPUT.JsonSerilaize();
                try
                {
                    var response = client.PostAsync("/api/invoice-mic/process-certificates", content).Result;

                    if (!response.IsSuccessStatusCode)
                    {
                        return new ProcessCertificatesMessagesModel()
                        {
                            MessageID = XMLINPUT.MessageID,
                            MessageTime = DateTime.Now,
                            Status = "FAIL",
                            ErrorCode = (int)response.StatusCode,
                            ErrorDesc = response.ReasonPhrase
                        };
                    }

                    var messages = response.Content.ReadAsStringAsync().Result.JsonDeserialize<ProcessCertificatesMessagesModel>();
                    return messages;
                }
                catch(Exception e)
                {
                    return new ProcessCertificatesMessagesModel() {
                        MessageID = XMLINPUT.MessageID,
                        MessageTime = DateTime.Now,
                        Status = "FAIL",
                        ErrorCode = -1,
                        ErrorDesc = "Đã có lỗi xảy ra ( " + e.ToString()+")"
                    };
                }
               
            }
        }

        [WebMethod(Description = "chưa rõ yêu cầu")]
        //[SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string EInvoice_VerifyInvoices()
        {
            return "Hello World";
        }

        [WebMethod(Description = "chưa rõ yêu cầu")]
        //[SoapHeader("InHeader", Direction = SoapHeaderDirection.In)]
        public string EInvoice_VerifyCertificates()
        {
            return "Hello World";
        }

        private static NewAdjustReplaceInvoiceMessagesModel NewReplaceAdjustInvoiceMesages(int errorCode,string errorDesc)
        {
            return new NewAdjustReplaceInvoiceMessagesModel
            {
                MessageID = 0,
                MessageTime = DateTime.UtcNow,
                InvoiceID = 0,
                State = InsuranceStatus.Fail.ToDisplayName(),
                ErrorCode = errorCode,
                ErrorDesc = errorDesc,
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
                try
                {
                    var response = client.PostAsync("/token", content).Result;
                    if (!response.IsSuccessStatusCode)
                    {
                        return null;
                        //throw new Exception(response.Content.ReadAsStringAsync().Result);
                    }
                    var data = response.Content.ReadAsStringAsync().Result.JsonDeserialize<TokenResult>();
                    return data.Data.Token;
                }
                catch(Exception e)
                {
                    return null;
                }                
            }
        }
    }
}
