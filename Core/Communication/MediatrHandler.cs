using Core.Entities;
using Core.Interfaces;
using Core.Messages;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Communication
{
    internal class MediatrHandler : IMediatorHandler
    {
        private readonly IMediator _mediator;

        public MediatrHandler(IMediator mediator)
        {
            _mediator = mediator;
        }

        public async Task<bool> SendCommand<T>(T command) where T : Command
        {
            return await _mediator.Send(command);
        }
    }
}
