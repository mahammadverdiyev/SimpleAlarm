using System.Drawing;
using System.Windows.Forms;

namespace SimpleAlarm
{
	public class FormWindowController
	{
		private SmartAlarm smartAlarm;
		public FormWindowController(SmartAlarm smartAlarm)
		{
			this.smartAlarm = smartAlarm;
		}
		private bool FullSized => smartAlarm.Size == Screen.PrimaryScreen.WorkingArea.Size;
		private bool IsFormOnZeroZeroCoordinate => smartAlarm.Location == Point.Empty;

		private Button[] buttons;
		public void MinimizeOrMaximize()
		{
			if (FormIsMaximized())
			{
				Minimize();
			}
			else
			{
				Maximize();
			}
		}
		private bool FormIsMaximized() => FullSized && IsFormOnZeroZeroCoordinate;

		public void Minimize()
		{
			smartAlarm.Size = new Size(690, 450);
			ChangeButtonsLocation(-5, 3);
		}

		public void Maximize()
		{
			smartAlarm.Size = Screen.PrimaryScreen.WorkingArea.Size;
			smartAlarm.Location = new Point(0, 0);
			ChangeButtonsLocation(-5, 3);
		}

		public void ChangeButtonsLocation(int xPos, int yPos)
		{
			for (int i = 0; i < buttons.Length; i++)
			{
				int currX = buttons[i].Location.X;
				int currY = buttons[i].Location.Y;
				buttons[i].Location = new Point(currX + xPos, currY + yPos);
			}
		}

		public void SetButtonArray(Button[] buttons)
		{
			this.buttons = buttons;
		}


		public void ChangeMinimizeMaximizeButtonIcon()
		{
			if (FullSized)
			{
				smartAlarm.MinimizeMaximizeButton.Image = Properties.Resources.restore_down;
			}
			else if (IsFormOnZeroZeroCoordinate)
			{
				smartAlarm.MinimizeMaximizeButton.Image = Properties.Resources.maximize;
			}
		}

		public void MoveForm()
		{
			if (FullSized && !IsFormOnZeroZeroCoordinate)
			{
				smartAlarm.MinimizeMaximizeButton.Image = SimpleAlarm.Properties.Resources.maximize;
				if (smartAlarm.CloseButton.Location == new Point(1318, 0))
					ChangeButtonsLocation(-5, 3);
			}
		}

	}
}
