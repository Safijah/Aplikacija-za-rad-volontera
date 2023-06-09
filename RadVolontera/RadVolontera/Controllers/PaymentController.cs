﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RadVolontera.Services.Interfaces;

namespace RadVolontera.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaymentController : BaseCRUDController<Models.Payment.Payment, Models.Filters.PaymentSearchObject, Models.Payment.PaymentRequest, Models.Payment.PaymentRequest,long>
    {
        public PaymentController(ILogger<BaseController<Models.Payment.Payment, Models.Filters.PaymentSearchObject, long>> logger, IPaymentService service) : base(logger, service)
        {

        }
    }
}
