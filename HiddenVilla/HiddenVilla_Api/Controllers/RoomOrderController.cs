using Business.Repository.IRepository;
using HiddenVilla_Api.Helper.Mail;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.AspNetCore.Mvc;
using Models;
using Stripe.Checkout;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;

namespace HiddenVilla_Api.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class RoomOrderController : Controller
    {
        private readonly IRoomOrderDetailsRepository _repository;

        public RoomOrderController(IRoomOrderDetailsRepository repository)
        {
            _repository = repository;
        }


        [HttpPost]
        public async Task<IActionResult> Create([FromBody] RoomOrderDetailsDTO details)
        {
            if (ModelState.IsValid)
            {
                var result = await _repository.Create(details);
                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Error while creating Room Details/ Booking"
                });
            }
        }



        [HttpPost]
        public async Task<IActionResult> PaymentSuccessful([FromBody] RoomOrderDetailsDTO details)
        {

            var service = new SessionService();
            var sessionDetails = service.Get(details.StripeSessionId);
            if (sessionDetails.PaymentStatus == "paid")
            {
                var result = await _repository.MarkPaymentSuccessful(details.Id);
                if (result == null)
                {
                    return BadRequest(new ErrorModel()
                    {
                        ErrorMessage = "Can not mark payment as successful"
                    });
                }


                //Sending mail
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(mailConfig.MailFrom, mailConfig.ProjectName + " Booking Confirmed");
                mail.To.Add(details.Email);
                mail.Body = "<table style = 'Margin:0 auto;background:#f6f6f6;border-collapse:collapse;border-color:transparent;border-spacing:0;float:none;margin:0 auto;padding:0;text-align:center;vertical-align:top;width:100%' >Dear "+ details.Name + " - " + details.Email + "</p><p>Thanks for getting started with our " + mailConfig.ProjectName + "!</p><p> You booking has been  confirmed at Hidden Villa  with order ID :"+details.Id+"</p><br></td></tr></tbody></table></td></tr></tbody></table>";
                mail.IsBodyHtml = true;
                mail.Subject = "Booking Confirmed";

                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.EnableSsl = true;
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(mailConfig.MailFrom, mailConfig.MailPasswrd);

                smtpClient.Send(mail);


                return Ok(result);
            }
            else
            {
                return BadRequest(new ErrorModel()
                {
                    ErrorMessage = "Can not mark payment as successful"
                });
            }

        }


    }
}
