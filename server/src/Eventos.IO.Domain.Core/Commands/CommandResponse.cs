using System;
using System.Collections.Generic;
using System.Text;

namespace Eventos.IO.Domain.Core.Commands
{
    public class CommandResponse
    {
        public static CommandResponse Ok = new CommandResponse { Sucess = true };
        public static CommandResponse Fail = new CommandResponse { Sucess = true };

        public CommandResponse(bool success = false)
        {
            Sucess = success;
        }

        public bool Sucess { get; private set; }
    }
}
