// WARNING
//
// This file has been generated automatically by Visual Studio to store outlets and
// actions made in the UI designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using Foundation;
using System.CodeDom.Compiler;

namespace Triviador
{
	[Register ("MapView")]
	partial class MapView
	{
		[Outlet]
		AppKit.NSButtonCell MapButtonsArray { get; set; }

		[Action ("MapButtonPressed:")]
		partial void MapButtonPressed (AppKit.NSButtonCell sender);
		
		void ReleaseDesignerOutlets ()
		{
			if (MapButtonsArray != null) {
				MapButtonsArray.Dispose ();
				MapButtonsArray = null;
			}
		}
	}
}
