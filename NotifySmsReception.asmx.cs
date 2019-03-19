using System;
using System.Web;
using System.Web.Services;
using pimsnotifservice.PimsNotificationService;
using System.Web.Services.Protocols;

namespace pimsnotifservice
{
    [WebService(Namespace = "http://www.avea.com.tr/pims-partner/schema/smsNotification")]
    public class NotifySmsReception : WebService
    {

        [WebMethod]
        [SoapDocumentMethod(Action = "")]
        public NotifySmsReceptionResponse Notif(NotifySmsReceptionRequest notifySmsReceptionRequest)
        {
            return new NotifySmsReceptionResponse
            {
                resultCode = SmsNotificationServiceResultCode.OK,
                resultCodeSpecified = true
            };
        }
    }
}
