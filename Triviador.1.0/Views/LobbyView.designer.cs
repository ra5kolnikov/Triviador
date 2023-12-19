// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Triviador.Views
{
	[Register ("LobbyView")]
	partial class LobbyView
	{
		[Outlet]
		AppKit.NSButton BackButton { get; set; }

		[Outlet]
		AppKit.NSTextField LobbyTF { get; set; }

		[Action ("BackButtonPressed:")]
		partial void BackButtonPressed (AppKit.NSButton sender);

		[Action ("StartGameButtonPressed:")]
		partial void StartGameButtonPressed (AppKit.NSButton sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (BackButton != null) {
				BackButton.Dispose ();
				BackButton = null;
			}

			if (LobbyTF != null) {
				LobbyTF.Dispose ();
				LobbyTF = null;
			}
		}
	}
}
