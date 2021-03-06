﻿using System.Collections.Generic;
using ServiceStack.Webhooks.ServiceModel.Types;

namespace ServiceStack.Webhooks
{
    public interface IEventSubscriptionCache
    {
        /// <summary>
        ///     Gets all the subscriptions for the specified event
        /// </summary>
        List<SubscriptionRelayConfig> GetAll(string eventName);
    }
}