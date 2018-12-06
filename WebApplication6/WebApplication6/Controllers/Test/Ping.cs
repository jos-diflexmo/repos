using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace WebApplication6.Controllers.Test
{
    public class Ping : IRequest<string>
    {
    }

    public class PingHandler : RequestHandler<Ping, string>
    {
        protected override string Handle(Ping request)
        {
            return "Pong";
        }
    }
}
