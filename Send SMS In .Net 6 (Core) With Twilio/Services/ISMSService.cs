using Twilio.Rest.Api.V2010.Account;

namespace Send_SMS_In_.Net_6__Core__With_Twilio.Services
{
    public class ISMSService
    {
        MessageResource Send(string mobileNumber, string body);
    }
}
