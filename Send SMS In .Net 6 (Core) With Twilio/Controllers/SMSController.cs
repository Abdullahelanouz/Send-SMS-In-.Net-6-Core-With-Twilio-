using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Send_SMS_In_.Net_6__Core__With_Twilio.Dtos;
using Send_SMS_In_.Net_6__Core__With_Twilio.Services;
using SendSMSWithTwilio.Services;

namespace Send_SMS_In_.Net_6__Core__With_Twilio.Controllers
{
   
    
        [Route("api/[controller]")]
        [ApiController]
        public class SMSController : ControllerBase
        {
            private readonly ISMSService _smsService;

            public SMSController(ISMSService smsService)
            {
                _smsService = smsService;
            }

            [HttpPost("send")]
            public IActionResult Send(SendSMSDto dto)
            {
            var result = _smsService.Send(dto.MobileNumber, dto.Body);

                if (!string.IsNullOrEmpty(result.ErrorMessage))
                    return BadRequest(result.ErrorMessage);

                return Ok(result);
            }
        }
    
}
