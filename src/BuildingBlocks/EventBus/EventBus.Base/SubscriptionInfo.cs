﻿namespace EventBus.Base
{
	public class SubscriptionInfo
	{
		public Type HandlerType { get; }

		public SubscriptionInfo(Type handlerType)
		{
			HandlerType = handlerType ?? throw new ArgumentNullException(nameof(handlerType));
		}

		public static SubscriptionInfo Typed(Type handleType)
		{
			return new SubscriptionInfo(handleType);
		}
	}
}
