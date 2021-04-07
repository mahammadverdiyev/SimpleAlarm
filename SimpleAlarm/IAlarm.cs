using System;

namespace SimpleAlarm
{
	public interface IAlarm
	{
		Time GetTime();
		void Set(Time time, DateTime alarmDate);
		void SnoozeFor(int minutes);
	}
}
