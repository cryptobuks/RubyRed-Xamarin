using UIKit;
using System;

namespace CrossPlatformApp.iOS {
	public partial class ViewController : UIViewController {
		public ViewController(IntPtr handle) : base(handle) {
			
		}

		public override void ViewDidLoad() {
			base.ViewDidLoad();
			setupButton();
		}

		public override void DidReceiveMemoryWarning() {
			base.DidReceiveMemoryWarning();
		}

		private void setupButton() {
			Button.AccessibilityIdentifier = "myButton";
			Button.TouchUpInside += delegate {
				View.BackgroundColor = getRandomColor();
			};
		}

		private UIColor getRandomColor() {
			return UIColor.FromHSB((MyClass.getRandomColorValue()/255.0f),1.0f,1.0f);
		}
	}
}
