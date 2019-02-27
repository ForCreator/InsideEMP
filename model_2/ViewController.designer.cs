// WARNING
//
// This file has been generated automatically by Visual Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;

namespace model_2
{
    [Register ("ViewController")]
    partial class ViewController
    {
        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton But1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIButton ButIm1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UILabel Label1 { get; set; }

        [Outlet]
        [GeneratedCode ("iOS Designer", "1.0")]
        UIKit.UIView viewshed { get; set; }

        [Action ("But1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void But1_TouchUpInside (UIKit.UIButton sender);

        [Action ("ButIm1_TouchUpInside:")]
        [GeneratedCode ("iOS Designer", "1.0")]
        partial void ButIm1_TouchUpInside (UIKit.UIButton sender);

        void ReleaseDesignerOutlets ()
        {
            if (But1 != null) {
                But1.Dispose ();
                But1 = null;
            }

            if (ButIm1 != null) {
                ButIm1.Dispose ();
                ButIm1 = null;
            }

            if (Label1 != null) {
                Label1.Dispose ();
                Label1 = null;
            }

            if (viewshed != null) {
                viewshed.Dispose ();
                viewshed = null;
            }
        }
    }
}