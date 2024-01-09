using System;
using JetBrains.Annotations;

namespace Sub
{
	public class BaseEvent<T>
	{
		public T EventName { get; set; }
		public Action<object> ListenerAction { get; set; }
		[CanBeNull]
		public Action CallerAction { get; set; }
	}
}