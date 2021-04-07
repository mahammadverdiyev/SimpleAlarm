using System;

namespace SimpleAlarm
{
	public class SpecifiedDateAlarm : IAlarm
	{
		private Time time;

		private DateTime alarmDate;

		public Time GetTime()
		{
			return time;
		}

		public void Set(Time time, DateTime alarmDate)
		{
			this.time = time;
			this.alarmDate = alarmDate;
		}

		public void SnoozeFor(int minutes)
		{
			time.Minute += minutes;
		}
	}
}
