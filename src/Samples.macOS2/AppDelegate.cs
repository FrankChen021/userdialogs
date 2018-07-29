//
// AppDelegate.cs
//
// Author:
//       frankchen <frank.chen021@outlook.com>
//
// Copyright (c) 2018
using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

namespace Samples.macOS2
{
    [Register("AppDelegate")]
    public class AppDelegate : FormsApplicationDelegate
    {
        MainWindowController mainWindowController;

        public AppDelegate()
        {
        }

        public override NSWindow MainWindow => mainWindowController.Window;

        public override void DidFinishLaunching(NSNotification notification)
        {
            mainWindowController = new MainWindowController();
            mainWindowController.Window.MakeKeyAndOrderFront(this);

            Forms.Init();
            this.LoadApplication(new App());
        }

        public override void WillTerminate(NSNotification notification)
        {
            // Insert code here to tear down your application
        }
    }
}
