using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConventionOfElements
{
	public partial class MainForm : Form
	{
		public const int WM_NCLBUTTONDOWN = 0xA1;
		public const int HT_CAPTION = 0x2;

		[DllImport("user32.dll")]
		public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
		[DllImport("user32.dll")]
		public static extern bool ReleaseCapture();

		private void MovingMouseDown(object sender, MouseEventArgs e)
		{
			if (e.Button != MouseButtons.Left) return;
			ReleaseCapture();
			SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
		}

		public MainForm()
		{
			InitializeComponent();
		}

		private readonly List<string> _buffs = new List<string>();
		private int _buff = 0;
		private int _alert = -1;
		private int _count = 4;

		private void buttonStart_Click(object sender, EventArgs e)
		{
			if (_alert == -1)
			{
				MessageBox.Show("Please select from dropdown what buff you want to track!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			
			if (timerPerSecond.Enabled)
			{
				timerPerSecond.Stop();
				buttonStart.Text = "Start";
			}
			else
			{
				if (MessageBox.Show("Press OK when Lightning is up!", "Start", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel) return;
				timerPerSecond.Start();
				_buff = 0;
				buttonStart.Text = "Pause";
				labelCounter.Text = _count.ToString();
				labelBuffText.Text = _buffs[_buff];
				labelBuffText.ForeColor = GetColorByNumber(_buff);
				if (_buff == _alert)
				{
					labelInfoText.Text = "ACTIVE\r\nBUFF";
					this.BackColor = Color.Crimson;
					labelInfoText.ForeColor = Color.Black;
				}
				else
				{
					labelInfoText.Text = "inactive\r\nbuff";
					this.BackColor = Color.Black;
					labelInfoText.ForeColor = Color.White;
				}
			}
		}

		private void timerPerSecond_Tick(object sender, EventArgs e)
		{
			_count--;
			if (_count != 0)
			{
				labelCounter.Text = _count.ToString();
				if (_buff == _alert)
					System.Media.SystemSounds.Exclamation.Play();
				return;
			}
			_count = 4;
			labelCounter.Text = _count.ToString();
			_buff++;
			if (_buff == _alert)
			{
				//System.Media.SystemSounds.Beep.Play();
				//System.Media.SystemSounds.Asterisk.Play();
				System.Media.SystemSounds.Exclamation.Play();
				//System.Media.SystemSounds.Question.Play();
				//System.Media.SystemSounds.Hand.Play();
				labelInfoText.Text = "ACTIVE\r\nBUFF";
				this.BackColor = Color.Crimson;
				labelInfoText.ForeColor = Color.Black;
			}
			else
			{
				labelInfoText.Text = "inactive\r\nbuff";
				this.BackColor = Color.Black;
				labelInfoText.ForeColor = Color.White;
			}
	
			labelBuffText.Text = _buffs[_buff];
			labelBuffText.ForeColor = GetColorByNumber(_buff);

			if (_buff >= 6)
				_buff = 0;
		}

		private static Color GetColorByNumber(int buff)
		{
			switch (buff)
			{
				case 0:
					return Color.Purple;
				case 1:
					return Color.Blue;
				case 2:
					return Color.DarkRed;
				case 3:
					return Color.Yellow;
				case 4:
					return Color.White;
				case 5:
					return Color.Gray;
				case 6:
					return Color.Green;
				default:
					return Color.White;
			}
		}

		private void buttonExit_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			labelInfoText.Text = "";
			labelCounter.Text = "";
			labelBuffText.Text = "";
			
			_buffs.Add("Lightning");
			_buffs.Add("Physical");
			_buffs.Add("Cold");
			_buffs.Add("Fire");
			_buffs.Add("Holy");
			//_buffs.Add("Poison");
			//_buffs.Add("Arcane");
		}

		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			var s = (ComboBox)sender;
			for (int i = 0; i < _buffs.Count; i++)
			{
				if (_buffs[i] == s.Text)
					_alert = i;
			}
		}


	}
}
