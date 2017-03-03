using System;
using UIKit;

using System.Timers;

namespace XamariniOSTimer
{
	public partial class ViewController : UIViewController
	{
		protected ViewController(IntPtr handle) : base(handle)
		{
			// Note: this .ctor should not contain any initialization logic.
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			Timer timer = new System.Timers.Timer();

			timer.Interval = 1000;
			timer.Enabled = true;
			timer.Elapsed += Timer_Elapsed;
			timer.Start();



		}

		private void Timer_Elapsed(object sender, ElapsedEventArgs e)
		{
			
			DateTime myDate = DateTime.Now;

			InvokeOnMainThread(() => { lblTimer.Text = myDate.ToString("F");});

		}

		public override void DidReceiveMemoryWarning()
		{
			base.DidReceiveMemoryWarning();
			// Release any cached data, images, etc that aren't in use.
		}
	}
}
