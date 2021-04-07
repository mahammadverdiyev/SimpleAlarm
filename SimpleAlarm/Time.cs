namespace SimpleAlarm
{
	public class Time
	{
		private int hour;
		private int minute;

		public int Hour
		{
			get => hour;
			set => hour = value;
		}

		public int Minute
		{
			get => minute;
			set => minute = value;
		}

		public Time() { }

		public Time(int hour, int minute)
		{
			this.hour = hour;
			this.minute = minute;
		}

		public static Time operator +(Time left, Time right)
		{
			Time time = new Time();
			time.hour = left.hour + right.hour;

			int totalMinute = left.minute + right.minute;
			if (totalMinute > 60)
			{
				time.hour++;
				time.minute = totalMinute - 60;
			}

			return time;
		}
	}
}
