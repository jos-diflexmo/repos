using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using WebApplication6.Controllers.Test;

namespace WebApplication6.Controllers
{
    public class TestController : Controller
    {
        private readonly IMediator _mediator;

        public TestController(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<IActionResult> Ping()
        {
            var response = await _mediator.Send(new Ping());
            Debug.WriteLine(response); // "Pong"

            return View();
        }
    }
}