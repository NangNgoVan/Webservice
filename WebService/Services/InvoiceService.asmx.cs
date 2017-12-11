using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using WebService.Enum;
using WebService.Models.Account;
using WebService.Models.customers;
using WebService.Models.invoices;
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
                return NewReplaceAdjustInvoiceMesages();

            var token = Login(new LoginModel {UserName = InHeader.Username, Password = InHeader.Password});
            if (string.IsNullOrEmpty(token))
                return NewReplaceAdjustInvoiceMesages();

            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
                client.BaseAddress = new Uri(BaseUri);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                client.DefaultRequestHeaders.Add("Authorization", $"Bearer {token}");

                var create = new CreateInvoiceModel
                {
                    InvoiceDate = DateTime.Parse("2017-12-07"),
                    Note = null,
                    IdReferenceInvoice = null,
                    IdInvoiceTemplate = 7,
                    IdInvoiceType = 1,
                    TotalAmount = 1000,
                    IsVatForInvoice = true,
                    VatPercent = 0,
                    VatAmount = 100,
                    ToCurrency = "VND",
                    ExchangeRate = 1,
                    PaymentMethod = "TienMatHoacChuyenKhoan",
                    PaymentDate = DateTime.Parse("2017-12-07"),
                    PaymentAmountWords = "Một nghìn, một trăm đồng chẵn!",
                    PaymentAmount = 1100,
                    Customer = new CreateCustomerModel
                    {
                        Address = "125 Cao Bá Quát Nha Trang",
                        Code = "f74b02a2-73d9-4d83-b839-ad68150ea2a6",
                        CustomerCode = "1234567",
                        FullName = "Nguyễn Hoàng Long",
                        LegalName = "Nguyễn Hoàng Long",
                        Phone = "0252223522",
                        TaxCode = "",
                        Id = Guid.Parse("ea0fcbde-74de-418f-c97d-08d53c5accdb")
                    },
                    InvoiceDetails = new List<CreateInvoiceDetailModel>
                        {
                            new CreateInvoiceDetailModel
                            {
                                DiscountAmount = 0,
                                DiscountPercent = 0,
                                PaymentAmount = 1100,
                                Quantity = 1,
                                TotalAmount = 1000,
                                Operator = null,
                                TotalAmountAfterAdjustment = 0,
                                UnitId = "5",
                                UnitName = "CHIEC",
                                UnitPrice = 1000,
                                VatPercent = 10,
                                VatAmount = 100,
                                ProductId = "ao",
                                ProductName = "ÁO"
                            }
                        }
                };

                HttpContent content = new StringContent(create.JsonSerilaize(), Encoding.UTF8,
                    "application/json");
                var response = client.PostAsync("/api/invoices/create", content).Result;
                if (!response.IsSuccessStatusCode) throw new Exception(response.Content.ReadAsStringAsync().Result);
                var datas = response.Content.ReadAsStringAsync().Result.JsonDeserialize<InvoiceModel>();
                return new NewReplaceAdjustInvoiceMessagesModel();
            }
        }

        private static NewReplaceAdjustInvoiceMessagesModel NewReplaceAdjustInvoiceMesages()
        {
            return new NewReplaceAdjustInvoiceMessagesModel
            {
                MessageID = 0,
                MessageTime = DateTime.UtcNow,
                InvoiceID = 0,
                State = Status.Fail.ToDisplayName(),
                ErrorCode = 400,
                ErrorDesc = "Tài khoản khoản hoặc mật khẩu không đúng!",
                InvoiceNo = "00",
                InvoiceState = "0000"
            };
        }

        [WebMethod(Description = "Bên gửi: Hệ thống HDĐT của EInvoice. Bên nhận: Hệ thống core bảo hiểm của CMC")]
        public string NoticeStateChangedInsuranceInvoice(NewReplaceAdjustInvoiceMessagesModel XMLINPUT)
        {
            return "Hello World";
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        public string DeleteInsuranceInvoice(NewReplaceAdjustInvoiceMessagesModel XMLINPUT)
        {
            return "Hello World";
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        public string ReplaceInsuranceInvoice(ReplaceInsuranceInvoiceModel XMLINPUT)
        {
            return "Hello World";
        }

        [WebMethod(Description = "Bên gửi: Hệ thống core bảo hiểm của CMC. Bên nhận: Hệ thống HDĐT của EInvoice")]
        public string ProcessCertificates(CertificatesModel XMLINPUT)
        {
            return "Hello World";
        }

        [WebMethod]
        public string EInvoiceVerifyInvoices()
        {
            return "Hello World";
        }

        [WebMethod]
        public string EInvoiceVerifyCertificates()
        {
            return "Hello World";
        }

        private static string Login(LoginModel model)
        {
            using (var client = new HttpClient())
            {
                //specify to use TLS 1.2 as default connection
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12 | SecurityProtocolType.Tls11 | SecurityProtocolType.Tls;
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
