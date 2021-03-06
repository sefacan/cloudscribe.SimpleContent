﻿using System.Threading;
using System.Threading.Tasks;

namespace cloudscribe.SimpleContent.Models.EventHandlers
{
    public interface IHandlePostUnPublished
    {
        Task Handle(
            string projectId,
            IPost post,
            CancellationToken cancellationToken = default(CancellationToken)
            );
    }
}
