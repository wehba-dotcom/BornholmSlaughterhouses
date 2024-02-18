﻿using System.Collections.Generic;
using SharedModels;

namespace OrderApi.Infrastructure
{
    public interface IMessagePublisher
    {
        void PublishOrderStatusChangedMessage(string? ID,
            IList<OrderLine> orderLines, string topic);
    }
}
