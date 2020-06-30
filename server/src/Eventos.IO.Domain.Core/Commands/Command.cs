using Eventos.IO.Domain.Core.Events;
using MediatR;
using System;

namespace Eventos.IO.Domain.Core.Commands
{
    public class Command : Message//, IRequest<Unit>
    {
        public Command()
            =>TimeStamp = DateTime.Now;

        public DateTime TimeStamp { get; private set; }
    }
}
