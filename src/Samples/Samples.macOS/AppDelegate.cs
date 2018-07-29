using AppKit;
using Foundation;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;


namespace Samples.macOS
{
	[Register("AppDelegate")]
	public class AppDelegate : FormsApplicationDelegate
	{
		readonly NSWindow window;


		public AppDelegate()
		{
			var style = NSWindowStyle.Closable | NSWindowStyle.Resizable | NSWindowStyle.Titled;
			var rect = new CoreGraphics.CGRect(200, 1000, 1024, 768);
			this.window = new NSWindow(rect, style, NSBackingStore.Buffered, false)
			{
				Title = "ACR User Dialogs",
				TitleVisibility = NSWindowTitleVisibility.Hidden
			};
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
