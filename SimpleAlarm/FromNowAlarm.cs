using System;

namespace SimpleAlarm
{

	public class FromNowAlarm : IAlarm
	{
		private Time time;

		private DateTime alarmDate;

		public Time GetTime() => time;

		public void Set(Time timeFromNow, DateTime alarmDate)
		{
			int hour = DateTime.Now.Hour;
			int minute = DateTime.Now.Minute;

			time = new Time(hour, minute);

			time += timeFromNow;

			this.alarmDate = alarmDate;
		}

		public void SnoozeFor(int minutes)
		{
			time.Minute += minutes;
		}
	}
}
