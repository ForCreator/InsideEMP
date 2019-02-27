using System;

using UIKit;


namespace model_2
{
    public partial class ViewController : UIViewController
    {
  

        partial void But1_TouchUpInside(UIButton sender)
        {
            viewshed.Hidden = false;
        }

        public void LongPressing(){
            // UILabel label = new UILabel();
            But1.Hidden = false;
        }

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            try
            {
                UILongPressGestureRecognizer longPress = new UILongPressGestureRecognizer(LongPressing);
                ButIm1.AddGestureRecognizer(longPress);
            }
            catch { Exception exception; }
            // Perform any additional setup after loading the view, typically from a nib.
        }



        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}
